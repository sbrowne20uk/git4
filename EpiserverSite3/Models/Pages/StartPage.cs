using EPiServer.Core;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EPiServer;
using EPiServer.DataAbstraction;
using EPiServer.Framework.DataAnnotations;

namespace EpiserverSite3.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "041405a8-8fcd-4a9f-a30a-aee31385211e", Description = "", GroupName = Global.GroupNames.News)]
    public class StartPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        public virtual ContentArea MainContentArea { get; set; }

        public virtual ContentArea InvestContentArea { get; set; }
    }
}