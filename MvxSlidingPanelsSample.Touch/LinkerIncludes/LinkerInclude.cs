using System;
using MvxSlidingPanels.Touch.Views;
using MonoTouch.UIKit;

namespace MvxSlidingPanels.Touch.Linker
{
	/// <summary>
	/// This class is provided simply to force-include symbolbs that the linker wants
	/// to optimize away.
	/// </summary>
    public class LinkerInclude
    {
		const string linkme = "Link me";

        public LinkerInclude ()
        {
			UIViewController f = new UIViewController();
			f.Title = linkme;

			UITextView t = new UITextView();
			t.Text = linkme;
        }
    }
}

