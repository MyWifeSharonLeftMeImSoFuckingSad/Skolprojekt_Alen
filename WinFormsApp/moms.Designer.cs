namespace WinFormsApp
{
    partial class moms
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
            this.txtPriceOG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoms = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPriceAfter = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPriceOG
            // 
            this.txtPriceOG.Location = new System.Drawing.Point(144, 59);
            this.txtPriceOG.Name = "txtPriceOG";
            this.txtPriceOG.Size = new System.Drawing.Size(100, 23);
            this.txtPriceOG.TabIndex = 0;
            this.txtPriceOG.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skriv in pris";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Skriv in moms";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMoms
            // 
            this.txtMoms.Location = new System.Drawing.Point(144, 135);
            this.txtMoms.Name = "txtMoms";
            this.txtMoms.Size = new System.Drawing.Size(100, 23);
            this.txtMoms.TabIndex = 2;
            this.txtMoms.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pris efter moms";
            // 
            // txtPriceAfter
            // 
            this.txtPriceAfter.Location = new System.Drawing.Point(295, 59);
            this.txtPriceAfter.Name = "txtPriceAfter";
            this.txtPriceAfter.Size = new System.Drawing.Size(100, 23);
            this.txtPriceAfter.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(157, 187);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "BERÄKNA";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // moms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPriceAfter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMoms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPriceOG);
            this.Name = "moms";
            this.Text = "moms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPriceOG;
        private Label label1;
        private Label label2;
        private TextBox txtMoms;
        private Label label3;
        private TextBox txtPriceAfter;
        private Button btnCalculate;
    }
}