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
        private BankAccount _account;

        private BankingDataBase_database;

        public MainPage(BankAccount account)
        {
            _account = account;
        }

        public MainPage()
        {
            InitializeComponent();

            _bankingDatabase = new BankingDatabase();


        }

        protected override void OnAppearing()

        {
            base.OnAppearing();

            _Customer = BankingDatabase.getCustomerByIdNumber("7766445424");

            _Account = bankingDatabase.GetCustomer(_Customer);
               
        }

        private void DepositButton_Clicked(object sender, EventArgs e)

        {
            decimal AmountDeposit = 0;
            var valid = decimal.TryParse(EnterAmountDeposit.Text, out AmountDeposit);
            var Enterreason = EnterDepositReason.Text;
           // if (valid)
                _account.DepositMoney(AmountDeposit, DateTime.Now, Enterreason);
        }
      
        private void WithdrawButton_Clicked(object sender, EventArgs e)
        {
            decimal AmountWithdrawal = 0;
            var valid = decimal.TryParse(EnterWithdrawAmount.Text, out AmountWithdrawal);
            var Enterreason = EnterwithdrawReason.Text;
            //if (valid)
            _account.DepositMoney(AmountWithdrawal, DateTime.Now, Enterreason);

        }

        private void DisplayTransationsButton_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new TransationsPage(_account));

            //DisplayTransactionsLabel.Text = _account.GetTransactionsHistory(); 
        }
    }
}

