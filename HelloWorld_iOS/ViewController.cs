using System;

using UIKit;

namespace HelloWorld_iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            sayHelloButton.TouchUpInside += SayHelloButton_TouchUpInside;
        }

        private void SayHelloButton_TouchUpInside(object sender, EventArgs e)
        {
            string name = nameTextField.Text;

            helloLabel.Text = $"Hello {name}!";
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}