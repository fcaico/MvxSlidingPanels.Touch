using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using MvxSlidingPanelsSample.Core.ViewModels;
using SlidingPanels.Lib;
using System.Collections.Generic;
using CrossUI.Touch.Dialog.Elements;
using SlidingPanels.Lib.PanelContainers;

namespace MvxSlidingPanels.Touch.Views
{
	public partial class FirstView : MvxViewController
    {
		public new FirstViewModel ViewModel
		{
			get
			{
				return base.ViewModel as FirstViewModel;
			}
		}
			
		static bool UserInterfaceIdiomIsPhone
        {
            get
            {
                return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone;
            }
        }

		private UIBarButtonItem CreateSliderButton(string imageName, PanelType panelType)
		{
			UIButton button = new UIButton(new RectangleF(0, 0, 40f, 40f));
			button.SetBackgroundImage(UIImage.FromBundle(imageName), UIControlState.Normal);
			button.TouchUpInside += delegate
			{
				SlidingPanelsNavigationViewController navController = NavigationController as SlidingPanelsNavigationViewController;
				navController.TogglePanel(panelType);
			};

			return new UIBarButtonItem(button);
		}

        public FirstView ()
            : base (UserInterfaceIdiomIsPhone ? "FirstView_iPhone" : "FirstView_iPad", null)
        {
			NavigationItem.LeftBarButtonItem = CreateSliderButton("Images/SlideRight40.png", PanelType.LeftPanel);
			NavigationItem.RightBarButtonItem = CreateSliderButton("Images/SlideLeft40.png", PanelType.RightPanel);
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
			LeftArrowImage.Image = UIImage.FromBundle("Images/LeftArrow.png");
			UpArrowImage.Image = UIImage.FromBundle("Images/UpArrow.png");
			RightArrowImage.Image = UIImage.FromBundle("Images/RightArrow.png");


			this.AddBindings(
				new Dictionary<object, string>()
			    {
					{this, "Title DisplayName"},
					{CenterText, "Text CenterText"},
					{NavigateText, "Text DoNextLabel"},
					{NavigateButton, "TouchUpInside DoNextCommand"}
				});

			NavigationController.NavigationBar.TintColor = UIColor.Black;
        }



		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear(animated);

		}
    }
}

