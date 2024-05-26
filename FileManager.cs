using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;
using System.ComponentModel;


namespace TicTacToe
{
    /// <summary>
    /// Creates, reads, cleans, writes in a file.
    /// </summary>
    internal class FileManager
    {
        //constructor with directories
        string filePath;


        /// <summary>
        /// Initialize the file if it was not initialized before. Sets file path to the class's fields.
        /// </summary>
        /// <param name="path">File path where it is needed to create a file.</param>
        public FileManager(string path) {

            filePath = path;
            //WriteLine("No scores");
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, string.Empty);
                MessageBox.Show("File created at: " + filePath);
            }




        }



        /// <summary>
        /// Opens the file: reads the text.
        /// </summary>
        /// <returns></returns>
        public string Open()
        {
            string text = string.Empty;
            try
            {
                StreamReader reader = new StreamReader(filePath);
                text = reader.ReadToEnd();
                reader.Close();
            } 
            catch(Exception e)
            {
                MessageBox.Show("Cannot open the file");
            }
            finally
            {
                
            }

            return text;

        }

        /// <summary>
        /// Writes line and saves it.
        /// </summary>
        /// <param name="text">Text to add.</param>
        public void WriteLine(string text) 
        { 
            //StreamWriter writer = new StreamWriter(filePath);
            try
            {
                File.AppendAllText(filePath, text + Environment.NewLine); //writer.WriteLine(text);
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Cannot write or save the file.");
            }
            finally
            {

            }

        
        
        
        
        }


        /// <summary>
        /// Clears the file.
        /// </summary>
        public void Clear() 
        {
            //clears file

            try {

                File.WriteAllText(filePath, string.Empty);

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cannot clean the file. Try again.");
            }
            finally {
                
            }


            

        }



    }
}
