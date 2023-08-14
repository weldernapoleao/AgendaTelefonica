using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agenda Telofônica v1.0 \nWritten Por: Welder Napoleão", "Sobre");
        }

        private void contatoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contatoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'agendaDBDataSet.contato'. Você pode movê-la ou removê-la conforme necessário.
            this.contatoTableAdapter.Fill(this.agendaDBDataSet.contato);

        }

        private void clienteCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void contatoIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomecontatoLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomecontatoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void empresaLabel_Click(object sender, EventArgs e)
        {

        }

        private void empresaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void telefoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void contatoIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ultimocontatoLabel_Click(object sender, EventArgs e)
        {

        }

        private void ultimocontatoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
