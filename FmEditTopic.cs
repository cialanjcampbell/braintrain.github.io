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
    
    public partial class FmEditTopic : Form
    {
        private List<Topic> topicsFromTopicManager { get; set; }
        private Topic selectedTopic;
        private string topicName;
        private string newTopicName;
        private TopicManager tManager;

        public FmEditTopic()
        {
            this.Icon = Properties.Resources.favicon;
            InitializeComponent();

        
            tManager = new TopicManager();

          
            topicsFromTopicManager = new List<Topic>();

            topicsFromTopicManager = tManager.GetTopics();

            addTopicsToListBox(topicsFromTopicManager); 

        }

        public Topic GetSelectedTopic()
        {
            return selectedTopic;
        }

        public string GetTopicName()
        {
            return topicName;
        }

        public string GetNewTopicName()
        {
            return newTopicName;
        }

        public void setTopicListFromTopicManager(List<Topic> topics)
        {
            topicsFromTopicManager = topics;
        }

        private void addTopicsToListBox(List<Topic> topics)
        {
            foreach (Topic item in topics)
            {
                TopicListBox.Items.Add(item.GetTopicName());
            }
        }
        private void BtRename_Click(object sender, EventArgs e)
        {
            this.selectedTopic = topicsFromTopicManager[TopicListBox.SelectedIndex];

            if (TopicListBox.SelectedItem != null && newNameTxtBox.Text != null)
            {
                foreach (Topic topic in topicsFromTopicManager)
                {
                    if (newNameTxtBox.Text == topic.GetTopicName())
                    {
                        MessageBox.Show("You cannot have Two topics with the same name!");
                        this.Close();
                        return;
                    }
                }

                topicName = selectedTopic.GetTopicName();
                newTopicName = newNameTxtBox.Text;
                
                tManager.EditTopic(selectedTopic, newTopicName);

                this.DialogResult = DialogResult.Yes;

                this.Close();
            }
            else
            {
                MessageBox.Show("You Didnt Select a topic");
            }
        }

        private void BtBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
