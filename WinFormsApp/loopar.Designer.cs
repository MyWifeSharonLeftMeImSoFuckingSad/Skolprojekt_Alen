namespace WinFormsApp
{
    partial class loopar
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
            this.btnSlumpa = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum_2 = new System.Windows.Forms.TextBox();
            this.textSlumpa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSlumpa
            // 
            this.btnSlumpa.Location = new System.Drawing.Point(290, 234);
            this.btnSlumpa.Name = "btnSlumpa";
            this.btnSlumpa.Size = new System.Drawing.Size(288, 23);
            this.btnSlumpa.TabIndex = 0;
            this.btnSlumpa.Text = "Slumpa";
            this.btnSlumpa.UseVisualStyleBackColor = true;
            this.btnSlumpa.Click += new System.EventHandler(this.btnSlumpa_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(289, 176);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(96, 15);
            this.lb.TabIndex = 4;
            this.lb.Text = "Slump mellan tal";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(468, 176);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(84, 15);
            this.lblb.TabIndex = 5;
            this.lblb.Text = "Antal slumptal";
            this.lblb.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(288, 272);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(292, 203);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(79, 23);
            this.textNum1.TabIndex = 7;
            // 
            // textNum_2
            // 
            this.textNum_2.Location = new System.Drawing.Point(377, 203);
            this.textNum_2.Name = "textNum_2";
            this.textNum_2.Size = new System.Drawing.Size(79, 23);
            this.textNum_2.TabIndex = 8;
            // 
            // textSlumpa
            // 
            this.textSlumpa.Location = new System.Drawing.Point(468, 203);
            this.textSlumpa.Name = "textSlumpa";
            this.textSlumpa.Size = new System.Drawing.Size(110, 23);
            this.textSlumpa.TabIndex = 9;
            // 
            // loopar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textSlumpa);
            this.Controls.Add(this.textNum_2);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btnSlumpa);
            this.Name = "loopar";
            this.Text = "loopar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSlumpa;
        private Label lb;
        private Label lblb;
        private TextBox textBox1;
        private TextBox textNum1;
        private TextBox textNum_2;
        private TextBox textSlumpa;
    }
}