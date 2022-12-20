using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class Form3 : Form
    {
        Form2 form2;
        public Form3(Form2 form2)
        {
            InitializeComponent();
            this.form2 = form2;
            form2.Enabled = false;

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            form2.Enabled = true;

        }
    }
}
