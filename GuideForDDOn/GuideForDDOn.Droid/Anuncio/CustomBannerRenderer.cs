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
using Android.Gms.Ads;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using GuideForDDOn.Droid;
using GuideForDDOn.Date;

[assembly: ExportRenderer(typeof(MyBanner), typeof(CustomBannerRenderer))]

namespace GuideForDDOn.Droid
{
    public class CustomBannerRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                AdView ad = new AdView(this.Context);
                ad.AdSize = AdSize.Banner;
                //ad.AdUnitId = "ca-app-pub-7647930413486761/3301184531";

                ad.AdUnitId = "ca-app-pub-3940256099942544/6300978111";

                var requestbuilder = new AdRequest.Builder();
                ad.LoadAd(requestbuilder.Build());

                this.SetNativeControl(ad);
            }
        }
    }
}