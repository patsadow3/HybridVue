using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomRenderer
{
	public partial class HybridWebViewPage : ContentPage
	{
        private HybridWebViewModel hybridWebViewModel;

        public HybridWebViewPage ()
		{
			InitializeComponent ();
            hybridWebViewModel = new HybridWebViewModel();
            BindingContext = hybridWebViewModel;
            hybridWebView.RegisterAction(data => { });// DisplayAlert ("Alert", "Hello " + data, "OK"));
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            WaitingForHTMLToLoad();
        }

        //Workaround :(
        public async void WaitingForHTMLToLoad()
        {
            await Task.Delay(1500);
            hybridWebViewModel.IsVisibleWeb = false;
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PopModalAsync(false);
            return true;
        }
    }
}
