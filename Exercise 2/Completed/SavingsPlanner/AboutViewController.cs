using Foundation;
using System;
using UIKit;

namespace SavingsPlanner
{
    public partial class AboutViewController : UIViewController
    {
        public AboutViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            pigImageView.Image = UIImage.FromBundle("DetailedSavings");
        }

        partial void CloseButton_TouchUpInside(UIButton sender)
        {
            DismissViewController(true, null);
        }
    }
}