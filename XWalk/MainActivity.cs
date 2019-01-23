using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Views;
using System.Text;
using Android.Content;
using Java.IO;
using System.IO;
using Android.Content.Res;
using Org.Xwalk.Core;

using Android.Webkit;
using Android.Graphics;

namespace XWalk
{
    [Activity(Label = "XWalk", MainLauncher = true)]
    //public class MainActivity : XWalkActivity
    public class MainActivity : Activity, XWalkInitializer.IXWalkInitListener, XWalkUpdater.IXWalkUpdateListener
    {

        private XWalkInitializer mXWalkInitializer;
        private XWalkUpdater mXWalkUpdater;

        private Org.Xwalk.Core.XWalkView xwv;


        /*protected override void OnXWalkReady()
        {
           
            xwv.LoadUrl("file:///android_asset/index.html");

        }*/

        public void OnXWalkInitCancelled()
        {
            Finish();
            //throw new NotImplementedException();
        }

        public void OnXWalkInitCompleted()
        {
            if (mXWalkUpdater != null)
            {
                mXWalkUpdater.DismissDialog();
            }
            xwv.Load("file:///android_asset/index.html", null);

            //throw new NotImplementedException();
        }

        public void OnXWalkInitFailed()
        {
            if (mXWalkUpdater == null)
            {
                mXWalkUpdater = new XWalkUpdater(this, this);
            }
            mXWalkUpdater.UpdateXWalkRuntime();

            //throw new NotImplementedException();
        }

        public void OnXWalkInitStarted()
        {
            //throw new NotImplementedException();
        }

        public void OnXWalkUpdateCancelled()
        {
            Finish();
            //throw new NotImplementedException();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            mXWalkInitializer = new XWalkInitializer(this, this);
            mXWalkInitializer.InitAsync();

            SetContentView(Resource.Layout.Main);

            xwv.SetWebChromeClient(new WebChromeClient());
           // xwv.SetWebViewClient(new SampleWebViewClient(xwv));
            xwv.SetResourceClient(new SampleXWalkWebViewClient(xwv));

           

            xwv = (Org.Xwalk.Core.XWalkView)FindViewById(Resource.Id.xwalkview);








        }

        protected override void OnResume()
        {
            base.OnResume();
            mXWalkInitializer.InitAsync();
        }


    }


   /* public class SampleWebViewClient : WebViewClient
    {
        WebView webView;
        public SampleWebViewClient(WebView view)
        {
            this.webView = view;
        }
        public override bool ShouldOverrideUrlLoading(WebView view, string url)
        {

            String temp = url.ToString();

            if (temp.Contains("android_asset"))
            {

            }
            if (url.Contains("android_asset"))
            {

                return false;
            }
            else
            {
                view.Context.StartActivity(
                        new Intent(Intent.ActionView, Android.Net.Uri.Parse(url)));
                return true;
            }
        }

        public override void OnPageStarted(WebView view, String url, Bitmap favicon)
        {
            base.OnPageStarted(view, url, favicon);


        }

    }*/


    public class SampleXWalkWebViewClient : Org.Xwalk.Core.XWalkResourceClient
    {
        public Org.Xwalk.Core.XWalkView xWalkView;
        public SampleXWalkWebViewClient(XWalkView view) : base(view)
        {
            this.xWalkView = view;
          
        }

        public override bool ShouldOverrideUrlLoading(Org.Xwalk.Core.XWalkView view, string url)
        {

            String temp = url.ToString();

            if (temp.Contains("android_asset"))
            {

            }
            if (url.Contains("android_asset"))
            {

                return false;
            }
            else
            {
                view.Context.StartActivity(
                        new Intent(Intent.ActionView, Android.Net.Uri.Parse(url)));
                return true;
            }
        }

        public override void OnLoadFinished(XWalkView view, String url)
        {
            base.OnLoadFinished(view, url);
         

        }
    }
}

