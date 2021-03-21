using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Financial_Management_Project {
    public partial class Mortgage_Tab : UserControl {
        // private Dictionary<string, float?> variables;
        private const int MonthCoefficient = 12;
        private const string MortgagePayment = "mortgage_payment";
        private const string PrincipleLoan = "principle_loan";
        private const string MonthlyInterestRate = "monthly_interest_rate";
        private const string MonthlyCount = "monthly_payments";
        
        
        
        // private Debounce_Handler _debounceHandler;
        private Mortgage_Logic _logic;
        public Mortgage_Tab() {
            _logic = new Mortgage_Logic();

            
            _logic.Add(MortgagePayment, mortgage_TextChanged);
            _logic.Add(PrincipleLoan, principle_TextChanged);
            _logic.Add(MonthlyInterestRate, interest_TextChanged);
            _logic.Add(MonthlyCount, years_TextChanged);
            InitializeComponent();
        }
        

        private void mortgage_TextChanged(object sender, EventArgs e) {
            _logic.Handle_Variable_Input(sender, MortgagePayment, mortgage_box);
        }



        private void principle_TextChanged(object sender, EventArgs e) {
            _logic.Handle_Variable_Input(sender, PrincipleLoan, principle_box);
        }

        private void interest_TextChanged(object sender, EventArgs e) {
            _logic.Handle_Variable_Input(sender, MonthlyInterestRate, interest_box, MonthCoefficient);
        }

        private void years_TextChanged(object sender, EventArgs e) {
            _logic.Handle_Variable_Input(sender, MonthlyCount, years_box, MonthCoefficient);
        }
    }
}