﻿using System;
using Android.App;
using Android.Os;
using Android.Test;
using Android.Widget;
using Dot42;
using Dot42.Manifest;

namespace UsingGoogleMobAds.Sources
{
    public class Test : ActivityInstrumentationTestCase2<MainActivity>
    {
		public Test() : base(typeof(MainActivity)) 
		{
		}
		
		public void test1() 
		{
			var activity = Activity;
			AssertNotNull(activity);
		}
    }
}
