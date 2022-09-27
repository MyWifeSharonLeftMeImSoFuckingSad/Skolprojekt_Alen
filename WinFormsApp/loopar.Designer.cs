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
            this.domFirst = new System.Windows.Forms.DomainUpDown();
            this.domLast = new System.Windows.Forms.DomainUpDown();
            this.domAnswer = new System.Windows.Forms.DomainUpDown();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.lblBetween = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // domFirst
            // 
            this.domFirst.Location = new System.Drawing.Point(338, 176);
            this.domFirst.Name = "domFirst";
            this.domFirst.Size = new System.Drawing.Size(63, 23);
            this.domFirst.TabIndex = 0;
            this.domFirst.Text = "domainUpDown1";
            // 
            // domLast
            // 
            this.domLast.Location = new System.Drawing.Point(0, 0);
            this.domLast.Name = "domLast";
            this.domLast.Size = new System.Drawing.Size(120, 23);
            this.domLast.TabIndex = 0;
            // 
            // domAnswer
            // 
            this.domAnswer.Location = new System.Drawing.Point(0, 0);
            this.domAnswer.Name = "domAnswer";
            this.domAnswer.Size = new System.Drawing.Size(120, 23);
            this.domAnswer.TabIndex = 0;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(0, 0);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 0;
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.Location = new System.Drawing.Point(0, 0);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(100, 23);
            this.lblRandomNumber.TabIndex = 0;
            // 
            // lblBetween
            // 
            this.lblBetween.Location = new System.Drawing.Point(0, 0);
            this.lblBetween.Name = "lblBetween";
            this.lblBetween.Size = new System.Drawing.Size(100, 23);
            this.lblBetween.TabIndex = 0;
            // 
            // loopar
            // 
            this.ClientSize = new System.Drawing.Size(495, 261);
            this.Name = "loopar";
            this.Load += new System.EventHandler(this.loopar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DomainUpDown domFirst;
        private DomainUpDown domLast;
        private DomainUpDown domAnswer;
        private Button btnRandom;
        private Label lblRandomNumber;
        private Label lblBetween;
    }
}