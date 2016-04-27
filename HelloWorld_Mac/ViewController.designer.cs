// WARNING
//
// This file has been generated automatically by Xamarin Studio Business to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace HelloWorld_Mac
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextFieldCell helloLabel { get; set; }

		[Outlet]
		AppKit.NSTextFieldCell nameTextField { get; set; }

		[Action ("sayHelloButton_Pressed:")]
		partial void sayHelloButton_Pressed (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (nameTextField != null) {
				nameTextField.Dispose ();
				nameTextField = null;
			}

			if (helloLabel != null) {
				helloLabel.Dispose ();
				helloLabel = null;
			}
		}
	}
}
