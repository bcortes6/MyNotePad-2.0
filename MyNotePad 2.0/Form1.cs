using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Agrregamos esta biblioteca, para guardar y abrir archivos

namespace MyNotePad_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void naramjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stm;
            OpenFileDialog ofd = new OpenFileDialog();//Es el cuadrito para abrir y crear un nuevo cuadro
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if((stm = ofd.OpenFile())!=null) //Rebisa que el archivo no este nulo o vacio
                {
                    string str = ofd.FileName;//guarda el nombre del archivo
                    string ftxt = File.ReadAllText(str);//lee todo el texto del archivo
                    richTextBox1.Text = ftxt;
                }
            }
                
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Guardar archivo
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo de texto (*.txt)|*.txt|Archivo de C#(*.CS)|*.cs";
            sfd.ShowDialog();
            File.WriteAllText(sfd.FileName, richTextBox1.Text);
            MessageBox.Show("Archivo de texto guardado existosamente.");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
