using System.Windows.Forms;
using System.Collections;
using System.Text;
namespace WordGuessingGameWindowsApp
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            HideWord();
        }
        private void HideWord()
        {
            string Hide = "c??????r";
            textBox2.Text = Hide;
        }

        private void Guessing1_Click(object sender, EventArgs e)
        {
            string guessWord = "computer";

            StringBuilder word = new StringBuilder(textBox1.Text);

            if (word.Equals(guessWord))
            {
                textBox2.Text = guessWord;
                MessageBox.Show("Correct Guess!" + "\n" + "The word is " + guessWord);
            }
            else
            {
                listBox1.Items.Add(word);
                MessageBox.Show("Wrong Guess, Try again");
            }
        }
    }
}
        
