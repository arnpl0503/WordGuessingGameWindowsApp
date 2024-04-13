using System.Windows.Forms;

namespace WordGuessingGameWindowsApp
{
    public partial class Form1 : Form
    {
        private string guessWord = "computer";
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
            string word = textBox1.Text;

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
        
