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
    public class TabPortfolioBlockController : BaseBlockController<TabPortfolioBlock>
    {
        public override ActionResult Index(TabPortfolioBlock currentBlock)
        {
            return PartialView("Index", new TabPortfolioViewModel(currentBlock, EpiServerDependencies));
        }
    }
}