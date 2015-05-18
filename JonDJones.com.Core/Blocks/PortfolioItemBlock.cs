using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using JonDJones.com.Core.Blocks.Base;
using EPiServer.Web;
using EPiServer.DataAbstraction;

namespace JonDJones.Com.Core.Blocks
{
    [ContentType(DisplayName = "Portfolio Item Block",
        GUID = "1856ce89-117a-436c-bbd6-1c56c562a6ac", 
        Description = "Block for displaying an image")]
    public class PortfolioItemBlock : SiteBlockData
    {
        [Required]
        [Display(Name = "Image",
            Description = "Image",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ImageUrl { get; set; }

        [Display(Name = "Alternative text",
            Description = "Alternative text",
            GroupName = SystemTabNames.Content,
            Order = 500)]
        public virtual string AlternativeText { get; set; }

        [Display(
              Name = "Link Text",
              Description = "Link Text",
              GroupName = SystemTabNames.Content,
              Order = 600)]
        public virtual Url LinkUrl { get; set; }
    }
}
