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

namespace AutoLayout
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton aboutButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider slideSize { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch switchNight { get; set; }

        [Action ("NightValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void NightValueChanged (UIKit.UISwitch sender);

        [Action ("SliderSizeValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SliderSizeValueChanged (UIKit.UISlider sender);

        void ReleaseDesignerOutlets ()
        {
            if (aboutButton != null) {
                aboutButton.Dispose ();
                aboutButton = null;
            }

            if (slideSize != null) {
                slideSize.Dispose ();
                slideSize = null;
            }

            if (switchNight != null) {
                switchNight.Dispose ();
                switchNight = null;
            }
        }
    }
}