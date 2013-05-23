using System;
using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;

namespace MvxSlidingPanelsSample.Core.ViewModels
{
	public class SecondViewModel : BaseViewModel
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


		public ICommand DoSomethingCommand
		{
			get
			{
				return new MvxCommand(DoSomething);
			}
		}

		void DoSomething ()
		{
			CenterText = "You Did Something!";

			System.Timers.Timer timer = new System.Timers.Timer(1000);

			timer.Elapsed += (object sender, System.Timers.ElapsedEventArgs e) => {
				CenterText = "Now Do It Again..."; 
				timer.Stop();
			};

			timer.Start();

		}

		public SecondViewModel()
		{
			DisplayName = "Second View";
			CenterText = "This is additional Functionality";
		}
	}
}

