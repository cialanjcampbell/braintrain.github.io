using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace QuizNea
{
    public partial class FmBrowse : Form
    {
        private List<Topic> topicsFromTopicManager = new List<Topic>();
        private Settings settings = new Settings();
        private Topic currentTopic { get; set; }
        private TopicManager topicManager = new TopicManager();
        private FilePathManager pathManager = new FilePathManager();
   

        public FmBrowse()
        {
            this.Icon = Properties.Resources.favicon;
           
            InitializeComponent();
            this.Text = "ReviseWise";
            topicsFromTopicManager = topicManager.GetTopics();
        
            AddTopicsToListBox(topicsFromTopicManager);

            currentTopic = topicsFromTopicManager.First();
            settings.SetCurrentTopic(currentTopic.GetTopicName());
            pathManager.WriteCurrentTopicToFile(currentTopic.GetTopicName());
            currentTopicLabel.Text = currentTopic.GetTopicName();
        }
      
        private void AddTopicsToListBox(List<Topic> topics)
        {
            foreach (Topic item in topics)
            {
                topicListBox.Items.Add(item.GetTopicName());
            }
        }
        private void TopicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (topicListBox != null || topicListBox.SelectedItem != null)
            {
                try
                {
                    currentTopic = topicsFromTopicManager[topicListBox.SelectedIndex];
                    settings.SetCurrentTopic(currentTopic.GetTopicName());
                    pathManager.WriteCurrentTopicToFile(currentTopic.GetTopicName());
                    currentTopicLabel.Text = currentTopic.GetTopicName();
                    
                }

                catch (NullReferenceException ex)
                {
                    Console.WriteLine("An error has occured" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Choose a Topic");
            }
        }
        private void renameMenuItem_Click(object sender, EventArgs e)
        {
            using (FmRenameTopic fmRenameTopic = new FmRenameTopic())
            {
                DialogResult result = fmRenameTopic.ShowDialog();

                if (result == DialogResult.OK && currentTopic.GetTopicName() != "Default")
                {
                    string newName = fmRenameTopic.newTopicName;
                    topicManager.EditTopic(currentTopic, newName);
                    topicsFromTopicManager.Clear();
                    topicListBox.Items.Clear();
                    topicsFromTopicManager = topicManager.GetTopics();
                    AddTopicsToListBox(topicsFromTopicManager);
                    MessageBox.Show($"Result from dialog: {newName}");

                }
                else
                {
                    MessageBox.Show("Dialog was canceled or closed without saving.");
                }
            }
            
           
        }
        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            if (topicListBox.SelectedItem != null || topicListBox.SelectedItem.ToString() != "Default")
            {         
                topicManager.DeleteTopic(currentTopic);
                topicsFromTopicManager.Clear();
                topicListBox.Items.Clear();
                topicsFromTopicManager = topicManager.GetTopics();
                AddTopicsToListBox(topicsFromTopicManager);   
            }
            else
            {
                MessageBox.Show("You Didnt Select a topic");
            }
        }

        private void optionsMenuItem_Click(object sender, EventArgs e)
        {
          
            try
            {
                FmEditCard fmEditCard = new FmEditCard();
                fmEditCard.ShowDialog();
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("Topic Empty, Please add some flashcard and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void startRevisingMenuItem_Click(object sender, EventArgs e)
        {
            FmRevision fmRevision = new FmRevision();
            fmRevision.ShowDialog();
        }

        private void RbCreateTopic_Click(object sender, EventArgs e)
        {
            FmCreateTopic fmCreateTopic = new FmCreateTopic();
            fmCreateTopic.ShowDialog();
            topicListBox.Items.Clear();
            topicsFromTopicManager = topicManager.GetTopics();
            AddTopicsToListBox(topicsFromTopicManager);
        }

        private void RbAddCard_Click(object sender, EventArgs e)
        {
            FmAddCard fmAddCard = new FmAddCard();
            fmAddCard.ShowDialog();
        }

        private void statisticsMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTopic.GetTopicFlashcards().Count() == 0)
            {
                MessageBox.Show("There are no flashcards available for statistics on this topic.");
                return;
            }
            else
            {
                FmStatistics fmStatistics = new FmStatistics();
                fmStatistics.ShowDialog();
            }
            
        }
    }
}
