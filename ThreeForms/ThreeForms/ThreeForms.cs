using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace create_form
{
     public partial class ThreeForms : Form
    {
        public ThreeForms()
        {
            InitializeComponent();
            this.Text = "Главное меню";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            new FormNotepad().Show();
            this.Hide();
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            new FormTemperature().Show();
            this.Hide();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            new FormImage().Show();
            this.Hide();
        }
    }
}
