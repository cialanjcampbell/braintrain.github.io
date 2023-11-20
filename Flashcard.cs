using System;

namespace QuizNea
{
    public class Flashcard
    {
        private string face;
        private string back;

        private float avgRecallRate;
        private int repetitionHistory;
        private DateTime nextReviewDate;
        private int reviewInterval;
        private int succesfullRecalls;
        private double difficultyScore;

        // class conctructor
        public Flashcard(string face, string back /*, bool recalled*/)
        {
            this.face = face;
            this.back = back;

            nextReviewDate = DateTime.Now.Date;
            reviewInterval = 1;
            difficultyScore = 2;

            succesfullRecalls = 0;
            avgRecallRate = 0;
            repetitionHistory = 0;
        }

        // getters 
        public string GetFlashCardFace()
        {
            return face;
        }
        public virtual string GetFlashCardBack()
        {
            return back;
        }
        public DateTime GetNextReviewDate()
        {
            return nextReviewDate;
        }
        public int GetReviewInterval()
        {
            return reviewInterval;
        }
        public int getSuccesfullRecalls()
        {
            return succesfullRecalls;
        }

        public int getRepetitionHistory()
        {
            return repetitionHistory;
        }
        public double getDifficultyScore()
        {

            return difficultyScore;
        }
        public float getAvgRecallRate()
        {
            return avgRecallRate;
        }
        public string SetFace(string editedFace)
        {
            string newFace = editedFace;
            face = newFace;

            return face;
        }
        public string SetBack(string editedBack)
        {
            string newBack = editedBack;

            back = newBack;
            return back;
        }

        public DateTime SetNextReviewDate(DateTime newDate)
        {
            nextReviewDate = newDate;
            return nextReviewDate;
        }

        public int SetCustomInterval(int customInterval)
        {
            int newCustomInterval = customInterval;
            reviewInterval = newCustomInterval;

            return reviewInterval;
        }
        public double SetCustomDifficultyScore(double customDiffScore)
        {
            double newCustomDiffScore = customDiffScore;
            difficultyScore = newCustomDiffScore;

            return difficultyScore;
        }
        public void ResetAllMetrics()
        {
            nextReviewDate = DateTime.Now.Date;
            reviewInterval = 1;
            difficultyScore = 2;

            succesfullRecalls = 0;
            avgRecallRate = 0;
            repetitionHistory = 0;
        }
        public int UpdateRepetitionHistory()
        {
            int tmp = repetitionHistory + 1;

            repetitionHistory = tmp;
            return tmp;
        }


        public float CalculateAvgRecallRate(bool recalled)
        {// Calculate the Average Recall Rate
            if (recalled == true)
            {
                succesfullRecalls = succesfullRecalls + 1;
            }

            float TmpAvg = (float)succesfullRecalls / (float)repetitionHistory;
            // double TmpAvg = avgRecallRate / repetitionHistory;
            Console.WriteLine("succesfull recalls: " + succesfullRecalls);
            Console.WriteLine("repetition History: " + repetitionHistory);
            avgRecallRate = TmpAvg;
            return (float)(TmpAvg);
        }
        public double CalculateDifficultyScore(bool recalled)
        {//Calculate the Difficulty Scrore of a card, (smaller difficulty score means harder flashcard)
            if (recalled == false && difficultyScore >= 2)
            {// if not recalled the flashcard DF decreases, reaching a minimum of 1
                difficultyScore -= 1;
                reviewInterval = 1;// the review interval is reset to default, to decrease time till next review
            }
            else if (recalled == true)
            {// if recalled the DF is Increased
                difficultyScore += 1;

            }

            return difficultyScore;
        }
        public int CalculateReviewInterval()
        {// Calculate the Interval between card review dates (in days)
            int roundedDiffScore = (int)Math.Round(difficultyScore);
            reviewInterval *= roundedDiffScore;
            if (reviewInterval > 365)
            {
                reviewInterval = 365;
            }
            return reviewInterval;
        }
        public DateTime CalculateNextReviewDate()
        {// Calculate the next review date, taking into account the current date and review interval(days between review)
            DateTime newNextReviewDate = nextReviewDate.AddDays(reviewInterval);

            nextReviewDate = newNextReviewDate;
            CalculateReviewInterval();

            return nextReviewDate;
        }


        public string storeInformation()
        {// Store the Infortion of a Given Flashcard inside of a string "information"                   
            string information = ($"{face}|{back}|{avgRecallRate}|{repetitionHistory}|{nextReviewDate}|{reviewInterval}|{succesfullRecalls}|{difficultyScore}");
            return information;
        }

        public void retrieveInformation(string info)
        {// Parse the string "Info", which is deliminated by the | symbol. 
            string[] components = (info.Split('|'));
            Console.WriteLine(components);
            face = components[0];
            back = components[1];
            avgRecallRate = float.Parse(components[2]);
            repetitionHistory = int.Parse(components[3]);
            nextReviewDate = DateTime.Parse(components[4]);
            reviewInterval = int.Parse(components[5]);
            succesfullRecalls = int.Parse(components[6]);
            difficultyScore = int.Parse(components[7]);
        }

    }
    class TrueFalseFlashcard : Flashcard
    {// Polymorphism, The "TrueFalseFlashcard" class inherits from its parent class "Flashcard"
     // Overide method used to get a bool value as the flashcard answer/back rather than a string
        private bool answer;
        public TrueFalseFlashcard(string question, bool answer)
            : base(question, answer.ToString())
        {

            this.answer = answer;
        }
        public override string GetFlashCardBack()
        {
            return base.GetFlashCardBack();
        }
    }
}
