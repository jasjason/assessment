namespace assessment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPdtCode1 = new System.Windows.Forms.TextBox();
            this.txtPdtCost1 = new System.Windows.Forms.TextBox();
            this.txtPdtCode2 = new System.Windows.Forms.TextBox();
            this.txtPdtCost2 = new System.Windows.Forms.TextBox();
            this.txtDiscountAmt = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Store";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Product Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Less Discount:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtPdtCode1
            // 
            this.txtPdtCode1.Location = new System.Drawing.Point(119, 28);
            this.txtPdtCode1.Name = "txtPdtCode1";
            this.txtPdtCode1.Size = new System.Drawing.Size(100, 20);
            this.txtPdtCode1.TabIndex = 7;
            // 
            // txtPdtCost1
            // 
            this.txtPdtCost1.Location = new System.Drawing.Point(119, 51);
            this.txtPdtCost1.Name = "txtPdtCost1";
            this.txtPdtCost1.Size = new System.Drawing.Size(100, 20);
            this.txtPdtCost1.TabIndex = 8;
            // 
            // txtPdtCode2
            // 
            this.txtPdtCode2.Location = new System.Drawing.Point(119, 77);
            this.txtPdtCode2.Name = "txtPdtCode2";
            this.txtPdtCode2.Size = new System.Drawing.Size(100, 20);
            this.txtPdtCode2.TabIndex = 9;
            // 
            // txtPdtCost2
            // 
            this.txtPdtCost2.Location = new System.Drawing.Point(119, 103);
            this.txtPdtCost2.Name = "txtPdtCost2";
            this.txtPdtCost2.Size = new System.Drawing.Size(100, 20);
            this.txtPdtCost2.TabIndex = 10;
            // 
            // txtDiscountAmt
            // 
            this.txtDiscountAmt.Location = new System.Drawing.Point(119, 159);
            this.txtDiscountAmt.Name = "txtDiscountAmt";
            this.txtDiscountAmt.Size = new System.Drawing.Size(100, 20);
            this.txtDiscountAmt.TabIndex = 11;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(119, 184);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmt);
            this.Controls.Add(this.txtPdtCost2);
            this.Controls.Add(this.txtPdtCode2);
            this.Controls.Add(this.txtPdtCost1);
            this.Controls.Add(this.txtPdtCode1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPdtCode1;
        private System.Windows.Forms.TextBox txtPdtCost1;
        private System.Windows.Forms.TextBox txtPdtCode2;
        private System.Windows.Forms.TextBox txtPdtCost2;
        private System.Windows.Forms.TextBox txtDiscountAmt;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button button1;
    }
}

