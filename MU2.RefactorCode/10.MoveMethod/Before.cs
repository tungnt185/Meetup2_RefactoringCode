using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.MoveMethod
{
    public class BankAccountBefore
    {
        public BankAccountBefore(int accountAge, int creditScore,
         AccountInterestBefore accountInterest)
        {
            AccountAge = accountAge;
            CreditScore = creditScore;
            AccountInterest = accountInterest;
        }

        public int AccountAge { get; private set; }
        public int CreditScore { get; private set; }
        public AccountInterestBefore AccountInterest { get; private set; }

        public double CalculateInterestRate()
        {
            if (CreditScore > 800)
                return 0.02;

            if (AccountAge > 10)
                return 0.03;

            return 0.05;
        }
    }

    public class AccountInterestBefore
    {
        public BankAccountBefore Account { get; private set; }

        public AccountInterestBefore(BankAccountBefore account)
        {
            Account = account;
        }

        public double InterestRate
        {
            get { return Account.CalculateInterestRate(); }
        }

        public bool IntroductoryRate
        {
            get { return Account.CalculateInterestRate() < 0.05; }
        }
    }
}
