using System;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using MonoTouch.UIKit;
using SlidingPanels.Lib;
using SlidingPanels.Lib.PanelContainers;
using Cirrious.MvvmCross.Touch.Views;
using MvxSlidingPanelsSample.Core.ViewModels;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore.Exceptions;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Views;
using System.Drawing;

namespace MvxSlidingPanels.Touch
{
	public class MvxSlidingPanelsTouchViewPresenter : MvxTouchViewPresenter
	{

		private UIWindow _window;

		public SlidingPanelsNavigationViewController NavController {
			get
			{
				return MasterNavigationController as SlidingPanelsNavigationViewController;
			}
		}

		public UIViewController RootController {
			get;
			private set;
		}

		public MvxSlidingPanelsTouchViewPresenter(UIApplicationDelegate applicationDelegate, UIWindow window) :
			base(applicationDelegate, window)
		{
			// specialized construction logic goes here
			_window = window;
		}

		public override void ChangePresentation (Cirrious.MvvmCross.ViewModels.MvxPresentationHint hint)
		{
			base.ChangePresentation(hint);
		}

		protected override void ShowFirstView (UIViewController viewController)
		{

			base.ShowFirstView (viewController);

			RootController.AddChildViewController (NavController);
			RootController.View.AddSubview (NavController.View);

			AddPanel<LeftPanelViewModel>(PanelType.LeftPanel, viewController as MvxViewController);
			AddPanel<RightPanelViewModel>(PanelType.RightPanel, viewController as MvxViewController);
			AddPanel<BottomPanelViewModel>(PanelType.BottomPanel, viewController as MvxViewController);
		}

		protected void AddPanel<T>(PanelType panelType, MvxViewController mvxController) where T : MvxViewModel
		{
			UIViewController viewToAdd = (UIViewController) mvxController.CreateViewControllerFor<T>();

			switch (panelType)
			{
				case PanelType.LeftPanel:
					NavController.InsertPanel(new LeftPanelContainer(viewToAdd));
				break;

				case PanelType.RightPanel:
					NavController.InsertPanel(new RightPanelContainer(viewToAdd));
				break;

				case PanelType.BottomPanel:
					NavController.InsertPanel(new BottomPanelContainer(viewToAdd));
				break;

				default:
				throw new Exception("blah!");
			};
		}

		protected override UINavigationController CreateNavigationController (UIViewController viewController)
		{
			SlidingPanelsNavigationViewController navController = new SlidingPanelsNavigationViewController (viewController);
			RootController = new UIViewController ();
			return navController;
		}

		protected override void SetWindowRootViewController(UIViewController controller)
		{
			_window.AddSubview(RootController.View);
			_window.RootViewController = RootController;
		}

	}
}

