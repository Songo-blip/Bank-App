using Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bank_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TransationsPage : ContentPage
    {
        public BankAccount _account;

        public BankAccount Account
        {
            get { return Account; }
            set { Account = value;}
        }

        public TransationsPage(BankAccount _account)
        {
            InitializeComponent();

            Title = "View Transactions";
            Account = _account;
            BindingContext =Account; 
        }
    }
}