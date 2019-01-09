using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.Intune.Mam;
using Microsoft.Intune;
using Microsoft.Intune.Mam.Policy.AppConfig;
using Xamarin.Forms;
using Xamarin.Android;

using Microsoft.Intune.Mam.Client.App;
using Microsoft.Intune.Mam.Client.Identity;
using Microsoft.Intune.Mam.Policy;

namespace XamIntune.Droid
{
    [Activity(Label = "XamIntune", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        //protected override void OnCreate(Bundle savedInstanceState)
        protected override void OnMAMCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            //base.OnCreate(savedInstanceState);
            base.OnMAMCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            //TODO: Add later....var mgr = DependencyService.Get<IMAMEnrollmentManager>();
            //mgr.RegisterAccountForMAM("patlewis@patlewisintune.com");         
        }
    }
}