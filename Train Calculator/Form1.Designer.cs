namespace Train_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addition = new System.Windows.Forms.Button();
            this.numberOne = new System.Windows.Forms.TextBox();
            this.equals = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(12, 41);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(40, 40);
            this.addition.TabIndex = 0;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // numberOne
            // 
            this.numberOne.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.numberOne.Location = new System.Drawing.Point(12, 12);
            this.numberOne.Name = "numberOne";
            this.numberOne.Size = new System.Drawing.Size(132, 23);
            this.numberOne.TabIndex = 1;
            this.numberOne.TextChanged += new System.EventHandler(this.numberOne_TextChanged);
            this.numberOne.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberOne_KeyDown);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(104, 41);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(40, 86);
            this.equals.TabIndex = 2;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(12, 133);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(40, 40);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clr";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(58, 41);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(40, 40);
            this.subtraction.TabIndex = 4;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(12, 87);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(40, 40);
            this.division.TabIndex = 5;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(58, 87);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(40, 40);
            this.multiplication.TabIndex = 6;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Results";
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(156, 41);
            this.results.Multiline = true;
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.Size = new System.Drawing.Size(100, 255);
            this.results.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 304);
            this.Controls.Add(this.results);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.division);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.numberOne);
            this.Controls.Add(this.addition);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.TextBox numberOne;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox results;
    }
}

