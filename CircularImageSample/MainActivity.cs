using System;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Codewisp.Xamarin.Android.CircularImageSample
{
    [Activity(Label = "Codewisp.Xamarin.Android.CircularImageSample", MainLauncher = true, Theme = "@android:style/Theme.Light.NoTitleBar", Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

