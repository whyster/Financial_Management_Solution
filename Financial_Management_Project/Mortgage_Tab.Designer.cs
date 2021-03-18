using System.ComponentModel;

namespace Financial_Management_Project {
    partial class Mortgage_Tab {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.mortgage_box = new System.Windows.Forms.TextBox();
            this.principle_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.interest_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.years_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly mortgage:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mortgage_box
            // 
            this.mortgage_box.Location = new System.Drawing.Point(156, 23);
            this.mortgage_box.Name = "mortgage_box";
            this.mortgage_box.Size = new System.Drawing.Size(205, 20);
            this.mortgage_box.TabIndex = 1;
            this.mortgage_box.TextChanged += new System.EventHandler(this.mortgage_TextChanged);
            // 
            // principle_box
            // 
            this.principle_box.Location = new System.Drawing.Point(156, 49);
            this.principle_box.Name = "principle_box";
            this.principle_box.Size = new System.Drawing.Size(205, 20);
            this.principle_box.TabIndex = 2;
            this.principle_box.TextChanged += new System.EventHandler(this.principle_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(50, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Downpayment:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // interest_box
            // 
            this.interest_box.Location = new System.Drawing.Point(156, 75);
            this.interest_box.Name = "interest_box";
            this.interest_box.Size = new System.Drawing.Size(205, 20);
            this.interest_box.TabIndex = 3;
            this.interest_box.TextChanged += new System.EventHandler(this.interest_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(31, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Annual interest rate:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // years_box
            // 
            this.years_box.Location = new System.Drawing.Point(156, 101);
            this.years_box.Name = "years_box";
            this.years_box.Size = new System.Drawing.Size(205, 20);
            this.years_box.TabIndex = 4;
            this.years_box.TextChanged += new System.EventHandler(this.years_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(44, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Years to pay off:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Mortgage_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.years_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.interest_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.principle_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mortgage_box);
            this.Controls.Add(this.label1);
            this.Name = "Mortgage_Tab";
            this.Size = new System.Drawing.Size(481, 286);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox principle_box;
        private System.Windows.Forms.TextBox interest_box;
        private System.Windows.Forms.TextBox years_box;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mortgage_box;

        #endregion
    }
}