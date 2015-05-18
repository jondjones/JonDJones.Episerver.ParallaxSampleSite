using JonDJones.Com.Core;
using JonDJones.Com.Core.Pages;
using JonDJones.Com.Core.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JonDJones.com.Core.Extensions;
using JonDJones.Com.Core.Blocks;
using JonDJones.com.Core.Media;

namespace JonDJones.com.Core.ViewModel.Blocks
{
    public class PortfolioItemViewModel : BlockViewModel<PortfolioItemBlock>
    {
        public PortfolioItemViewModel(PortfolioItemBlock currentBlock, IEpiServerDependencies epiServerDependencies)
            : base(currentBlock, epiServerDependencies)
        {

        }

        public string ImageUrl
        {
            get
            {
                var asset = _epiServerDependencies.ContentRepository.Get<ImageFile>(CurrentBlock.ImageUrl);
                return asset.IfNotDefault(_epiServerDependencies.LinkResolver.ResolveUrl) ?? string.Empty;
            }
        }

        public string LinkUrl
        {
            get
            {
                return CurrentBlock.LinkUrl.IfNotDefault(_epiServerDependencies.LinkResolver.ResolveUrl) ?? string.Empty;
            }
        }
    }
}
