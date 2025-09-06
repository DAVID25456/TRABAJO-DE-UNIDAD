using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA
{
    public partial class Form1 : Form
    {
        //Declaracion de variables globales
        string strUsuario = "Admin";
        string strPassword = "1234";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text.ToUpper() == strUsuario.ToUpper() && txtpassword.Text == strPassword)
            {
                string a = txtusuario.Text;
                string b = txtpassword.Text;

                MDIParent1 mDI_Principal = new MDIParent1();
                mDI_Principal.Show();

            }
            else
            {
                MessageBox.Show("Error, Datos incorrectos");
            }
        }
    }
}
