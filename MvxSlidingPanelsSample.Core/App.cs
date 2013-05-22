using System;
using System.Linq;
using Cirrious.MvvmCross;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore;

namespace MvxSlidingPanelsSample.Core
{
	public class App : MvxApplication
	{
		public override void Initialize ()
		{
			CreatableTypes().EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();
			RegisterAppStart<ViewModels.FirstViewModel>();
		}  
	}
}

