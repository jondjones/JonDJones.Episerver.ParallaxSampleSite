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
        DisplayName = "Tab Promo Block",
        GUID = "D465CE03-6910-4FA3-A6AB-72EA826954B4",
        Description = "Tab Promo Block")]
    public class TabPromoBlock : BaseTabBlock
    {
        [Display(
            Name = "Main Description",
            Description = "Main Description",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual XhtmlString MainDescription { get; set; }

        [Display(
            Name = "Link Text",
            Description = "Link Text",
            GroupName = SystemTabNames.Content,
            Order = 500)]
        public virtual string LinkText { get; set; }

        [Display(
            Name = "Link Text",
            Description = "Link Text",
            GroupName = SystemTabNames.Content,
            Order = 500)]
        public virtual Url LinkUrl { get; set; }
    }
}