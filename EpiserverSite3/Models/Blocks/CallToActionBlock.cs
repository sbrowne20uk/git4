using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer;

namespace EpiserverSite3.Models.Blocks
{
    [ContentType(DisplayName = "CallToActionBlockBlock", GUID = "6d6f0365-0f15-48e5-adc6-89baa64707d0", Description = "Call To Action Block")] //d
    public class CallToActionBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "Header description",
            GroupName = SystemTabNames.Content,
            Order = 1)]

        [Required]
        public virtual string Header { get; set; }

        [Required]
        public virtual string Paragraph { get; set; }

        [Display(
            Name = "Image",
            Description = "Chose an image for the block",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual Url Image { get; set; }

        [UIHint("AppSettings")]
        [Searchable(false)]
        [CultureSpecific(false)]
        [Display(Name = "The Colour", Description = "Select the colour", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual string Colour { get; set; }

        [UIHint("AppSettings")]
        [Searchable(false)]
        [CultureSpecific(false)]
        [Display(Name = "Column Width", Description = "Select the width of the column", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual string Size { get; set; }

        public virtual bool DisplayButton { get; set; }

        public virtual string ButtonText { get; set; }

        public virtual Url ButtonLink { get; set; }
    }
}