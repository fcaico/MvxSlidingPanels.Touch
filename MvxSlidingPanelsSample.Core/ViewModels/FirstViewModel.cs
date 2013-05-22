using System;
using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;

namespace MvxSlidingPanelsSample.Core.ViewModels
{
    public class FirstViewModel : BaseViewModel
    {
		private string _centerText;
		public string CenterText
		{
			get
			{
				return _centerText;
			}
			set
			{
				_centerText = value;
				RaisePropertyChanged(() => CenterText);
			}
		}

		private string _doNextLabel;
		public string DoNextLabel
		{
			get
			{
				return _doNextLabel;
			}
			set
			{
				_doNextLabel = value;
				RaisePropertyChanged(() => DoNextLabel);
			}
		}

		public ICommand DoNextCommand
		{
			get
			{
				return new MvxCommand(NavigateToNext);
			}
		}

		void NavigateToNext ()
		{
			ShowViewModel(typeof(SecondViewModel));
		}

		public FirstViewModel()
		{
			DisplayName = "First View";
			CenterText = "Slide Left, Right or Up to reveal the panel underneath.";
			DoNextLabel = "Click to navigate to second view.";
		}
    }
}

