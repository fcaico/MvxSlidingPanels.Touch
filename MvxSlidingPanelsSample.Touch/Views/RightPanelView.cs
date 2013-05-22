using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using SlidingPanels.Lib;
using Cirrious.MvvmCross.Binding.BindingContext;
using System.Collections.Generic;

namespace MvxSlidingPanels.Touch.Views
{
	public partial class RightPanelView : MvxViewController
    {
        static bool UserInterfaceIdiomIsPhone
        {
            get
            {
                return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone;
            }
        }

        public RightPanelView ()
            : base (UserInterfaceIdiomIsPhone ? "RightPanelView_iPhone" : "RightPanelView_iPad", null)
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
			View.Frame = new RectangleF(View.Frame.X, View.Frame.Y, 250F, View.Frame.Height);

            // Perform any additional setup after loading the view, typically from a nib.
			this.AddBindings(
				new Dictionary<object, string>()
				{
					{DisplayText, "Text DisplayName"}
				});
        }
    }
}

