using System.ComponentModel.DataAnnotations;
using EpiserverSite3.Models.Pages;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace  EpiserverSite3.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }
 
        IContent Section { get; set; }
    }
}