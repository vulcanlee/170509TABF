// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XISingle
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton fooButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel fooLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField FooTextField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (fooButton != null) {
                fooButton.Dispose ();
                fooButton = null;
            }

            if (fooLabel != null) {
                fooLabel.Dispose ();
                fooLabel = null;
            }

            if (FooTextField != null) {
                FooTextField.Dispose ();
                FooTextField = null;
            }
        }
    }
}