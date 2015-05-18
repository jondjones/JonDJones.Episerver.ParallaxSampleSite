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
        GUID = "4709C473-D5AE-4C25-A2EA-57E8994BE00C",
        Description = "Tab Portfolio Block")]
    public class BaseTabBlock : SiteBlockData
    {

        [Display(
            Name = "Disaply Name",
            Description = "Disaply Name",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string DispalyName { get; set; }

        [Display(
            Name = "Tab Name",
            Description = "Tab Name",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual string TabName { get; set; }

        [Display(
            Name = "Main Title",
            Description = "Main Title",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual string MainTitle { get; set; }            
    }
}