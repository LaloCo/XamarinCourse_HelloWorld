using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace HelloWorld_Android
{
    [Activity(Label = "HelloWorld_Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.sayHelloButton);

            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            EditText nameEditText = FindViewById<EditText>(Resource.Id.nameEditText);

            string name = nameEditText.Text;

            TextView helloLabel = FindViewById<TextView>(Resource.Id.textView1);

            helloLabel.Text = $"Hello {name}!";
        }
    }
}

