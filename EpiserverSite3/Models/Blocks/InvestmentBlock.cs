using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverSite3.Models.Blocks
{
    [ContentType(DisplayName = "InvestmentBlock", GUID = "73ac47ad-f013-4aee-b867-887aa9d890be", Description = "")]
    public class InvestmentBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "Header description",
            GroupName = SystemTabNames.Content,
            Order = 1)]

        [Required]
        public virtual string Header { get; set; }

        [Display(
            Name = "Image",
            Description = "Chose an image for the block",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual Url Image { get; set; }
    }
}