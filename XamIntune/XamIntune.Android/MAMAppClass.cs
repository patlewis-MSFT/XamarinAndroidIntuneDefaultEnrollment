using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;

using Microsoft.Intune.Mam.Client.App;
using Microsoft.Intune.Mam.Client.Identity;
using Microsoft.Intune.Mam.Policy;


namespace XamIntune.Droid
{
    [Application]
    public class MAMAppClass : Microsoft.Intune.Mam.Client.App.MAMApplication
    {
        public MAMAppClass(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {
            return;
        }

        public override byte[] GetADALSecretKey()
        {
            return null;
        }
    }
}