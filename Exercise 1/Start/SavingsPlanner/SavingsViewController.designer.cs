// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace SavingsPlanner
{
    [Register ("SavingsViewController")]
    partial class SavingsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton calculateButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField finalBalanceEntry { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField interestRateEntry { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField monthlyDepositEntry { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField startingBalanceEntry { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField yearsEntry { get; set; }

        [Action ("CalculateButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CalculateButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (calculateButton != null) {
                calculateButton.Dispose ();
                calculateButton = null;
            }

            if (finalBalanceEntry != null) {
                finalBalanceEntry.Dispose ();
                finalBalanceEntry = null;
            }

            if (interestRateEntry != null) {
                interestRateEntry.Dispose ();
                interestRateEntry = null;
            }

            if (monthlyDepositEntry != null) {
                monthlyDepositEntry.Dispose ();
                monthlyDepositEntry = null;
            }

            if (startingBalanceEntry != null) {
                startingBalanceEntry.Dispose ();
                startingBalanceEntry = null;
            }

            if (yearsEntry != null) {
                yearsEntry.Dispose ();
                yearsEntry = null;
            }
        }
    }
}