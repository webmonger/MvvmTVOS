using System;

using UIKit;
using Cirrious.MvvmCross.TVOS.Views;
using MvvmTVOS.Core.ViewModels;
using Cirrious.MvvmCross.Binding.BindingContext;

namespace MvvmTVOS.AppleTV.Views
{
	public partial class MainView : MvxViewController
	{
		public MainView (IntPtr handle) : base (handle)
		{
			var myInt = 32;
		}

		public MainView ()
		{
			var myInt = 32;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			UILabel newLabel = new UILabel(new CoreGraphics.CGRect(100, 100,300, 200));

			View.Add (newLabel);

			var set = this.CreateBindingSet<MainView, MainViewModel>();
			set.Bind(newLabel).To(vm => vm.Hello);
			set.Apply();

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

