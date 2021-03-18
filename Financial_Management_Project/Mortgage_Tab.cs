using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Financial_Management_Project {
    public partial class Mortgage_Tab : UserControl {
        private Dictionary<string, float?> variables;
        private const int MonthCoefficient = 12;
        private const string MortgagePayment = "mortgage_payment";
        private const string PrincipleLoan = "principle_loan";
        private const string MonthlyInterestRate = "monthly_interest_rate";
        private const string MonthlyCount = "monthly_payments";
        
        
        private Debounce_Handler _debounceHandler;
        
        public Mortgage_Tab() {
            _debounceHandler = new Debounce_Handler();
            variables = new Dictionary<string, float?>();
            variables.Add(MortgagePayment, null);
            variables.Add(PrincipleLoan, null);
            variables.Add(MonthlyInterestRate, null);
            variables.Add(MonthlyCount, null);

            _debounceHandler.Add(MortgagePayment, mortgage_TextChanged);
            _debounceHandler.Add(PrincipleLoan, principle_TextChanged);
            _debounceHandler.Add(MonthlyInterestRate, interest_TextChanged);
            _debounceHandler.Add(MonthlyCount, years_TextChanged);
            InitializeComponent();
        }

        private void mortgage_TextChanged(object sender, EventArgs e) {
            _debounceHandler.Change(MortgagePayment);
            if (!sender.Equals(_debounceHandler)) return;

            variables[MortgagePayment] = float.Parse(mortgage_box.Text);
            throw new System.NotImplementedException();
            return;


        }

        private void principle_TextChanged(object sender, EventArgs e) {
            _debounceHandler.Change(PrincipleLoan);
            if (!sender.Equals(_debounceHandler)) return;
            
            variables[PrincipleLoan] = float.Parse(principle_box.Text);
            throw new System.NotImplementedException();
        }

        private void interest_TextChanged(object sender, EventArgs e) {
            _debounceHandler.Change(MonthlyInterestRate);
            if (!sender.Equals(_debounceHandler)) return;
            
            variables[MonthlyInterestRate] = float.Parse(interest_box.Text) / MonthCoefficient;
            
            throw new System.NotImplementedException();
        }

        private void years_TextChanged(object sender, EventArgs e) {
            _debounceHandler.Change(MonthlyCount);
            if (!sender.Equals(_debounceHandler)) return;
            
            variables[MonthlyCount] = float.Parse(years_box.Text) * MonthCoefficient;
            
            throw new System.NotImplementedException();
        }
    }
}