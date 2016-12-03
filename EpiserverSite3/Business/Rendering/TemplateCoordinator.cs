using System;
using System.Web.Mvc;
using EpiserverSite3.Controllers;
using EpiserverSite3.Models.Blocks;
using EpiserverSite3.Models.Pages;
using EPiServer.Core;
using EPiServer.Core.Html.StringParsing;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EPiServer.Web.Mvc.Html;
using EPiServer;
using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;


namespace EpiserverSite3.Business.Rendering
{
    [ServiceConfiguration(typeof(IViewTemplateModelRegistrator))]
    public class TemplateCoordinator : IViewTemplateModelRegistrator
    {
        public const string BlockFolder = "~/Views/Shared/Blocks/";
        public const string PagePartialsFolder = "~/Views/Shared/PagePartials/";

        public static void OnTemplateResolved(object sender, TemplateResolverEventArgs args)
        {
            //Disable DefaultPageController for page types that shouldn't have any renderer as pages
            if (args.ItemToRender is IContainerPage && args.SelectedTemplate != null && args.SelectedTemplate.TemplateType == typeof(StartPageController))
            {
                args.SelectedTemplate = null;
            }
        }

        /// <summary>
        /// Registers renderers/templates which are not automatically discovered, 
        /// i.e. partial views whose names does not match a content type's name.
        /// </summary>
        /// <remarks>
        /// Using only partial views instead of controllers for blocks and page partials
        /// has performance benefits as they will only require calls to RenderPartial instead of
        /// RenderAction for controllers.
        /// Registering partial views as templates this way also enables specifying tags and 
        /// that a template supports all types inheriting from the content type/model type.
        /// </remarks>
        public void Register(TemplateModelCollection viewTemplateModelRegistrator)
        {
            viewTemplateModelRegistrator.Add(typeof(BannerFullWidthBlock), new TemplateModel
            {
                Name = "BannerFullWidthBlock",
                Tags = new[] { Global.ContentAreaTags.FullWidth },
                AvailableWithoutTag = false,
                Path = BlockPath("BannerFullWidthBlock.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(InvestmentBlock), new TemplateModel
            {
                Name = "InvestmentBlock",
                Tags = new[] { Global.ContentAreaTags.OneThirdWidth, Global.ContentAreaTags.TwoThirdsWidth, Global.ContentAreaTags.FullWidth },
                AvailableWithoutTag = false,
                Path = BlockPath("InvestmentBlock.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(SitePageData), new TemplateModel
            {
                Name = "PagePartial",
                Inherit = true,
                AvailableWithoutTag = true,
                Path = PagePartialPath("Page.cshtml")
            });

           

        }

        private static string BlockPath(string fileName)
        {
            return string.Format("{0}{1}", BlockFolder, fileName);
        }

        private static string PagePartialPath(string fileName)
        {
            return string.Format("{0}{1}", PagePartialsFolder, fileName);
        }
    }
}