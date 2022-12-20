using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace kursach
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            GenerationMassiv.Enabled = false;
            Sort.Enabled = false;
        }
        
        int n;
        int[] massiv;
        private void Form2_Load(object sender, EventArgs e)
        {

            
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void GenerationMassiv_Click(object sender, EventArgs e)
        {
            n = Int32.Parse(razmer.Text);
            string massivstring = "";
            massiv = new int[n];
            Random random= new Random();
            for (int i = 0; i < n; i++)
            {
                massiv[i] = random.Next(1, 10000);
            }
            for (int i = 0; i < n; ++i)
                massivstring += (massiv[i] + "   ");
            textBox_massiv.Text = massivstring;
            
        }
        public void Sort_Click(object sender, EventArgs e)
        {
            HeapSort ob = new HeapSort();
            ob.sort(massiv);
            textBox_massiv.Text = "";
            string massivstring = "";
            for (int i = 0; i < n; i++)
            {
                massivstring += (massiv[i] + "   ");
            }
            textBox_massiv.Text = massivstring;
        }
        private void razmer_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void razmer_TextChanged(object sender, EventArgs e)
        {
            GenerationMassiv.Enabled = !string.IsNullOrWhiteSpace(razmer.Text);
        }
        private void textBox_massiv_TextChanged(object sender, EventArgs e)
        {
            Sort.Enabled = !string.IsNullOrWhiteSpace(textBox_massiv.Text);
        }

        private void histogramm_Click(object sender, EventArgs e)
        {

        }


        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти из программы?"
, "Завершение программы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void aboutProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 about = new Form3(this);
            about.Show();
        }
    }
}
