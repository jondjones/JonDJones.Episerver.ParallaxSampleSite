﻿
using JonDJones.com.Core.Entities;
using JonDJones.com.Core.ViewModel.Shared;
using System.Collections.Generic;

namespace JonDJones.Com.Core.ViewCore.Shared
{
    public class LayoutViewModel
    {
        //public HeaderViewModel HeaderProperties { get; set; }

        public MetaDataViewModel MetaDataProperties { get; set; }

        public IList<NavigationItem>  Menu { get; set; }
    }
}
