# Xamarin.Android Crosswalk Binding

An example Project to embed a [Crosswalk](https://crosswalk-project.org/) View into your Android App.

## Getting Started

The XWalk.Binding contains the Bindings to the Android Library and the Library (AAR) itself. If you want to use it, you can just copy it into your Project.

### Usage

An Example how to use the `Org.Xwalk.Core.XWalkView`:
```Java
public class MainActivity : Activity, XWalkInitializer.IXWalkInitListener, XWalkUpdater.IXWalkUpdateListener
    {

        private XWalkInitializer mXWalkInitializer;
        private XWalkUpdater mXWalkUpdater;

        private Org.Xwalk.Core.XWalkView xwv;

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

	
	or :
	
	public class MainActivity : XWalkActivity{
	
    private Org.Xwalk.Core.XWalkView xwv;
	
	protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            mXWalkInitializer = new XWalkInitializer(this, this);
            mXWalkInitializer.InitAsync();

            SetContentView(Resource.Layout.Main);

            xwv = (Org.Xwalk.Core.XWalkView)FindViewById(Resource.Id.xwalkview);

        }
		
		protected override void OnXWalkReady()
        {
           
            xwv.LoadUrl("file:///android_asset/index.html");

        }
	
	}
```	
	

## Permissions

According to the [Crosswalk Documentation](https://crosswalk-project.org/documentation/android/embedding_crosswalk.html), the minimal Permissions required to run are:

```xml
<uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
<uses-permission android:name="android.permission.INTERNET" />
<uses-permission android:name="android.permission.ACCESS_WIFI_STATE" />
```

If you want to access Hardware components, you have to add the permission accordingly to your `AndroidManifest.xml` file.

## Authors

* **Kevin Gliewe** - [KevinGliewe](https://github.com/KevinGliewe)

## Inspiration

I took a lot of inspiration from the [Xamarin.CrossWalk](https://github.com/Youscribe/Xamarin.CrossWalk) Project from [kYann](https://github.com/kYann).
Thank you for your Work.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details