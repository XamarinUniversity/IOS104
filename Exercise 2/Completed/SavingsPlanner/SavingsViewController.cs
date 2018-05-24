using Foundation;
using System;
using UIKit;

namespace SavingsPlanner
{
    public partial class SavingsViewController : UIViewController
    {
        public SavingsViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            startingBalanceEntry.ShouldReturn += OnShouldReturn;
            interestRateEntry.ShouldReturn += OnShouldReturn;
            monthlyDepositEntry.ShouldReturn += OnShouldReturn;
            yearsEntry.ShouldReturn += OnShouldReturn;
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            startingBalanceEntry.ShouldReturn -= OnShouldReturn;
            interestRateEntry.ShouldReturn -= OnShouldReturn;
            monthlyDepositEntry.ShouldReturn -= OnShouldReturn;
            yearsEntry.ShouldReturn -= OnShouldReturn;
        }

        partial void CalculateButton_TouchUpInside(UIButton sender)
        {
            try
            {
                var startingBalance = double.Parse(startingBalanceEntry?.Text);
                var interestRate = double.Parse(interestRateEntry?.Text);
                var monthlyDeposits = double.Parse(monthlyDepositEntry?.Text);
                var years = int.Parse(yearsEntry?.Text);

                var savingsCalc = new SavingsCalculator(startingBalance, interestRate, monthlyDeposits, years);
                var finalBalance = savingsCalc.GetFutureValue();

                finalBalanceEntry.Text = string.Format("{0:n}", finalBalance);
            }
            catch
            {
                finalBalanceEntry.Text = "Calculate";
            }
        }

        private bool OnShouldReturn(UITextField textField)
        {
            textField.ResignFirstResponder();
            return true;
        }
    }
}