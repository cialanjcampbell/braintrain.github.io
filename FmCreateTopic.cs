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
    public partial class FmCreateTopic : Form
    {
        
        private TopicManager tManager;
        private List<Topic> topicsFromTopicManager { get; set; }
        public FmCreateTopic()
        {
            this.Icon = Properties.Resources.favicon;
            InitializeComponent();

            topicsFromTopicManager = new List<Topic>();

            tManager = new TopicManager();      

            topicsFromTopicManager = tManager.GetTopics();          

        }

        private void RbConfirm_Click(object sender, EventArgs e)
        {
           
            if (txtBoxTopicName.Text != string.Empty)
            {
                
                foreach (Topic item in topicsFromTopicManager)
                {
                    if (txtBoxTopicName.Text == item.GetTopicName())
                    {
                        MessageBox.Show("You cannot have Two topics with the same name!");                     
                        this.Close(); 
                        return;
                    }
                }
             
                string newTopic = txtBoxTopicName.Text;
                tManager.CreateTopic(newTopic);
                

                this.Close();
            }
            else
            {
                MessageBox.Show("You need to enter a topic name");
                this.Close();
            }
            
        }

        private void RbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
