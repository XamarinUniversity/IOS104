using System;

namespace SavingsPlanner
{
    public class SavingsCalculator
    {
        public double StartingBalance { get; set; }
        public double InterestRate { get; set; }
        public double MonthlyDeposit { get; set; }
        public int Years { get; set; }

        public SavingsCalculator()
        {

        }

        public SavingsCalculator(double startingBalance, double interestRate, double monthlyDeposit, int years)
        {
            StartingBalance = startingBalance;
            InterestRate = interestRate;
            MonthlyDeposit = monthlyDeposit;
            Years = years;
        }

        public double GetFutureValue()
        {
            if (InterestRate == 0)
                return StartingBalance + MonthlyDeposit * Years * 12;

            var monthlyInterestRate = InterestRate / 1200;
            var compoundFactor = Math.Pow(1 + monthlyInterestRate, Years * 12);

            var compoundInterest = StartingBalance * compoundFactor;
            var futureValueOfSeries = MonthlyDeposit * (compoundFactor - 1) / monthlyInterestRate;

            return compoundInterest + futureValueOfSeries;
        }
    }
}