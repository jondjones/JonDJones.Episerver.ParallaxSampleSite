using JonDJones.Com.Core;
using JonDJones.Com.Core.Pages;
using JonDJones.Com.Core.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonDJones.com.Core.ViewModel.Blocks
{
    public class TabServiceViewModel : BlockViewModel<TabServiceBlock>
    {
        public TabServiceViewModel(TabServiceBlock currentBlock, IEpiServerDependencies epiServerDependencies)
            : base(currentBlock, epiServerDependencies)
        {

        }
    }
}
