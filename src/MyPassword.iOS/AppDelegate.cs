﻿using Foundation;
using UIKit;
using Xamarin.Essentials;

namespace MyPassword.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            Rg.Plugins.Popup.Popup.Init();
            var x = typeof(Plugin.GridViewControl.iOS.Renderers.GridViewRenderer);
            VersionTracking.Track();
            //SecureStorageImplementation.DefaultAccessible = Security.SecAccessible.Invalid;
            return base.FinishedLaunching(app, options);
        }
    }
}
