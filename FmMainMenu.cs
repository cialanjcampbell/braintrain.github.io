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
    public partial class FmMainMenu : Form
    {
        private TopicManager tManager = new TopicManager();
        private List<Topic> topicsFromTopicManager = new List<Topic>();
        public FmMainMenu()
        {
            this.Icon = Properties.Resources.favicon;
            InitializeComponent();          
        }     
        private void BtStart_Click(object sender, EventArgs e)
        {//Displays a new instannce of the Quiz form to the user
            var FmQuiz = new FmRevision();
            FmQuiz.ShowDialog();
        }
        private void BtOptions_Click(object sender, EventArgs e)
        { //Displays a new instannce of the Options form to the user
            topicsFromTopicManager = tManager.GetTopics();

            if (topicsFromTopicManager.Count() == 0)
            {
                MessageBox.Show("No Topics, Create a topic", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FmCreateTopic fmCreateTopic = new FmCreateTopic();
                fmCreateTopic.ShowDialog();
            }
            else
            {
                var FmOptions = new FmOptions();
                FmOptions.ShowDialog();
            }
            
        
        } 
        private void BtStatistics_Click(object sender, EventArgs e)
        { //Displays a new instannce of the Statistics form to the user
            var FmStatistics = new FmStatistics();
            FmStatistics.ShowDialog();
        }   
        private void BtQuit_Click(object sender, EventArgs e)
        { // Terminates The Program
            Application.Exit();
        }     
        private void BtInfo_Click(object sender, EventArgs e)
        {// Displays Useful Information to the User
            var FmInformation = new FmInformation();
            FmInformation.ShowDialog();
        }      
    }
}
