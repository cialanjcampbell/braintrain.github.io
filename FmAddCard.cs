using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizNea
{

    public partial class FmAddCard : Form
    {
        private FilePathManager pathManger = new FilePathManager();
        private FlashCardManager flashcardManager = new FlashCardManager();
        private Flashcard flashcardToBeAdded;
        private TopicManager topicManager = new TopicManager();
        private List<Topic> topicsFromTopicManager = new List<Topic>();
        private Topic selectedTopic;
        private bool TFModeActive = false;

        public FmAddCard()
        {
            this.Icon = Properties.Resources.favicon;
            InitializeComponent();

            topicsFromTopicManager = topicManager.GetTopics();

            foreach (Topic topic in topicsFromTopicManager)
            {
                topicListBox.Items.Add(topic.GetTopicName());
            }
            selectedTopic = topicManager.GetTopicByName("Default");
            
        }
        private void BtAddCard_Click(object sender, EventArgs e)
        {       
            TranscribeFlashcard();
            MessageBox.Show("Flashcard added!");
            UpdateForm();
        }
        private void BtTrue_Click(object sender, EventArgs e)
        {
            TranscribeFlashcard(true);
            MessageBox.Show("true added!");
            UpdateForm();
        }
        private void BtFalse_Click(object sender, EventArgs e)
        {
            TranscribeFlashcard(false);
            MessageBox.Show("false added!");
            UpdateForm();
        }
        private void TranscribeFlashcard([Optional] bool boolAnswer)
        {

            //string mode = "TorF";
            //selectedTopic = topicsFromTopicManager{topicListBox.SelectedIndex];



            if (topicListBox.SelectedIndex != -1)
            {
                selectedTopic = topicsFromTopicManager[topicListBox.SelectedIndex];
            }
            
            if (TFModeActive)
            {// adds a true or flashcard card
                          
                string face = richTextBox1.Text;
                bool back = boolAnswer;

                flashcardToBeAdded = new TrueFalseFlashcard(face, back);
                flashcardManager.CreateFlashcard(selectedTopic, flashcardToBeAdded);
            }
            else
            {//adds a normal cards
                string face = richTextBox1.Text;
                string back = richTextBox2.Text;
                flashcardToBeAdded = new Flashcard(face, back);

                flashcardManager.CreateFlashcard(selectedTopic, flashcardToBeAdded);
            }
            
        }


        private void BtBack_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void UpdateForm()
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void BtSwitchMode_Click(object sender, EventArgs e)
        {
                  
            // Create a SplitContainer
            SplitContainer splitContainer = new SplitContainer();
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.SplitterDistance = splitContainer.Width / 2;

            // Create two buttons
            Button BtTrue = new Button();
            BtTrue.Text = "True";
            Button BtFalse = new Button();
            BtFalse.Text = "False";

            // Set Properties
            BtTrue.Click += BtTrue_Click;
            BtFalse.Click += BtFalse_Click;

            BtTrue.Dock = DockStyle.Fill;
            BtFalse.Dock = DockStyle.Fill;
            BtTrue.BackColor = Color.Lavender;
            BtFalse.BackColor = Color.Lavender;

            BtTrue.Font = new Font(this.Font, FontStyle.Bold);
            BtFalse.Font = new Font(this.Font, FontStyle.Bold);



            // Add buttons to the SplitContainer panels
            splitContainer.Panel1.Controls.Add(BtTrue);
            splitContainer.Panel2.Controls.Add(BtFalse);

            // Remove add card button
            tableLayoutPanel2.Controls.Remove(BtAddCard);

            // Remove the rich text box from the TableLayoutPanel
            tableLayoutPanel1.Controls.Remove(richTextBox2);
            

            // Add the splitcontainer to the same cell
            tableLayoutPanel1.Controls.Add(splitContainer);

            if (TFModeActive)
            {
                
                // Remove the split container
                tableLayoutPanel1.Controls.Remove(splitContainer);
                // add the back rich text box and Add card button
                tableLayoutPanel1.Controls.Add(richTextBox2);
                tableLayoutPanel2.Controls.Add(BtAddCard);

            }
            TFModeActive = !TFModeActive;
        }

        private void richTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // Prevent the Enter key from adding a new line in the text box

                // Call the method to add the flashcard
                TranscribeFlashcard();
                MessageBox.Show("Flashcard added!");
                UpdateForm();
            }
        }
    }
}
