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

            xwv = (Org.Xwalk.Core.XWalkView)FindViewById(Resource.Id.xwalkview);






        }

        protected override void OnResume()
        {
            base.OnResume();
            mXWalkInitializer.InitAsync();
        }


    }
}

