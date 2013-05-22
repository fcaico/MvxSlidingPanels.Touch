using System;
using Cirrious.MvvmCross.Touch.Views;
using SlidingPanels.Lib;
using MonoTouch.UIKit;
using SlidingPanels.Lib.PanelContainers;
using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using MvxSlidingPanelsSample.Core.ViewModels;

namespace MvxSlidingPanels.Touch.Views
{
    public class MasterContainerView : MvxViewController
    {
		public override void ViewDidLoad()
		{
			View = new UIView(){ BackgroundColor = UIColor.White};
			base.ViewDidLoad();
		}

		public override void ViewDidAppear (bool animated)
		{
			NavigationController.NavigationBarHidden = true;
			base.ViewWillAppear (animated);
		}
    }
}

