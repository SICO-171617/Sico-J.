using System.Collections;
using System.Text;

namespace Comprog3TP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand;

        //string array for the words
        string[] words =
        {
            "applebee",
            "bumblebee",
            "pumpkin",
            "watermelon",
            "character",
            "vehicle"
        };
        string word;
        int word_order;

        public void load_word()
        {
            if (word_order < words.Length)
            {
                word = words[word_order].ToUpper(); //Masking the words with asterisk, so that it covers some letters 
                int word_length = word.Length;
                StringBuilder maskedWord = new StringBuilder(new string('*', word_length)); 
                int masks = word_length / 2;
                ArrayList letter_masks = new ArrayList();

                
                for (int i = 0; i < masks; i++)
                {
                    bool can_loop = true;
                    do
                    {
                        int rand_num = rand.Next(word_length);
                        if (!letter_masks.Contains(rand_num))
                        {
                            letter_masks.Add(rand_num);
                            can_loop = false;
                        }
                    } while (can_loop);
                }

                
                for (int i = 0; i < word_length; i++)
                {
                    if (!letter_masks.Contains(i))
                    {
                        maskedWord[i] = word[i];
                    }
                }

                lb_mask_word.Text = maskedWord.ToString(); 
            }
            else
            {
                refresh_words();  
                load_word();
            }
        }

        public void refresh_words()
        {
            words = words.OrderBy(x => rand.Next()).ToArray(); 
            word_order = 0;  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();
            refresh_words();
            load_word(); 
        }

        private void tb_guess_Click(object sender, EventArgs e)//if-else conditions for everytime the player wins or inserted a wromg guess
        {
            if (tb_guess.Text == "Play Again?") 
            {
                word_order++;  
                if (word_order >= words.Length) 
                {
                    refresh_words();
                }

                load_word(); 
                tb_guess.Text = "Guess"; 
                wrong_guessed_list.Items.Clear(); 
            }
            else if (tb_answer.Text.ToUpper().Equals(word)) 
            {
                lb_mask_word.Text = word;  
                tb_guess.Text = "Play Again?";  
                MessageBox.Show("Correct!");
            }
            else 
            {
                wrong_guessed_list.Items.Add(tb_answer.Text); 
                MessageBox.Show("Wrong Answer!");
            }

            tb_answer.Text = "";  
        }
    }
}