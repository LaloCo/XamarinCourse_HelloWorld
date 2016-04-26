// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace HelloWorld_iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel helloLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField nameTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton sayHelloButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (helloLabel != null) {
				helloLabel.Dispose ();
				helloLabel = null;
			}
			if (nameTextField != null) {
				nameTextField.Dispose ();
				nameTextField = null;
			}
			if (sayHelloButton != null) {
				sayHelloButton.Dispose ();
				sayHelloButton = null;
			}
		}
	}
}
