using Xamarin.Forms.Platform.Android;
using Android.Gms.Ads;
using Xamarin.Forms;
using GuideForDDOn.Droid;
using GuideForDDOn.Date;

[assembly: ExportRenderer(typeof(MyBannerMonstro), typeof(BannerMonstros))]

namespace GuideForDDOn.Droid
{
    public class BannerMonstros : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                AdView ad = new AdView(this.Context);
                ad.AdSize = AdSize.Banner;
                //ad.AdUnitId = "ca-app-pub-7647930413486761/4446872827";
                ad.AdUnitId = "ca-app-pub-3940256099942544/6300978111";


                var requestbuilder = new AdRequest.Builder();
                ad.LoadAd(requestbuilder.Build());

                this.SetNativeControl(ad);
            }
        }
    }
}