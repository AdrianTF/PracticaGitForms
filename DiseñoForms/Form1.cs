using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseñoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = listBox1.SelectedItem.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                listBox1.Visible = false;
                this.BackColor = Color.Beige;
            }
            else
            {
                listBox1.Visible = true;
                this.BackColor = Color.Aquamarine;
            }
            EspacioElefante.Elefantes Dumbo = new EspacioElefante.Elefantes();
            EspacioElefante.Elefantes Nala = new EspacioElefante.Elefantes();
            Nala.Nombre = "NombreNala";
            Nala.Dimension = 200;
            Dumbo.Nombre = "Juan";
            Dumbo.Dimension = 50;
            Dumbo.Habla();
            Nala.Habla();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(maskedTextBox1.Text,"Mensaje de saludo",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            label1.Text = respuesta.ToString();
            if (respuesta.ToString() == "Yes")
            {
                MessageBox.Show("Buena esa");
            }
            else
            {
                MessageBox.Show("Pues no");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 miForm2 = new Form2();
            miForm2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        //class Elefantes
        //{
        //    public string Nombre;
        //    public int Dimension;

        //    public void Habla()
        //    {
        //        MessageBox.Show("Hola, mi nombre es " + Nombre + " y mido " + Dimension);

        //    }

        //} La clase puede hacerse dentro del mismo namespace o de otro.
    }

   
}

namespace EspacioElefante
{
    class Elefantes
    {
        public string Nombre;
        public int Dimension;

        public void Habla()
        {
            MessageBox.Show("Hola, mi nombre es " + Nombre + " y mido " + Dimension);

        }

    }
}