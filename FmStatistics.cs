using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizNea
{
    public partial class FmStatistics : Form
    {
        private FlashCardManager cardManager = new FlashCardManager();
        private List<Flashcard> flashcards;
        private Settings settings = new Settings();
        private string currentTopic { get; set; }
        private List<DateTime> dateList;
        public FmStatistics()
        {
            this.Icon = Properties.Resources.favicon;
            InitializeComponent();

            PopulateFlashcards();
          
            PopulateStatistics();

            InitialiseStatisticsGraph();
            
        }
      
        public void PopulateStatistics()
        {
            int totalCards = cardManager.GetFlashcards().Count();
            totalCardsLabel.Text = totalCards.ToString();

            // Check if totalCards is zero before proceeding
            if (totalCards == 0)
            {
                MessageBox.Show("There are no flashcards available for statistics on this topic.");
                this.Close();
                return; // exit the method to prevent further execution
            }

            int[] interval = new int[totalCards];
            int[] diffScore = new int[totalCards];
            int[] recallRate = new int[totalCards];
            int[] repetitionHist = new int[totalCards];
            int[] succesfulRecalls = new int[totalCards];

            for (int i = 0; i < totalCards; i++)
            {
                interval[i] = flashcards[i].GetReviewInterval();
                diffScore[i] = (int)Math.Truncate(flashcards[i].getDifficultyScore());
                recallRate[i] = ((int)flashcards[i].getAvgRecallRate() * 100);
                repetitionHist[i] = flashcards[i].getRepetitionHistory();
                succesfulRecalls[i] = flashcards[i].getSuccesfullRecalls();
            }



            int intervalSum = CalculateArraySum(interval);
            double averageInterval = CalculateAverage(intervalSum, totalCards);
            avgReviewIntervalLabel.Text = averageInterval.ToString();

            int diffScoreSum = CalculateArraySum(diffScore);
            double averageDiffScore = CalculateAverage(diffScoreSum, totalCards);
            avgDifficultyScoreLabel.Text = averageDiffScore.ToString();

            int recallRateSum = CalculateArraySum(recallRate);
            double averageTopicRecallRate = CalculateAverage(recallRateSum, totalCards);
            avgRecallRateLabel.Text = (averageTopicRecallRate).ToString() + "%";

            int repetitionhistSum = CalculateArraySum(repetitionHist);
            double averageRepHist = CalculateAverage(repetitionhistSum, totalCards);
            AvgRepetitionsLabel.Text = averageRepHist.ToString();

            int succesfullRecallsSum = CalculateArraySum(repetitionHist);
            double averageSuccesfullRecalls = CalculateAverage(succesfullRecallsSum, totalCards);
            sucesfullRecallsLabel.Text = averageSuccesfullRecalls.ToString();
        }
        public void InitialiseStatisticsGraph()
        {
            settings.GetSettingsFromFile();
            currentTopic = settings.GetCurrentTopic();

            this.Text = ($"{currentTopic}, Statistics");
            chart1.ChartAreas[0].AxisY.Title = "No. Repetitions";
            chart1.ChartAreas[0].AxisX.Title = "Days";
            chart1.Series[0].LegendText = "Workload";


            int range = CalculateRepetitions(flashcards);
            int[] repetitionsPerDay = new int[range+1];

            for (int i = 1; i <= repetitionsPerDay.Length; i++)
            {
                repetitionsPerDay[i-1] = CalculateRepetitionsPerday(repetitionsPerDay, i);
            }
           
            chart1.Series[0].Points.Clear();
            for (int i = 1 ; i <= repetitionsPerDay.Length; i++)
            {
                chart1.Series[0].Points.AddXY(i, repetitionsPerDay[i - 1]);               
            }
        }

        public int CalculateRepetitionsPerday(int[] repetitionsPerDay, int day)
        {       
            int count = GetDateFrequency(day);
            
            return count;
        }
        public int GetDateFrequency(int day)
        {
            int count = 0;
            

            for (int i = 0; i < dateList.Count; i++)
            {
                int currentDayOrdinal = (dateList[i] - dateList.Min()).Days + 1;

                if (currentDayOrdinal == day)
                {
                    count++;
                }
                Console.WriteLine(count);            }

            return count;
        }
        public int CalculateRepetitions(List<Flashcard> flashcards)
        {// return reps for given day
            dateList = new List<DateTime>();

            foreach (Flashcard item in flashcards)
            {
                dateList.Add(item.GetNextReviewDate());

            }

            foreach (DateTime date in dateList)
            {
                Console.WriteLine(date.ToString());
            }
            dateList.Sort();

       
            TimeSpan range = dateList.Last() - dateList.First();
            
            Console.WriteLine("TimeSpane" + range);
            int rangeInDays = (int)range.TotalDays;
            if (rangeInDays == 0)
            {
                rangeInDays = 1;
            }
            Console.WriteLine($"Range in days: {rangeInDays} days");

            return rangeInDays;
        }
        public void PopulateFlashcards()
        {
            cardManager.ReadFromFile();
            flashcards = cardManager.GetFlashcards();
       
        }
       
        public int CalculateArraySum(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }
            Console.WriteLine("this is the sum: " + sum);
            return sum;
        }

        public double CalculateAverage(int sum, int count)
        {
            if (count == 0)
            {
                return 0;
            }
            
            return (double)sum / count;
        }
    }
}
