using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace QuizNea
{
    public partial class FmRevision : Form
    {
        private MemoryMaestro mm;
        private FlashCardManager FlashcardManager;
        private Flashcard currentFlashcard;
        private Settings settings = new Settings();
        private string currentTopic { get; set; }   
        private int itemsForReview;

        public FmRevision()
        {
            this.Icon = Properties.Resources.favicon;
            InitializeComponent();     

            settings.GetSettingsFromFile();
            currentTopic = settings.GetCurrentTopic();
            this.Text = (currentTopic);        
            FlashcardManager = new FlashCardManager();
            FlashcardManager.ReadFromFile();

            BtRecalled.Hide();
            BtNotRecalled.Hide();

            mm = new MemoryMaestro(FlashcardManager);
            mm.ScheduleFlashcards();

            itemsForReview = mm.GetUnmemorisedFlashcardsCount();


            if (itemsForReview != 0)
            {
                NextCard();
            }
         
            else 
            {
                MessageBox.Show("you have zero cards for review");
                Application.Restart();           
            }
        }
     
        private void DisplayFlashcard(Flashcard currentFlashcard)
        {
            if (currentFlashcard != null)
            {
                try
                {
                    string face = currentFlashcard.GetFlashCardFace();
                    string back = currentFlashcard.GetFlashCardBack();

                    
                    TxtBoxAnswer.ForeColor = TxtBoxAnswer.BackColor;
                    TxtBoxQuestion.Text = (face);
                    TxtBoxAnswer.Text = (back);
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("error" + ex.Message);
                    //throw;
                }               
            }
            else
            {// if the currentFlashcard is null then the quiz must be complete, no more cards are in the queue
                progressBar.Value = 100;
                PlayCongratulationSound();
                MessageBox.Show("Congratulations, you have completed the quiz!");
                this.Close();
                
            }
            
        }

        //Button Methods
        private void BtRecalled_Click(object sender, EventArgs e)
        {         
            Button RecalledButton= (Button)sender;
            RecalledButton.FlatStyle = FlatStyle.Popup;

            BtShowAnswer.Show();
            BtRecalled.Hide();
            BtNotRecalled.Hide();

            PlayCorrectSound();

            this.currentFlashcard.CalculateDifficultyScore(true);
            this.currentFlashcard.CalculateNextReviewDate();
            this.currentFlashcard.UpdateRepetitionHistory();
            this.currentFlashcard.CalculateAvgRecallRate(true);

            FlashcardManager.UpdateToFile();


            mm.RemoveFlashcardfromQueue(this.currentFlashcard);


            /* 
             * TimeSpan timeElapsed = DateTime.Now - startTime;
             double totalSeconds = timeElapsed.TotalSeconds;
             MessageBox.Show($"{totalSeconds}");

             this.currentFlashcard.updateAvgRecallTime(totalSeconds);*/

            NextCard();
        }

        private void BtNotRecalled_Click(object sender, EventArgs e)
        {
            Button NotRecalledButton = (Button)sender;
            NotRecalledButton.FlatStyle = FlatStyle.Popup;

            BtShowAnswer.Show();
            BtRecalled.Hide();
            BtNotRecalled.Hide();
            

            PlayIncorrectSound();

            this.currentFlashcard.CalculateDifficultyScore(false);
            this.currentFlashcard.CalculateNextReviewDate();
            this.currentFlashcard.UpdateRepetitionHistory();
            this.currentFlashcard.CalculateAvgRecallRate(false);

            FlashcardManager.UpdateToFile();

            /* TimeSpan timeElapsed = DateTime.Now - startTime;
             double totalSeconds = timeElapsed.TotalSeconds;
             MessageBox.Show($"{totalSeconds}");

             this.currentFlashcard.updateAvgRecallTime(totalSeconds);*/
            // qm.AddToRecallReviewer(this.currentFlashcard);        
            mm.RemoveFlashcardfromQueue(this.currentFlashcard);
            NextCard();
            
        }       
        private void NextCard()
        {//Loads the next card in the Queue to the user, And Displasy the Question but Hides the Answer 
            this.currentFlashcard = mm.GetNextFlashcard();
            DisplayFlashcard(currentFlashcard);
            progressBar.Value = mm.CalculateProgress(itemsForReview);
        
        }
        private void BtShowAnswer_Click(object sender, EventArgs e)
        {//sets the forecolor (Texts colour) to default so that answer is displayed
            TxtBoxAnswer.ForeColor = TxtBoxQuestion.ForeColor;
            BtRecalled.Show();
            BtNotRecalled.Show();
            BtShowAnswer.Hide();

        }
        private void BtBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Sound Methods
        private void PlayCorrectSound()
        {
            SoundPlayer correctSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            correctSound.Play();
        }
        private void PlayIncorrectSound()
        {
            SoundPlayer incorrectSound = new SoundPlayer(@"c:\Windows\Media\Speech Misrecognition.wav");
            incorrectSound.Play();
        }
        private void PlayCongratulationSound()
        {
            SoundPlayer congratulationsSound = new SoundPlayer(@"C:\Windows\Media\Ring02.wav");
            congratulationsSound.Play();
        }

        private void TxtBox_EditAttempt(object sender, EventArgs e)
        {
            PlayIncorrectSound();
            MessageBox.Show("Editing is not allowed in this field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

  

    }
}
