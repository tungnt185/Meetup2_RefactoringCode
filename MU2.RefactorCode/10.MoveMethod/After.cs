﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.MoveMethod
{
    /// <summary>
    /// Sử dụng kỹ thuật này khi một class khác sử dụng một phương thức nhiều hơn class chứa phương thức đó
    /// VD ở đây là hàm CalculateInterestRate()
    /// </summary>
    public class BankAccount
    {
        public BankAccount(int accountAge, int creditScore,
            AccountInterest accountInterest)
        {
            AccountAge = accountAge;
            CreditScore = creditScore;
            AccountInterest = accountInterest;
        }

        public int AccountAge { get; private set; }
        public int CreditScore { get; private set; }
        public AccountInterest AccountInterest { get; private set; }
    }

    public class AccountInterest
    {
        public BankAccount Account { get; private set; }

        public AccountInterest(BankAccount account)
        {
            Account = account;
        }

        public double InterestRate
        {
            get { return CalculateInterestRate(); }
        }

        public bool IntroductoryRate
        {
            get { return CalculateInterestRate() < 0.05; }
        }

        public double CalculateInterestRate()
        {
            if (Account.CreditScore > 800)
                return 0.02;

            if (Account.AccountAge > 10)
                return 0.03;

            return 0.05;
        }
    }
}
