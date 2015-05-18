using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using JonDJones.Com.Core.Pages.Base;
using EPiServer.DataAbstraction;

namespace JonDJones.Com.Core.Pages
{

    [ContentType(
        DisplayName = "Start Page",
        GUID = "6671aa96-0a1b-4618-88e3-c98e1a78dcb4",
        Description = "Start Page",
        GroupName = "Standard")]
    public class StartPage : GlobalBasePage
    {
        [Display(
            Name = "Page Title",
            Description = "Page Title",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        [CultureSpecific]
        public virtual string PageTitle { get; set; }

        [Display(
            Name = "Main Title",
            Description = "Main Title",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual string MainTitle { get; set; }

        [Display(
            Name = "Main Description",
            Description = "Main Description",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual XhtmlString MainDescription { get; set; }

        [Display(
            Name = "Main Content Area",
            Description = "Region where content blocks can be placed",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual ContentArea MainContentArea { get; set; }


    }
}