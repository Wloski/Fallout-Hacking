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
    public partial class gameForm : MetroForm
    {
        
        gameLogic _gameLogic = new gameLogic();
        List<char> passwordChars = new List<char>();
        string password = null;
        int numberofAttempts = 0;
        int status = 1; //0 = lose, 1 = playing 2 = win
        public gameForm()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager;
            metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            
        }

        private void gameForm_Load(object sender, EventArgs e)
        {
            
            gameListBox.Items.Add("Welcome to ROBCO Industries (TM) Termlink");
            gameListBox.Items.Add("Password Required");
            gameListBox.Items.Add("");
            List<string> WordList = _gameLogic.createWordList();
            List<string> randomWordList = _gameLogic.getRandomWords(WordList);
            password = _gameLogic.getPassword(randomWordList);
            foreach (char c in password)
            {
                passwordChars.Add(c);
            }

            Random _random = new Random();
            foreach (var word in randomWordList)
            {
                int randomnum = _random.Next(0, 9000);          
                gameListBox.Items.Add("0x" + randomnum + " " + word.ToUpper() + "  " + "0x" + randomnum + " " + _gameLogic.RandomString(4));
                randomnum = _random.Next(0, 9000);
                gameListBox.Items.Add("0x" + randomnum + " " + _gameLogic.RandomString(12));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void gameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                    string answer = textBox1.Text;
                    if (e.KeyCode == Keys.Enter)
                    {
                        if (textBox1.TextLength != options.wordLength)
                        {
                            inputListBox.Items.Add("Please Enter a correct option");
                        }
                        else
                        {
                            if (status == 2)
                            {
                                return;
                            }

                            int likeness = 0;
                            inputListBox.Items.Add(">" + answer.ToUpper());
                            if (answer.ToUpper() != password.ToUpper())
                            {

                                int i = 0;
                                foreach (char c in answer)
                                {

                                    if (c == passwordChars[i])
                                    {
                                        likeness = likeness + 1;
                                    }
                                    i++;
                                }
                                inputListBox.Items.Add("> Likeness:" + likeness);
                            }
                            else
                            {

                                status = 2;
                                inputListBox.Items.Add("> Likeness: Correct");
                                gameListBox.Items.Clear();
                                gameListBox.Items.Add("Welcome to ROBCO Industries (TM) Termlink");
                                gameListBox.Items.Add("Access granted... You win!");
                                metroButton1.Visible = true;
                            }
                            if (numberofAttempts == options.attemps)
                            {
                                status = 0;
                                gameListBox.Items.Clear();
                                gameListBox.Items.Add("ROBCO Industries (TM) Termlink");
                                gameListBox.Items.Add("Access denied... You lose!");
                                metroButton1.Visible = true;
                            }
                            numberofAttempts++;
                            textBox1.Text = String.Empty;
                        }
                    }
                
            }
            catch (Exception)
            {
                inputListBox.Items.Add("There was an error; Please try again...");
                throw;
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }

}
