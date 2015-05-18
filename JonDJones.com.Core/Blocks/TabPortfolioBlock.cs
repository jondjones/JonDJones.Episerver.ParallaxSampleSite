using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using JonDJones.Com.Core.Pages.Base;
using EPiServer.DataAbstraction;
using JonDJones.com.Core.Blocks.Base;
using EPiServer;

namespace JonDJones.Com.Core.Pages
{

    [ContentType(
        DisplayName = "Tab Portfolio Block",
        GUID = "DFBB388C-88FF-4FFA-9BF5-824B58338D24",
        Description = "Tab Portfolio Block")]
    public class TabPortfolioBlock : BaseTabBlock
    {    
        [Display(
            Name = "Portfolio Gallery",
            Description = "Portfolio Gallery",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual ContentArea PortfolioGallery { get; set; }
    }
}