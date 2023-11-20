using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuizNea
{
    public class MemoryMaestro
    {
        private List<Flashcard> allFlashcards = new List<Flashcard>(); 
        private List<Flashcard> unmemorisedFlashcards = new List<Flashcard>();         
        private List<Flashcard> memorisedFlashcards = new List<Flashcard>();
        private FlashCardManager flashcardManager;
        private Flashcard previousFlashcard;
          
        public MemoryMaestro(FlashCardManager flashManager)
        {         
            allFlashcards = flashManager.GetFlashcards();                      

            this.flashcardManager = flashManager;
        }
        public int GetUnmemorisedFlashcardsCount()
        {
            int unmemorisedFlashcardsCount = unmemorisedFlashcards.Count();
            return unmemorisedFlashcardsCount;
        }
        
        public void ScheduleFlashcards()
        {//add flashcards scheduled for review today or earlier into unmemorised flashcards
            DateTime today = DateTime.Now.Date;

            foreach (Flashcard flashcard in allFlashcards)
            {
                Console.WriteLine("Today"+ flashcard);             

                if (flashcard.GetNextReviewDate() <= today)
                {            
                    flashcard.SetNextReviewDate(DateTime.Today.Date); // Automatically Bring Forward any Flashcards leftover from previous days
                    unmemorisedFlashcards.Add(flashcard);
                }
            }           
        }

        private float ComputeFlashcardScore(Flashcard flashcard)
        {
            float score = (flashcard.getAvgRecallRate());

            Console.WriteLine($"{score}");
            return score;
        }    
        
        public Flashcard GetNextFlashcard()
        {
            // lambda expression                    //LINQ query
            // This code will retrieve the next flashcard based on the computed score
            Flashcard nextFlashcard = unmemorisedFlashcards
                .Where(card => card != previousFlashcard)// Ensure it's not the previous card
                .OrderBy(card => ComputeFlashcardScore(card))
                .FirstOrDefault();
     
            previousFlashcard = nextFlashcard;//Update previousFlashcard

            return nextFlashcard;                      
        }

        public Flashcard RemoveFlashcardfromQueue(Flashcard flashcard)
        {
            Flashcard removedFlashcard = flashcard;
            memorisedFlashcards.Add(removedFlashcard);
            unmemorisedFlashcards.Remove(removedFlashcard);

            return removedFlashcard;
        }

        public int CalculateProgress(int itemsForReview)
        {// Updates the Progress bar, by giving it an integer value representing percentage of completion
         // Percentage Completion = ((reviewed cards / outstanding cards) * 100)
            Console.WriteLine($"unmenorised cards count: {itemsForReview}");
            int a = memorisedFlashcards.Count();
            int b = itemsForReview;

            double c = Math.Round(((double)a/b),2);
       
            int progress = (int)(c * 100);
          
            return progress;
        }
    }
}
