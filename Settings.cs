using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuizNea
{
    public class Settings
    {
        private string currentTopic { get; set; }
        private Flashcard recentleyDeletedFlashcard { get; set; }
        private FilePathManager pathManager = new FilePathManager();
        private string filePath;

        public Settings()
        {
            // set to a default value 
            this.filePath = pathManager.GetAppSettingsFilePath();
            this.currentTopic = "Default";
        }
        public string GetSettingsFromFile()
        {
            this.currentTopic = pathManager.ReadCurrentTopicFromFile();
            return currentTopic;
        }

        public string GetCurrentTopic()
        {
            return currentTopic;
        }
        public string SetCurrentTopic(string selectedTopic)
        {
            currentTopic = selectedTopic;
            return currentTopic;
        }
        public void SetCurrentTopicAsNull()
        {
            pathManager.ResetCurrentTopic();
        }
        public Flashcard GetRecentDelFlashcard()
        {     
            recentleyDeletedFlashcard = pathManager.ReadRecentDelFlashcardFromFile();
            Console.WriteLine(recentleyDeletedFlashcard.GetFlashCardFace());
            return recentleyDeletedFlashcard;
        }
        public Flashcard SetRecentDelFlashcard(Flashcard flashcard)
        {
            recentleyDeletedFlashcard = flashcard;
            pathManager.WriteRecentDelFlashcardToFile(flashcard);
            return recentleyDeletedFlashcard;
        }
    }
}
