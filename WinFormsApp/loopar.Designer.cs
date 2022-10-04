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
            this.numTal_1 = new System.Windows.Forms.NumericUpDown();
            this.numTal_2 = new System.Windows.Forms.NumericUpDown();
            this.num_Slumptal = new System.Windows.Forms.NumericUpDown();
            this.lb = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTal_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTal_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Slumptal)).BeginInit();
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
            // 
            // numTal_1
            // 
            this.numTal_1.Location = new System.Drawing.Point(290, 205);
            this.numTal_1.Name = "numTal_1";
            this.numTal_1.Size = new System.Drawing.Size(83, 23);
            this.numTal_1.TabIndex = 1;
            this.numTal_1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numTal_2
            // 
            this.numTal_2.Location = new System.Drawing.Point(379, 205);
            this.numTal_2.Name = "numTal_2";
            this.numTal_2.Size = new System.Drawing.Size(83, 23);
            this.numTal_2.TabIndex = 2;
            // 
            // num_Slumptal
            // 
            this.num_Slumptal.Location = new System.Drawing.Point(468, 205);
            this.num_Slumptal.Name = "num_Slumptal";
            this.num_Slumptal.Size = new System.Drawing.Size(110, 23);
            this.num_Slumptal.TabIndex = 3;
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
            // loopar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.num_Slumptal);
            this.Controls.Add(this.numTal_2);
            this.Controls.Add(this.numTal_1);
            this.Controls.Add(this.btnSlumpa);
            this.Name = "loopar";
            this.Text = "loopar";
            ((System.ComponentModel.ISupportInitialize)(this.numTal_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTal_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Slumptal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSlumpa;
        private NumericUpDown numTal_1;
        private NumericUpDown numTal_2;
        private NumericUpDown num_Slumptal;
        private Label lb;
        private Label lblb;
        private TextBox textBox1;
    }
}