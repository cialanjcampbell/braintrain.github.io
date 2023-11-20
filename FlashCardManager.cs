using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuizNea
{
    public class FlashCardManager
    {
        private Settings settings = new Settings();
        private string currentTopic { get; set; }
        private FilePathManager pathManager = new FilePathManager();
        private List<Flashcard> flashcards = new List<Flashcard>();
        private string filePath;

        public FlashCardManager()
        {
            settings.GetSettingsFromFile();
            currentTopic = settings.GetCurrentTopic();

            this.filePath = pathManager.GetTopicFilePath($"{currentTopic}");

        }
        public List<Flashcard> GetFlashcards()
        {
            return this.flashcards;
        }
        public void addFlashcards(Flashcard flashcard)
        {
            flashcards.Add(flashcard);
        }
        public void CreateFlashcard(Topic selectedTopic, Flashcard flashcardToAdd)
        {// Add Flashcard to specified File Path
            string selectedTopicPath = pathManager.GetTopicFilePath(selectedTopic.GetTopicName());
            using (StreamWriter file = new StreamWriter(selectedTopicPath, true))
            {
                file.WriteLine(flashcardToAdd.storeInformation());              
            }
        }
        public void ReadFromFile()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;

                        while ((line = reader.ReadLine()) != null)
                        {
                            Flashcard flashcard = new Flashcard("didnt", "load");
                            flashcard.retrieveInformation(line);
                            this.flashcards.Add(flashcard);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist");
                    //this.currentTopic = settings.SetCurrentTopic("");

                }
            }
            catch (FileNotFoundException ex)
            {

                Console.WriteLine("an error has occured" + ex.Message);
            }

        }

        public void EditFlashcard(Flashcard flashcard, string newFace, string newBack, int newInterval, double newDifficultyScore)
        {
            flashcard.SetFace(newFace);
            flashcard.SetBack(newBack);
            flashcard.SetCustomInterval(newInterval);
            flashcard.SetCustomDifficultyScore(newDifficultyScore);
        }

        public void DeleteFlashcard(Flashcard flashcardToDelete)
        {//
            flashcards.Remove(flashcardToDelete);
        }
        public void UpdateToFile()
        { //save changes that are made by updating the file to reflect the list
            using (StreamWriter file = new StreamWriter(filePath))
            {
                foreach (Flashcard item in flashcards)
                {
                    file.WriteLine(item.storeInformation());
                }
            }
        }     
                           
    }
}
