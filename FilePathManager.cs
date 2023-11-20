using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuizNea
{
    public class FilePathManager
    {
        private string basePath;
        private string settingsPath;
        private string settingsFileLocation;
        private string currentTopic { get; set; }

        public FilePathManager()
        {           
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // Combine the path with  application's folder name 
            string myAppDataPath = Path.Combine(appDataPath, "BrainTrain");
            string myAppSettingsDataPath = Path.Combine(appDataPath, "BrainTrainSettings");
            string myAppSettingsFilePath = Path.Combine(myAppSettingsDataPath, $"Settings.txt");

            string defaultTopicFilePath = Path.Combine(myAppDataPath, $"Default.txt");

            // Create the directory if it doesn't exist
            if (!Directory.Exists(myAppDataPath))
            {
                Directory.CreateDirectory(myAppDataPath);        
            }
            if (!Directory.Exists(myAppSettingsDataPath))
            {
                Directory.CreateDirectory(myAppSettingsDataPath);
            }
            if (!File.Exists(myAppSettingsFilePath))
            {
                File.Create(myAppSettingsFilePath);
            }
            if (!File.Exists(defaultTopicFilePath))
            {
                File.Create(defaultTopicFilePath);
            }

            this.settingsFileLocation = myAppSettingsFilePath;
            this.basePath = myAppDataPath;

            this.settingsPath = myAppSettingsDataPath;

        }

        public string GetTopicFilePath(string fileName)
        {
            string location = System.IO.Path.Combine(basePath, fileName);
            string filePath = (location + ".txt");

            return filePath;
        }
        public string GetAppDataPath()
        {
            string adp = basePath;

            return adp;
        }
        public string GetAppSettingsDataPath()
        {// Returns the Directory where "Settings" are stored to 
            string asdp = settingsPath;
            return asdp;
        }
        public string GetAppSettingsFilePath()
        {// Returns the File Path where settings are stored
            string asfp = settingsFileLocation;
            return asfp;
        }

        // Methods To Handle Topic Files
        public void CreateTopicFile(string location, string topicName)
        {
            try
            {
                // Combine the directory path and the topic name to create the file path
                string fileToCreate = Path.Combine(location, $"{topicName}.txt");

                // check if the specified file path already exists
                if (File.Exists(location))
                {
                    Console.WriteLine($"A file for the topic '{topicName}' already exists.");
                    return;  // Do not overwrite the existing file
                }

                // Create a new text file for the topic
                File.Create(fileToCreate).Close(); // Close the file stream

                Console.WriteLine($"Topic '{topicName}' created at: {location}");

            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public List<Topic> ReadTopicsFromFile()
        {// gets the topics
             List<Topic> topics = new List<Topic>();
             List<string> fileNames = new List<string>();

             // Get an array of file names in the directory     
             string[] files = Directory.GetFiles(GetAppDataPath());

             // Add all the topic names from "files" array to fileNames list
             foreach (string filePath in files)
             {
                 string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
                 fileNames.Add(fileNameWithoutExtension);
             }

             // Add all names stored in fileNames list to the topics list field.
             foreach (string topicName in fileNames)
             {
                 List<Flashcard> flashcardsInTopic = new List<Flashcard>();
                 flashcardsInTopic = GetTopicFlashcards(topicName);

                 Topic topic = new Topic(topicName, flashcardsInTopic);
                 topics.Add(topic);
             }
             // Now, the 'fileNames' list contains the names of all files in the specified directory
             Console.WriteLine("File Names in the Directory:");
             foreach (Topic topic in topics)
             {
                 Console.WriteLine("items in topic list: " + topic.GetTopicName());

             }
            return topics;
        }
        public void EditTopicFile(string topicName, string newTopicName)
        {

            string appPath = GetAppDataPath();

            string currentFilePath = Path.Combine(appPath, $"{topicName}.txt");

            string newFilePath = Path.Combine(appPath, $"{newTopicName}.txt");

            try
            {
                File.Move(currentFilePath, newFilePath);
                Console.WriteLine("File renamed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public void DeleteTopicFromFile(string location, string topicName)
        {
            try
            {
                // Combine the directory path and the topic name to create the file path
                string fileToDelete = Path.Combine(location, $"{topicName}.txt");

                // check if the specified file path already exists
                if (File.Exists(fileToDelete))
                {
                    // Delete the file
                    File.Delete(fileToDelete);
                    Console.WriteLine($"Topic '{topicName}' deleted.");
                }
                else
                {
                    Console.WriteLine($"The topic '{topicName}' does not exist.");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occured: " + ex.Message);
            }
        }

        public List<Flashcard> GetTopicFlashcards(string topicName)
        {
            List<Flashcard> topicFlashcards = new List<Flashcard>();
            string filePath = GetTopicFilePath(topicName);
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
                            topicFlashcards.Add(flashcard);
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


            return topicFlashcards;
        }




       
        public void WriteCurrentTopicToFile(string CurrentTopic)
        { // Writes "CurrentTopic" to a text document in the "Settings" File for future usage.        
            string newCurrentTopic = CurrentTopic;
            File.WriteAllText($@"{settingsPath}\Settings.txt", newCurrentTopic);
        }
        public string ReadCurrentTopicFromFile()
        {// Reads the "CurrentTopic" from its designated file, so it can be returned.
            string testCurrentTopic = File.ReadAllText(settingsFileLocation);
            currentTopic = testCurrentTopic;
            return currentTopic;
        }
        public void ResetCurrentTopic()
        {
            
            string filePath = ($@"{settingsPath}\Settings.txt");

            try
            {
                // Open the file in write mode and truncate its content
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    // Truncate the file by setting its length to 0
                    fs.SetLength(0);
                }

                Console.WriteLine("File content deleted successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    
        public void WriteRecentDelFlashcardToFile(Flashcard flashcard)
        {
            string BinPath = ($@"{settingsPath}\Bin.txt");
            using (StreamWriter file = new StreamWriter(BinPath, true))
            {
                file.WriteLine(flashcard.storeInformation());
            }
        }
        public Flashcard ReadRecentDelFlashcardFromFile()
        {
            Flashcard flashcard = new Flashcard("","");
            string BinPath = ($@"{settingsPath}\Bin.txt");

            using (StreamReader reader = new StreamReader(BinPath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    Flashcard flash = new Flashcard("didnt", "load");
                    flashcard.retrieveInformation(line);
                    
                }
            }
            Console.WriteLine(flashcard.GetFlashCardFace());
            return flashcard; 
        }
    }
}
