using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EpiserverSite3.Models.Blocks;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;

namespace EpiserverSite3.Controllers
{
    [TemplateDescriptor(Inherited = true, TemplateTypeCategory = TemplateTypeCategories.MvcPartialView, Path = "~/Views/Shared/Blocks/CallToActionBlock.cshtml")]
    public class CallToActionBlockController : BlockController<CallToActionBlock>
    {
        public override ActionResult Index(CallToActionBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
