using System;
using Cirrious.MvvmCross.ViewModels;

namespace MvxSlidingPanelsSample.Core.ViewModels
{
	public class BaseViewModel : MvxViewModel
	{
		private string _displayName;
		public string DisplayName
		{
			get
			{
				return _displayName;
			}
			set
			{
				_displayName = value;
				RaisePropertyChanged(() => DisplayName);
			}
		}
    }
}

