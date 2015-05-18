using System.Collections.Generic;
using System.Linq;
using EPiServer.Core;
using JonDJones.Com.Core.Pages;
using JonDJones.Com.Core.ViewCore;
using JonDJones.com.Core.ViewModel.Shared;
using JonDJones.com.Core.Interfaces;
using EPiServer.Shell.Navigation;
using JonDJones.com.Core.Helpers;
using JonDJones.com.Core.Entities;
using JonDJones.com.Core.Extensions;
using JonDJones.Com.Core.ViewCore.Shared;

namespace JonDJones.Com.Core
{
    public class ViewModelFactory
    {
        IBlockHelper _blockHelper;

        IEpiServerDependencies _epiServerDependencies;

        public ViewModelFactory(IBlockHelper blockHelper, IEpiServerDependencies epiServerDependencies)
        {
            _blockHelper = blockHelper;
            _epiServerDependencies = epiServerDependencies;
        }

        public LayoutViewModel CreateLayoutViewModel(PageData currentPage)
        {
            var homePage = _epiServerDependencies.ContentRepository.Get<StartPage>(ContentReference.StartPage);
            
            var layoutModel = new LayoutViewModel
                {
                    MetaDataProperties = CreateSeoViewModel(homePage),
                    Menu = CreateMenu(homePage)
                };

            return layoutModel;
        }

        private IList<NavigationItem> CreateMenu(StartPage startPage)
        {
            var list = new List<NavigationItem>();

            return _blockHelper.GetContentsOfType<BaseTabBlock>(startPage.MainContentArea)
                                                    .Select(x => new NavigationItem() { Name = x.TabName, Link = x.TabName })
                                                    .ToReadOnlyList();
        }

        private MetaDataViewModel CreateSeoViewModel(IPageMetaDataProperties metaDataProperties)
        {
            return metaDataProperties == null ? null : new MetaDataViewModel(metaDataProperties, _epiServerDependencies.LinkResolver);
        }
    }

}
