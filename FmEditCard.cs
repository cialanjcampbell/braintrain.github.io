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
    public partial class FmEditCard : Form
    {
        private FlashCardManager flashcardManager = new FlashCardManager();
        private Flashcard editFlashcard;
        private Flashcard currentFlashcard;
        private Settings settings = new Settings();
        private string currentTopic { get; set; }
        private int selectedFlashcardIndex = -1;
        private List<Flashcard> flashcards = new List<Flashcard>();
        private List<Flashcard> scheduledFlashcards { get; set; }

        public FmEditCard()
        {
            this.Icon = Properties.Resources.favicon;
            InitializeComponent();

            settings.GetSettingsFromFile();
            currentTopic = settings.GetCurrentTopic();
            this.Text = (currentTopic);


            flashcardManager.ReadFromFile();
            flashcards = flashcardManager.GetFlashcards();

            PopulateListBox();


            TranscribeFlashcard();
        }
        private void PopulateListBox()
        {
            foreach (Flashcard item in flashcards)
            {
                FlashcardListBox.Items.Add(item.GetFlashCardFace());
            }
        }
        private void TranscribeFlashcard()
        {// gets and displays the current flashcard.

            //Display the first flashcard in the list as default
         
                try
                {
                    if (selectedFlashcardIndex == -1)
                    {
                        currentFlashcard = flashcards[0];
                        selectedFlashcardIndex = 0;
                    Console.WriteLine("this is a massive test " + currentFlashcard.GetFlashCardFace());
                    }
                    else
                    {
                        currentFlashcard = flashcards[selectedFlashcardIndex];
                    }
                    //update controls
                    richTextBox1.Text = currentFlashcard.GetFlashCardFace();
                    richTextBox2.Text = currentFlashcard.GetFlashCardBack();

                    avgRecallRateLabel.Text = ($"recall rate: {currentFlashcard.getAvgRecallRate().ToString()}");
                    repetitionHistoryLabel.Text = ($"No. Reps: {currentFlashcard.getRepetitionHistory().ToString()}");
                    reviewDateLabel.Text = ($"Next Review: {currentFlashcard.GetNextReviewDate().ToShortDateString()}");
                    reviewIntervalTextBox.Text = currentFlashcard.GetReviewInterval().ToString();
                    difficultyScoreTextBox.Text = currentFlashcard.getDifficultyScore().ToString();

                    // excpetion - if there is no text in text box     

                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error has occured" + ex.Message);
                    //MessageBox.Show("Topic Empty, add some flashcards and come back.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }          
        }


        private void BtEditCard_Click(object sender, EventArgs e)
        {// edit the chosen flashcards text
            editFlashcard = flashcards[selectedFlashcardIndex];

            Flashcard oldFlashcard = editFlashcard;

            string newFace = richTextBox1.Text;
            string newBack = richTextBox2.Text;
            int newInterval = (Int32.Parse(reviewIntervalTextBox.Text));
            double newDifficultyScore = (double.Parse(difficultyScoreTextBox.Text));

            Console.WriteLine("this is a test" + newFace);
            flashcardManager.EditFlashcard(oldFlashcard, newFace, newBack, newInterval, newDifficultyScore);
            flashcardManager.UpdateToFile();

            FlashcardListBox.Items.Clear();
            PopulateListBox();

            TranscribeFlashcard();
            
            MessageBox.Show("Your Flashcard has Been Updated!");
            
        }
        private void BtDeleteCard_Click(object sender, EventArgs e)
        {
            Flashcard flashcardToDelete = flashcards[selectedFlashcardIndex];
            FlashcardListBox.Items.Remove(flashcardToDelete.GetFlashCardFace());
            richTextBox1.Clear();
            richTextBox2.Clear();

            if (flashcardToDelete != null)
            {
                settings.SetRecentDelFlashcard(flashcardToDelete);
                flashcardManager.DeleteFlashcard(flashcardToDelete);
                flashcardManager.UpdateToFile();
                
            }  
        }
        private void BtUndo_Click(object sender, EventArgs e)
        {
            Flashcard flashcard = settings.GetRecentDelFlashcard();
            flashcardManager.addFlashcards(flashcard);
        }

        private void FlashcardListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FlashcardListBox != null && FlashcardListBox.SelectedItem != null)
            {
                try
                {
                    selectedFlashcardIndex = FlashcardListBox.SelectedIndex;
                    GetSelectedIndex(selectedFlashcardIndex);

                    currentFlashcard = flashcards[selectedFlashcardIndex];

                    string Face = flashcards[selectedFlashcardIndex].GetFlashCardFace();
                    string Back = flashcards[selectedFlashcardIndex].GetFlashCardBack();

                    richTextBox1.Text = Face;
                    richTextBox2.Text = Back;

                    avgRecallRateLabel.Text = ($"recall rate: {flashcards[selectedFlashcardIndex].getAvgRecallRate().ToString()}");
                    repetitionHistoryLabel.Text = ($"No. Reps: {flashcards[selectedFlashcardIndex].getRepetitionHistory().ToString()}");
                    reviewDateLabel.Text = ($"Next Review: {flashcards[selectedFlashcardIndex].GetNextReviewDate().ToShortDateString()}");
                    reviewIntervalTextBox.Text = flashcards[selectedFlashcardIndex].GetReviewInterval().ToString();
                    difficultyScoreTextBox.Text = flashcards[selectedFlashcardIndex].getDifficultyScore().ToString();
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("An error has occured" + ex.Message); 
                }
            }
            else
            {
                
                MessageBox.Show("Choose a Flashcard");
            }                   
        }

        private int GetSelectedIndex(int inx)
        {
            int index = inx;

            return index;            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ScheduledFlashcardsListBox.Items.Clear();
            DateTime selectedDate = monthCalendar1.SelectionStart;
            List<Flashcard> allFLashcards = flashcardManager.GetFlashcards();
            List<Flashcard> flashcardsForSelectedDate = new List<Flashcard>();

            foreach (Flashcard flashcard in allFLashcards)
            {
                if (flashcard.GetNextReviewDate() == selectedDate.Date)
                {
                    flashcardsForSelectedDate.Add(flashcard);
                }
            }
          
            foreach (Flashcard scheduledFlashcard in flashcardsForSelectedDate)
            {
                ScheduledFlashcardsListBox.Items.Add(scheduledFlashcard.GetFlashCardFace());
            }                     
        }
        private void EditScheduleCalender_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = EditScheduleCalender.SelectionStart;
            Flashcard flashcardToBeRescheduled = flashcards[selectedFlashcardIndex];

            flashcardToBeRescheduled.SetNextReviewDate(selectedDate.Date);

            reviewDateLabel.Text = ($"Next Review: {flashcards[selectedFlashcardIndex].GetNextReviewDate().ToShortDateString()}");
            flashcardManager.UpdateToFile();
            MessageBox.Show("FLashcard Succesfully Rescheduled");
            
        }    
        private void BtResetMetrics_Click(object sender, EventArgs e)
        {
            Flashcard flashcardToReset = flashcards[selectedFlashcardIndex];

            flashcardToReset.ResetAllMetrics();

            flashcardManager.UpdateToFile();
            TranscribeFlashcard();
        }
        private void BtBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FmEditCard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                EditCardMenuStrip.Show(this, e.Location); // Display the context menu at the mouse cursor location.
            }
        }

        
    }
}
