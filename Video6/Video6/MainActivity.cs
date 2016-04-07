using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Square.Picasso;

namespace Video6
{
	[Activity (Label = "Video6", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			Picasso.With(this)
				.Load("https://www.xamarin.com/content/images/pages/index/platform-screenshot@2x.png")
				.Into(FindViewById<ImageView>(Resource.Id.imageView));
		}
	}
}


