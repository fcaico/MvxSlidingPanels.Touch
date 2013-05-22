using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using SlidingPanels.Lib;
using MvxSlidingPanelsSample.Core.ViewModels;
using Cirrious.MvvmCross.Binding.BindingContext;
using System.Collections.Generic;

namespace MvxSlidingPanels.Touch.Views
{
	public partial class SecondView : MvxViewController
    {
		public new SecondViewModel ViewModel
		{
			get
			{
				return base.ViewModel as SecondViewModel;
			}
		}


        static bool UserInterfaceIdiomIsPhone
        {
            get
            {
                return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone;
            }
        }

        public SecondView ()
            : base (UserInterfaceIdiomIsPhone ? "SecondView_iPhone" : "SecondView_iPad", null)
        {
        }

        public override void DidReceiveMemoryWarning ()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
            
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad();
            
            // Perform any additional setup after loading the view, typically from a nib.
			this.AddBindings(
				new Dictionary<object, string>()
				{
					{this, "Title DisplayName"},
					{CenterText, "Text CenterText"},
					{DoSomething, "TouchUpInside DoSomethingCommand"}
			});

        }


    }
}

