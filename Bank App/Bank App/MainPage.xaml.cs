using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Banking;

namespace Bank_App
{
    public partial class MainPage : ContentPage
    {
        private BankAccount _account ;

        public MainPage()
        {
            InitializeComponent();
            Bank fnb = new Bank("First National Bank", 4324, "Kenilworth");
            Customer myNewCustomer = new Customer("7766445424", "10 me at home", "Bob", "The Builder");
            fnb.AddCustomer(myNewCustomer);

            BankAccount _account = myNewCustomer.ApplyForBankAccount();
            
        }

        private void DepositButton_Clicked(object sender, EventArgs e)

        {
            decimal AmountDeposit = 0;
            var valid = decimal.TryParse(EnterAmountDeposit.Text, out AmountDeposit);
            var reason = EnterDepositReason.Text;
            if (valid)
            _account.DepositMoney(AmountDeposit, DateTime.Now, "Stipend");
        }

        private void WithdrawButton_Clicked(object sender, EventArgs e)
        {
            decimal AmountWithdrawal = 0;
            var valid = decimal.TryParse(EnterWithdrawAmount.Text, out AmountWithdrawal);
            var reason = EnterwithdrawReason.Text;
            if (valid)
            _account.DepositMoney(AmountWithdrawal, DateTime.Now, "Stipend");

        }
    }
}

