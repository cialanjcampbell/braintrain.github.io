using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuizNea
{
    public class TopicManager
    {
        private FilePathManager pathManager = new FilePathManager();
        private List<Topic> topics = new List<Topic>();
        private string location;
       
        public TopicManager()
        {
            this.location = pathManager.GetAppDataPath();

            topics = pathManager.ReadTopicsFromFile();
        }
        public List<Topic> GetTopics()
        {
            topics = pathManager.ReadTopicsFromFile();
            return topics;
        }
        public Topic GetTopicByName(string name)
        {
            return topics.FirstOrDefault(topic => topic.GetTopicName() == name);
        }
              
        public void CreateTopic(string topicName)
        {
            pathManager.CreateTopicFile(location, topicName);
        }

        public void EditTopic(Topic topic, string newTopicName)
        {
            string topicName = topic.GetTopicName();
            pathManager.EditTopicFile(topicName, newTopicName);
        }
        public void DeleteTopic(Topic topic)
        {
            pathManager.DeleteTopicFromFile(location, topic.GetTopicName());
        }
    }
}
