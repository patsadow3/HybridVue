using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;

//http://jsfiddle.net/hfalucas/wc1gg5v4/59/
//https://jsfiddle.net/xmqgnbu3/1/

namespace CustomRenderer.Droid
{
	[Activity (Theme = "@style/MyTheme.Loading", Label = "eCuny", Icon = "@drawable/icons", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
        
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
            double width = (double)Resources.DisplayMetrics.WidthPixels / (double)Resources.DisplayMetrics.Density;
            double height = (double)Resources.DisplayMetrics.HeightPixels / (double)Resources.DisplayMetrics.Density;

            global::Xamarin.Forms.Forms.Init (this, bundle);
            
            LoadApplication(new App());
        }
	}
}

