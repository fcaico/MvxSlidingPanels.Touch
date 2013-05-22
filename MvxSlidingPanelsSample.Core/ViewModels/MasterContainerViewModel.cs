using System;
using Cirrious.MvvmCross.ViewModels;

namespace MvxSlidingPanelsSample.Core.ViewModels
{
    public class MasterContainerViewModel : BaseViewModel
    {
		public MasterContainerViewModel()
		{
			DisplayName = "Default Master";
		}

		public override void Start ()
		{
			base.Start();
		}
	
    }
}

