using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace EpiserverSite3.Models.Media
{
    [ContentType(DisplayName = "GenericMedia", GUID = "89761dbb-bf22-4cee-93c7-9d661d75cad8", Description = "Used for generic file types such as Word or PDF documents.")]
    [MediaDescriptor(ExtensionString = "pdf,doc,docx,jpg,jpeg,png,gif")]
    public class GenericMedia : MediaData
    {
        [CultureSpecific]
        [Editable(true)]
        [Display(
            Name = "Description",
            Description = "Add a description of the content.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual String Description { get; set; }
    }
}