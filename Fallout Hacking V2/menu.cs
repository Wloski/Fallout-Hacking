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
    public partial class menu : MetroForm
    {

        public menu()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager;
            metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            gameForm _gameForm = new gameForm();
            _gameForm.Show();
            
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            
            optionMenu _optionMenu = new optionMenu();
            _optionMenu.ShowDialog();
        }
    }
}
