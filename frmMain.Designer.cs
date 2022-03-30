namespace AS2122_3G_INF_UbaldiEdoardo_CalcolatriceDll
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOp1 = new System.Windows.Forms.TextBox();
            this.txtOp2 = new System.Windows.Forms.TextBox();
            this.cmbOperazione = new System.Windows.Forms.ComboBox();
            this.lblRis = new System.Windows.Forms.Label();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operando 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operando 2:";
            // 
            // txtOp1
            // 
            this.txtOp1.Location = new System.Drawing.Point(217, 66);
            this.txtOp1.Name = "txtOp1";
            this.txtOp1.Size = new System.Drawing.Size(150, 31);
            this.txtOp1.TabIndex = 2;
            // 
            // txtOp2
            // 
            this.txtOp2.Location = new System.Drawing.Point(217, 132);
            this.txtOp2.Name = "txtOp2";
            this.txtOp2.Size = new System.Drawing.Size(150, 31);
            this.txtOp2.TabIndex = 3;
            // 
            // cmbOperazione
            // 
            this.cmbOperazione.FormattingEnabled = true;
            this.cmbOperazione.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperazione.Location = new System.Drawing.Point(427, 66);
            this.cmbOperazione.Name = "cmbOperazione";
            this.cmbOperazione.Size = new System.Drawing.Size(182, 33);
            this.cmbOperazione.TabIndex = 4;
            // 
            // lblRis
            // 
            this.lblRis.AutoSize = true;
            this.lblRis.Location = new System.Drawing.Point(99, 221);
            this.lblRis.Name = "lblRis";
            this.lblRis.Size = new System.Drawing.Size(76, 25);
            this.lblRis.TabIndex = 5;
            this.lblRis.Text = "risultato";
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(427, 132);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(112, 34);
            this.btnCalcola.TabIndex = 6;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.lblRis);
            this.Controls.Add(this.cmbOperazione);
            this.Controls.Add(this.txtOp2);
            this.Controls.Add(this.txtOp1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtOp1;
        private TextBox txtOp2;
        private ComboBox cmbOperazione;
        private Label lblRis;
        private Button btnCalcola;
    }
}