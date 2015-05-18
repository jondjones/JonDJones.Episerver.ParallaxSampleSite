using JonDJones.com.Core.ViewModel.Blocks;
using JonDJones.Com.Controllers.Base;
using JonDJones.Com.Core.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JonDJones.Com.Controllers.Blocks
{
    public class TabPromoBlockController : BaseBlockController<TabPromoBlock>
    {
        public override ActionResult Index(TabPromoBlock currentBlock)
        {
            return PartialView("Index", new TabPromoViewModel(currentBlock, EpiServerDependencies));
        }
    }
}