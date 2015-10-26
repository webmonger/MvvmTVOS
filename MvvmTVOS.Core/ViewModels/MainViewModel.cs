using Cirrious.MvvmCross.ViewModels;

namespace MvvmTVOS.Core.ViewModels
{
    public class MainViewModel 
		: MvxViewModel
    {
		private string _hello = "Hello MvvmCross TVOS";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}
    }
}
