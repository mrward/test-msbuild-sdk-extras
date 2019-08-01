using System;
using MSBuildSdkExtrasTest.Android;

namespace MSBuildSdkExtrasTest
{
	public class Class1
	{
#if TESTANDROID
		// TESTANDROID is defined in the Directory.Build.targets and should
		// be defined here.
		int test;
#endif

		public void Test ()
		{
			// The AndroidTest class should be available but it is not.
			var test = new AndroidTest ();

		}
	}
}
