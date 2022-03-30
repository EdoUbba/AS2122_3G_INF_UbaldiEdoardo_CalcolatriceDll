namespace AS2122_3G_INF_UbaldiEdoardo_CalcolatriceDll;
using AS2122_3G_INF_UbaldiEdoardo_CalcolatriceDllLibrary;
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            int risultato = 0;
            int op1 = Convert.ToInt32(txtOp1.Text);
            int op2 = Convert.ToInt32(txtOp2.Text);
            //classe in DLL per operazioni
            Operazioni op = new Operazioni();
            switch (cmbOperazione.Text)
            {
                case "+":
                    risultato = op.Somma(op1,op2);
                    break;
                case "-":
                    risultato = op.Sottrazione(op1, op2);
                    break;
                case "*":
                    risultato = op.Moltiplicazione(op1, op2);
                    break;
                case "/":
                    risultato = op.Divisione(op1, op2);
                    break;
            }
        lblRis.Text = Convert.ToString(risultato);
        }
    }
