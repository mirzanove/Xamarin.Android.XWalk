package md54f4ee096046471137eb818b1a68956c6;


public class MainActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		org.xwalk.core.XWalkInitializer.XWalkInitListener,
		org.xwalk.core.XWalkUpdater.XWalkUpdateListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onResume:()V:GetOnResumeHandler\n" +
			"n_onXWalkInitCancelled:()V:GetOnXWalkInitCancelledHandler:Org.Xwalk.Core.XWalkInitializer/IXWalkInitListenerInvoker, XWalk.Binding\n" +
			"n_onXWalkInitCompleted:()V:GetOnXWalkInitCompletedHandler:Org.Xwalk.Core.XWalkInitializer/IXWalkInitListenerInvoker, XWalk.Binding\n" +
			"n_onXWalkInitFailed:()V:GetOnXWalkInitFailedHandler:Org.Xwalk.Core.XWalkInitializer/IXWalkInitListenerInvoker, XWalk.Binding\n" +
			"n_onXWalkInitStarted:()V:GetOnXWalkInitStartedHandler:Org.Xwalk.Core.XWalkInitializer/IXWalkInitListenerInvoker, XWalk.Binding\n" +
			"n_onXWalkUpdateCancelled:()V:GetOnXWalkUpdateCancelledHandler:Org.Xwalk.Core.XWalkUpdater/IXWalkUpdateListenerInvoker, XWalk.Binding\n" +
			"";
		mono.android.Runtime.register ("XWalk.MainActivity, XWalk", MainActivity.class, __md_methods);
	}


	public MainActivity ()
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("XWalk.MainActivity, XWalk", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onResume ()
	{
		n_onResume ();
	}

	private native void n_onResume ();


	public void onXWalkInitCancelled ()
	{
		n_onXWalkInitCancelled ();
	}

	private native void n_onXWalkInitCancelled ();


	public void onXWalkInitCompleted ()
	{
		n_onXWalkInitCompleted ();
	}

	private native void n_onXWalkInitCompleted ();


	public void onXWalkInitFailed ()
	{
		n_onXWalkInitFailed ();
	}

	private native void n_onXWalkInitFailed ();


	public void onXWalkInitStarted ()
	{
		n_onXWalkInitStarted ();
	}

	private native void n_onXWalkInitStarted ();


	public void onXWalkUpdateCancelled ()
	{
		n_onXWalkUpdateCancelled ();
	}

	private native void n_onXWalkUpdateCancelled ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
