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
    public partial class FmOptions : Form
        
    {
        private List<Topic> topicsFromTopicManager = new List<Topic>();
        private Settings settings = new Settings();
        private string currentTopic { get; set; }
        private TopicManager topicManager = new TopicManager();
        private FilePathManager pathManager = new FilePathManager();

        public FmOptions()
        {
            this.Icon = Properties.Resources.favicon;
            InitializeComponent();
            
            settings.GetSettingsFromFile();
            currentTopic = settings.GetCurrentTopic();
            currentTopicLabel.Text = ($"{currentTopic}");


            topicsFromTopicManager = topicManager.GetTopics();
           
            AddTopicsToListBox(topicsFromTopicManager);       
        }
        private void AddTopicsToListBox(List<Topic> topics)
        {
            foreach (Topic item in topics) 
            {              
                TopicList.Items.Add(item.GetTopicName());
            }           
        }
        private void TopicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TopicList != null && TopicList.SelectedItem != null)
            {
                try
                {
                    string selectedTopic = TopicList.SelectedItem.ToString();
                    settings.SetCurrentTopic(selectedTopic);
                    pathManager.WriteCurrentTopicToFile(selectedTopic);
                    
                    currentTopicLabel.Text = ($"{selectedTopic}");

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
   
        private void BtCreateTopic_Click(object sender, EventArgs e)
        {
            var FmCreateTopic = new FmCreateTopic();
            FmCreateTopic.ShowDialog();               
        }
     
        private void BtEditTopic_Click(object sender, EventArgs e)
        {
            var FmEditTopic = new FmEditTopic();
            FmEditTopic.ShowDialog();
            try
            {
                if (FmEditTopic.DialogResult == DialogResult.OK)
                {
                    string selectedTopicName = FmEditTopic.GetTopicName();
                    Console.WriteLine(selectedTopicName);

                    string topic = (selectedTopicName);

                   // topicManager.DeleteTopic(topic);
                    TopicList.Items.Remove(topic);
                }
                else if (FmEditTopic.DialogResult == DialogResult.Yes)
                {
                    
                    Topic chosenTopic = FmEditTopic.GetSelectedTopic();
                    string oldTopicName = chosenTopic.GetTopicName();
                    string newTopicName = FmEditTopic.GetNewTopicName();

                    
                    topicManager.EditTopic(chosenTopic, newTopicName);
                    TopicList.Items.Remove(oldTopicName);
                    TopicList.Items.Add(newTopicName);
                    currentTopic = chosenTopic.GetTopicName();
                    Console.WriteLine("this is a test"+ currentTopic);
                    currentTopicLabel.Text = ($"{currentTopic}");


                }
                else
                {
                    Console.WriteLine("Edit/Delete Action Cancelled");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtEditCards_Click(object sender, EventArgs e)
        {
            var FmEditCard = new FmEditCard();
            if (!FmEditCard.IsDisposed)
            {      
                FmEditCard.ShowDialog();
            }
         
        }

        private void BtAddCards_Click(object sender, EventArgs e)
        {
            
            if (topicsFromTopicManager.Count == 0)
            {
                MessageBox.Show("No Topics, Create a topic and come back", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                
            }
            else
            {
                var FmAddCard = new FmAddCard();
                FmAddCard.ShowDialog();
            }
           
        }

        private void BtConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmed!");
            this.Close();
        }


        private void BtBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TopicList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                optionsContextMenuStrip.Show(this, e.Location); // Display the context menu at the mouse cursor location.
            }
        }
    }
}
