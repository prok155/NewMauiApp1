using Android.Content.PM;
using Android.Content;
using Android.Graphics;
using Android.Media;
using Android.OS;
using Android.Views;
using NewMauiApp1.Interfaces;
using Microsoft.Maui.Controls.PlatformConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewMauiApp1.Platforms
{
    public class MyClass : IMyClass
    {
        public void StartAnotherApp()
        {
            PackageManager pm = Android.App.Application.Context.PackageManager;

            Intent intent = pm.GetLaunchIntentForPackage("com.companyname.newmauiapp2");
            if (intent != null)
            {
                intent.SetFlags(ActivityFlags.NewTask);
                Android.App.Application.Context.StartActivity(intent);
            }
        }
    }
}
