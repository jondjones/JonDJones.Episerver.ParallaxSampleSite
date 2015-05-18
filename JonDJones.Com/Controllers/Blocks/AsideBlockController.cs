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
    public class AsideBlockController : BaseBlockController<AsideBlock>
    {
        public override ActionResult Index(AsideBlock currentBlock)
        {
            return PartialView("Index", new AsideItemViewModel(currentBlock, EpiServerDependencies));
        }
    }
}