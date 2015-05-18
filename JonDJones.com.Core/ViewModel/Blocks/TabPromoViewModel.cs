using JonDJones.Com.Core;
using JonDJones.Com.Core.Pages;
using JonDJones.Com.Core.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JonDJones.com.Core.Extensions;

namespace JonDJones.com.Core.ViewModel.Blocks
{
    public class TabPromoViewModel : BlockViewModel<TabPromoBlock>
    {
        public TabPromoViewModel(TabPromoBlock currentBlock, IEpiServerDependencies epiServerDependencies)
            : base(currentBlock, epiServerDependencies)
        {

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
