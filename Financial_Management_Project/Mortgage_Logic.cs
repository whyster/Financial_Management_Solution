using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Financial_Management_Project {
    public class Mortgage_Logic {
        
        private Dictionary<string, double?> variables;
        private const int MonthCoefficient = 12;
        private const string MortgagePayment = "mortgage_payment";
        private const string PrincipleLoan = "principle_loan";
        private const string MonthlyInterestRate = "monthly_interest_rate";
        private const string MonthlyCount = "monthly_payments";
        
        
        private IDebounceHandler _debounceHandler;

        private void init() {
            variables.Add(MortgagePayment, null);
            variables.Add(PrincipleLoan, null);
            variables.Add(MonthlyInterestRate, null);
            variables.Add(MonthlyCount, null);

            // TODO: Expose this somehow
            /*_debounceHandler.Add(MortgagePayment, mortgage_TextChanged);
            _debounceHandler.Add(PrincipleLoan, principle_TextChanged);
            _debounceHandler.Add(MonthlyInterestRate, interest_TextChanged);
            _debounceHandler.Add(MonthlyCount, years_TextChanged);*/
        }
        public Mortgage_Logic(Dictionary<string, double?> variables, IDebounceHandler debounceHandler) {
            this.variables = variables;
            _debounceHandler = debounceHandler;
            init();
        }

        public Mortgage_Logic() {
            _debounceHandler = new Debounce_Handler();
            variables = new Dictionary<string, double?>();
            init();
        }

        public void Add(string key, EventHandler callback) {
            _debounceHandler.Add(key, callback);
        }
        
        private float? try_float_parse(string text_to_parse) {
            if (float.TryParse(text_to_parse, out float ret)) {
                return ret;
            }
            return null;
        }
        public bool Handle_Variable_Input(object sender, string key, TextBox box, float coefficient=1) {
            _debounceHandler.Change(key);
            if (!sender.Equals(_debounceHandler)) return false;

            variables[key] = try_float_parse(box.Text) * coefficient;
            if (variables[key] == null) return false;
            string unknown_key = "";
            int unknowns = 0;
            
            foreach (var variable in variables) {
                if (variable.Value != null) continue;
                unknowns++;
                unknown_key = variable.Key;
            }

            if (unknown_key != "" && unknowns == 1 ) {
                Solve_Unknown(unknown_key);
            } else if (unknowns > 1) {
                return false;
            }
            return false;
        }

        private bool Solve_Unknown(string unknownKey) {
            switch (unknownKey) {
                case PrincipleLoan:
                    try {
                        double term = Math.Pow(
                            (double) variables[MonthlyInterestRate] + 1,
                            (double) variables[MonthlyCount]);
                        double divisor = (double) variables[MonthlyInterestRate] * (term / (term - 1));
                        variables[PrincipleLoan] = variables[MortgagePayment] / divisor;
                        return true;
                    }
                    catch (InvalidOperationException e) {}
                    catch(DivideByZeroException e) {}
                    break;
                case MortgagePayment:
                    try {
                        double term = Math.Pow(
                            (double) variables[MonthlyInterestRate] + 1,
                            (double) variables[MonthlyCount]);
                        double fraction = term / (term - 1);
                        variables[MortgagePayment] =
                            variables[PrincipleLoan] * variables[MonthlyInterestRate] * fraction;
                        return true;
                    }
                    catch (InvalidOperationException e) {
                    }
                    catch (DivideByZeroException e) {
                    }
                    
                    break;
            }

            return false;
        }
    }
}