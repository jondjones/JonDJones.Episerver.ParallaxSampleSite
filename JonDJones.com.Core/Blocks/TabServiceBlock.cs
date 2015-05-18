using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using JonDJones.Com.Core.Pages.Base;
using EPiServer.DataAbstraction;
using JonDJones.com.Core.Blocks.Base;

namespace JonDJones.Com.Core.Pages
{

    [ContentType(
        DisplayName = "Tab Service Block",
        GUID = "5D5AFDED-6070-467F-AB36-D0280A5F9039",
        Description = "Tab Service Block")]
    public class TabServiceBlock : BaseTabBlock
    {
        [Display(
            Name = "Primary Description",
            Description = "Primary Description",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual XhtmlString MainDescription { get; set; }

        [Display(
            Name = "Secondary Title",
            Description = "Secondary Title",
            GroupName = SystemTabNames.Content,
            Order = 500)]
        public virtual string SecondaryTitle { get; set; }

        [Display(
            Name = "Secondary Description",
            Description = "Secondary Description",
            GroupName = SystemTabNames.Content,
            Order = 600)]
        public virtual XhtmlString SecondaryDescription { get; set; }

          [Display(
            Name = "Tertiary Title",
            Description = "Tertiary Title",
            GroupName = SystemTabNames.Content,
            Order = 700)]
        public virtual string TertiaryTitle { get; set; }

        [Display(
            Name = "Tertiary Description",
            Description = "Tertiary Description",
            GroupName = SystemTabNames.Content,
            Order = 800)]
         public virtual XhtmlString TertiaryDescription { get; set; }

         [Display(
            Name = "Quaternary Title",
            Description = "Quaternary Title",
            GroupName = SystemTabNames.Content,
            Order = 900)]
        public virtual string QuaternaryTitle { get; set; }

        [Display(
            Name = "Quaternary Description",
            Description = "Quaternary Description",
            GroupName = SystemTabNames.Content,
            Order = 1000)]
         public virtual XhtmlString QuaternaryDescription { get; set; }

    }
}