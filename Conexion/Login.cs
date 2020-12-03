using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Conexion
{

    public partial class Login : Form
    {
        int cont = 3;

        Conectar con;
        Inicio mDI;
        BackgroundWorker bg = new BackgroundWorker();
        public Login()
        {
            InitializeComponent();
        }

       private void bg_DoWork(object sender,EventArgs e)
        {
            int progreso = 0;


            for (int i = 0; i <= 100; i++)
            {
                progreso++;
                Thread.Sleep(50);
                bg.ReportProgress(i); 
            }
        }

        private void bg_ProgressChanged(object sender,ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            progressBar1.Style = ProgressBarStyle.Continuous;


            if (e.ProgressPercentage > 100)
            {
                label5.Text = "100%";
                progressBar1.Value = progressBar1.Maximum;
            }
            else
            {
                label5.Text = Convert.ToString(e.ProgressPercentage) + "%";
                progressBar1.Value = e.ProgressPercentage;
            }


        }

        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            mDI = new Inicio(con);

            mDI.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            entrar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                entrar();
            }
        }

        private void entrar()
        {

            Cursor.Current = Cursors.WaitCursor;

            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("No pueden haber campos vacios", "Alerta");
                Cursor.Current = Cursors.Default;
                return;
            }

            con = new Conectar(textBox1.Text, textBox2.Text);
            if (this.con.connect.State == ConnectionState.Open)
            {

                bg.WorkerReportsProgress = true;
                bg.ProgressChanged += bg_ProgressChanged;
                bg.DoWork += bg_DoWork;
                bg.RunWorkerCompleted += bg_RunWorkerCompleted;
                bg.RunWorkerAsync();
                label5.Visible = true;
                progressBar1.Visible = true;



            }
            else
            {
                Cursor.Current = Cursors.Default;
                --cont;
                MessageBox.Show("Error:usuario o contrasenia incorrecta ", cont + " Intentos restantes");
                if (cont == 0)
                {
                    cont = 3;
                    button1.Enabled = false;
                    MessageBox.Show("Error: Intentos de sesión fallidos máximos agotado, intente nuevamente en 1 minutos");
                    Thread.Sleep(60000);
                    button1.Enabled = true;


                }


            }
        }
    }
}
