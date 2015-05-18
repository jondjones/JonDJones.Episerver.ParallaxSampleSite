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
    public class AsideItemViewModel : BlockViewModel<AsideBlock>
    {
        public AsideItemViewModel(AsideBlock currentBlock, IEpiServerDependencies epiServerDependencies)
            : base(currentBlock, epiServerDependencies)
        {
        }
        public string LinkUrl
        {
            get
            {
                return CurrentBlock.AsideUrl.IfNotDefault(_epiServerDependencies.LinkResolver.ResolveUrl) ?? string.Empty;
            }
        }
    }
}
