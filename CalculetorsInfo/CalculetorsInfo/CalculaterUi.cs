using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculetorsInfo.Models;

namespace CalculetorsInfo
{
    public partial class CalculaterUi : Form
    {
        public CalculaterUi()
        {
            InitializeComponent();
        }
       
        private void addButton_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            int firstNumber = Convert.ToInt32(firstTextBox1.Text);
            int secondNumber = Convert.ToInt32(secondTextBox2.Text);
            int lastNumber = 60;
            double result = calculator.Add(firstNumber, secondNumber,  60);

            firstTextBox1.Clear();
            secondTextBox2.Clear();

             resultInLabel.Text = result.ToString();

        }

        private void CalculaterUi_Load(object sender, EventArgs e)
        {

        }
    }
}
