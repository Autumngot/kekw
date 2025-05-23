using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace create_form
{
    public partial class FormTemperature: Form
    {
        public FormTemperature()
        {
            InitializeComponent();
            this.Text = "Конвертер температуры";
        }

        private void FormTemperature_Load(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbInput.Text, out double celsius))
            {
                double fahrenheit = celsius * 9 / 5 + 32;
                double kelvin = celsius + 273.15;
                lblFahrenheit.Text = "Фаренгейт: " + fahrenheit.ToString("F2");
                lblKelvin.Text = "Кельвин: " + kelvin.ToString("F2");
            }
            else
            {
                MessageBox.Show("Введите корректное числовое значение!");
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            new ThreeForms().Show();
            this.Close();
        }
    }
}
