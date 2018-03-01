﻿using Android.Webkit;
using CustomRenderer;
using CustomRenderer.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer (typeof(HybridWebView), typeof(HybridWebViewRenderer))]
namespace CustomRenderer.Droid
{
	public class HybridWebViewRenderer : ViewRenderer<HybridWebView, Android.Webkit.WebView>
	{
		const string JavaScriptFunction = "function invokeCSharpAction(json){jsBridge.invokeAction(json);}";

		protected override void OnElementChanged (ElementChangedEventArgs<HybridWebView> e)
		{
			base.OnElementChanged (e);

			if (Control == null) {
				var webView = new Android.Webkit.WebView (Forms.Context);
				webView.Settings.JavaScriptEnabled = true;
                webView.Settings.DomStorageEnabled = true;
                //webView.SetBackgroundResource(Resource.Drawable.splashscreen);
                SetNativeControl (webView);
			}
			if (e.OldElement != null) {
				Control.RemoveJavascriptInterface ("jsBridge");
				var hybridWebView = e.OldElement as HybridWebView;
				hybridWebView.Cleanup ();
			}
			if (e.NewElement != null) {
				Control.AddJavascriptInterface (new JSBridge (this), "jsBridge");
				Control.LoadUrl (string.Format ("file:///android_asset/Content/{0}", Element.Uri));
				InjectJS (JavaScriptFunction);
			}
		}
        void InjectJS (string script)
		{
			if (Control != null) {
				Control.LoadUrl (string.Format ("javascript: {0}", script));
			}
		}
        public void InvokeScriptAsync(string result)
        {
            InjectJS(@"store.commit('increment', 10)");
        }
    }
}
