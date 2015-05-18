using JonDJones.com.Core.ViewModel.Blocks;
using JonDJones.Com.Controllers.Base;
using JonDJones.Com.Core.Blocks;
using JonDJones.Com.Core.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JonDJones.Com.Controllers.Blocks
{
    public class PortfolioItemBlockController : BaseBlockController<PortfolioItemBlock>
    {
        public override ActionResult Index(PortfolioItemBlock currentBlock)
        {
            return PartialView("Index", new PortfolioItemViewModel(currentBlock, EpiServerDependencies));
        }
    }
}