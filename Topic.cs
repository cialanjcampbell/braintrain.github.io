using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNea
{
    public class Topic
    {
        private string name;
        private List<Flashcard> topicFlashcards;

        public Topic(string name, List<Flashcard> topicFlashcards)
        {
            this.name = name;
            this.topicFlashcards = topicFlashcards;
        }

        //getters
        public string GetTopicName()
        {
            return name;
        }
        public List<Flashcard> GetTopicFlashcards()
        {

            return topicFlashcards;
        }
        public string SetTopicName(string newName)
        {
            name = newName;
            return name;
        }
    }
}
