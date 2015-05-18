using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using JonDJones.com.Core.Blocks.Base;
using EPiServer.Web;
using EPiServer.DataAbstraction;
using JonDJones.Com.Core.Pages;

namespace JonDJones.Com.Core.Blocks
{
    [ContentType(DisplayName = "Aside Block",
        GUID = "90FAEA4A-6BDE-4B8C-B78F-B5F76B4672C5",
        Description = "Aside Block")]
    public class AsideBlock : SiteBlockData
    {
        [Required]
        [Display(Name = "Aside Title",
            Description = "Aside Title",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual string AsideTitle { get; set; }

        [Display(Name = "Aside Description",
            Description = "Aside Description",
            GroupName = SystemTabNames.Content,
            Order = 500)]
        public virtual string AsideDescription { get; set; }

        [Display(
              Name = "Aside Url",
              Description = "Aside Url",
              GroupName = SystemTabNames.Content,
              Order = 600)]
        public virtual Url AsideUrl { get; set; }
    }
}
