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
    public partial class FormNotepad: Form
    {
        public FormNotepad()
        {
            InitializeComponent();
            this.Text = "Блокнот и генерация пароля";
        }

        private void FormNotepad_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            new ThreeForms().Show();
            this.Close();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int length = (int)nudLength.Value;
            bool includeDigits = cbDigits.Checked;
            bool includeSymbols = cbSymbols.Checked;
            tbPassword.Text = GeneratePassword(length, includeDigits, includeSymbols);
        }



        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtbText.Text = File.ReadAllText(ofd.FileName, Encoding.UTF8);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files|*.txt|All Files|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, rtbText.Text, Encoding.UTF8);
            }
        }

        private string GeneratePassword(int length, bool includeDigits, bool includeSymbols)
        {
            string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digits = "0123456789";
            string symbols = "!@#$%^&*";
            string charSet = letters;
            if (includeDigits) charSet += digits;
            if (includeSymbols) charSet += symbols;

            StringBuilder password = new StringBuilder();
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                password.Append(charSet[rnd.Next(charSet.Length)]);
            }
            return password.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            rtbText.Clear();
        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtbText.Text = File.ReadAllText(ofd.FileName, Encoding.UTF8);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files|*.txt|All Files|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, rtbText.Text, Encoding.UTF8);
            }
        }
    }
}
