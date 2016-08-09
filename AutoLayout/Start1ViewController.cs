using Foundation;
using System;
using UIKit;

namespace AutoLayout
{
    public partial class Start1ViewController : UIViewController
    {
        public Start1ViewController (IntPtr handle) : base (handle)
        {
        }

        partial void UIButton1385_TouchUpInside(UIButton sender)
        {
            DismissViewController(true, null);
        }
    }
}