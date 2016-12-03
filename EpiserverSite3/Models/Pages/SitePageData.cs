using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using EPiServer.Web;


namespace EpiserverSite3.Models.Pages
{
    public abstract class SitePageData : PageData//, ICustomCssInContentArea
    {
        [Display(
            GroupName = Global.GroupNames.MetaData,
            Order = 100)]
        [CultureSpecific]
        public virtual string MetaTitle
        {
            get
            {
                var metaTitle = this.GetPropertyValue(p => p.MetaTitle);

                // Use explicitly set meta title, otherwise fall back to page name
                return !string.IsNullOrWhiteSpace(metaTitle)
                       ? metaTitle
                       : PageName;
            }
            set { this.SetPropertyValue(p => p.MetaTitle, value); }
        }


        [Display(
            GroupName = SystemTabNames.Settings,
            Order = 200)]
        [CultureSpecific]
        public virtual bool HideSiteHeader { get; set; }

        [Display(
            GroupName = SystemTabNames.Settings,
            Order = 300)]
        [CultureSpecific]
        public virtual bool HideSiteFooter { get; set; }

        public string ContentAreaCssClass
        {
            get { return "teaserblock"; } //Page partials should be style like teasers
        }
    }
}