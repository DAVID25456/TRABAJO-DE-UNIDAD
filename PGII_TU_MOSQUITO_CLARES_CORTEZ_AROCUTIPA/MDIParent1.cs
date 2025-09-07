using PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Ejercicios;
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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void eJERCICIO01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_01 ejr01 = new Ejercicio_01();
            ejr01.Show();
            this.Close();
        }

        private void eJERCICIO02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_02 ejr02 = new Ejercicio_02();
            ejr02.Show();
        }

        private void eJERCICIO03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_03 ejr03 = new Ejercicio_03();
            ejr03.Show();
        }

        private void eJERCICIO04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_04 ejr04 = new Ejercicio_04();
            ejr04.Show();
        }

        private void eJERCICIO05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_05 ejr05 = new Ejercicio_05();
            ejr05.Show();
        }

        private void eJERCICIO06ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_06 ejr06 = new Ejercicio_06();
            ejr06.Show();
        }

        private void eJERCICIO07ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_07 ejr07 = new Ejercicio_07();
            ejr07.Show();
        }

        private void eJERCICIO08ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_08 ejr08 = new Ejercicio_08();
            ejr08.Show();
        }

        private void eJERCICIO09ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_09 ejr09 = new Ejercicio_09();
            ejr09.Show();
        }

        private void eJERCICIO10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_10 ejr10 = new Ejercicio_10();
            ejr10.Show();
        }

        private void eJERCICIO11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_11 ejr11 = new Ejercicio_11();
            ejr11.Show();
        }

        private void eJERCICIO12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_12 ejr12 = new Ejercicio_12();
            ejr12.Show();
        }

        private void eJERCICIO13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_13 ejr13 = new Ejercicio_13();
            ejr13.Show();
        }

        private void eJERCICIO14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_14 ejr14 = new Ejercicio_14();
            ejr14.Show();
        }

        private void eJERCICIO15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_15 ejr15 = new Ejercicio_15();
            ejr15.Show();
        }

        private void eJERCICIO16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_16 ejr16 = new Ejercicio_16();
            ejr16.Show();
        }

        private void eJERCICIO17ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_17 ejr17 = new Ejercicio_17();
            ejr17.Show();
        }

        private void eJERCICIO18ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_18 ejr18 = new Ejercicio_18();
            ejr18.Show();
        }

        private void eJERCICIO19ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_19 ejr19 = new Ejercicio_19();
            ejr19.Show();
        }
    }
}
