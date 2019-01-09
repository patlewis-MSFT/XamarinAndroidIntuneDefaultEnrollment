using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using XamIntune;
using Microsoft.Intune.Mam.Client.Identity;
using Microsoft.Intune.Mam.Client;
using XamIntune.Droid;

namespace XamIntune.Droid
{
    class CreateWelcomeLabel : ICreateWelcomeLabel
    {
        public string GetFirstName()
        {        
            return "Unknown";
        }
    }
}