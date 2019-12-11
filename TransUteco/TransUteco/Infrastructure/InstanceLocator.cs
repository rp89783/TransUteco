using System;
using System.Collections.Generic;
using System.Text;
using TransUteco.ViewModel;

namespace TransUteco.Infrastructure
{
    class InstanceLocator
    {
        public clsMasterPageViewModel.MasterPageViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new clsMasterPageViewModel.MasterPageViewModel();
        }

    }
}
