using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fallout_Hacking_V2
{
    class gameLogic
    {

        public List<string> createWordList() //Get words from txt file and put into a list 
        {
            string filepath = "";
            if (options.wordLength == 3)
            {
                filepath = "3Letterwords.txt";
            }
            if (options.wordLength == 4)
            {
                filepath = "4Letterwords.txt";
            }
            if (options.wordLength == 5)
            {
                filepath = "5Letterwords.txt";
            }
            List<string> WordList = File.ReadLines(filepath).ToList();
            return WordList;
        }

        public List<string> getRandomWords(List<string> _wordList)
        {
            List<string> randomWordList = new List<string>(); // Create new list
            int numberOfWords = _wordList.Count(); //Get the amount of words in the list
            Random _random = new Random();
            for (int i = 1; i < 10; i++)
            {
                int random = _random.Next(0, numberOfWords);
                randomWordList.Add(_wordList[random]);                   
            }
            return randomWordList;
        }
        public string getPassword(List<string> randomWordList)
        {
            Random _random = new Random();
            int random = _random.Next(0, randomWordList.Count());
            string password = randomWordList[random];
            return password;
        }


        public string RandomString(int Size)
        {
            Random _random = new Random();
            string input = "!£$%^&*()_+{}:@~?><";
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < Size; i++)
            {
                
                ch = input[_random.Next(0, input.Length)];
                builder.Append(ch);
            }
            return builder.ToString();
        }
    }
}
