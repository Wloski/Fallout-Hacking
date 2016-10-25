using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fallout_Hacking_V2
{
    public partial class optionMenu : MetroForm
    {


        public optionMenu()
        {
            InitializeComponent();
           
        }

        private void options_Load(object sender, EventArgs e)
        {
            //Attemps
            metroComboBox1.Items.Add("3");
            metroComboBox1.Items.Add("4");
            metroComboBox1.Items.Add("5");
            metroComboBox1.Text = options.attemps.ToString();

            //words
            metroComboBox2.Items.Add("3");
            metroComboBox2.Items.Add("4");
            metroComboBox2.Items.Add("5");
            metroComboBox2.Text = options.wordLength.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            options.attemps = Int32.Parse(metroComboBox1.Text) -1;
            options.wordLength = Int32.Parse(metroComboBox2.Text);
            this.Close();
        }
    }
}
