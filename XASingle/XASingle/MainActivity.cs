using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XASingle
{
    [Activity(Label = "XASingle", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        EditText fooEditText;
        Button fooButton;
        TextView fooTextView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            fooEditText = FindViewById<EditText>(Resource.Id.fooEditText);
            fooButton = FindViewById<Button>(Resource.Id.fooButton);
            fooTextView = FindViewById<TextView>(Resource.Id.fooTextView);

            //fooButton.Click += (s, e) =>
            //{
            //    fooTextView.Text =
            //    "Hello " + fooEditText.Text;
            //};

            fooButton.Click += fooButtonClick;

        }

        private void fooButtonClick(object sender, EventArgs e)
        {
            fooTextView.Text =
            "Hello " + fooEditText.Text;
        }
    }
}

