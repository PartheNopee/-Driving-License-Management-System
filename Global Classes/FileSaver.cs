using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace DVLDApp
{
    public class FileSaver
    {

         static string GuidGenerator()
        {
            //every and each metos should do only one job and this will  generate the GUIDs!!

            Guid newGuid = Guid.NewGuid();

            return newGuid.ToString();



        }



        public static string path = "A:\\Dev\\VisualStudio\\DVLDApp\\CredFile.txt";

        public static void ClearCred()
        {

            try
            {
                File.WriteAllText(path, string.Empty);

            }
            catch(Exception ex) { }




        }
        public static bool SaveCred(string Username,string Password)
        {
            bool isSaved = false;

            if (!File.Exists(FileSaver.path))
            {
                return false;
            }
            else
            {
                isSaved = true;
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    sw.WriteLine(Username);
                    sw.WriteLine(Password);
                }
            }
            return isSaved; 
        }


       public static string GenerateNewFileName(string SourceFile)
        {
            //this method will generate the full new file name !
            string filename = SourceFile;
            FileInfo Fi = new FileInfo(filename);
            string ext = Fi.Extension;

            return GuidGenerator() + ext;


        }


 
        public static bool SaveImageToProjectFolder(ref string SourcePath)
        {
            string ImagesFolder = @"A:\Dev\VisualStudio\DVLDApp\PeoplePictures";

            string fullPath = Path.Combine(ImagesFolder, GenerateNewFileName(SourcePath));

            // Check if the folder exists, create it if not
            if (!Directory.Exists(ImagesFolder))
            {
                Directory.CreateDirectory(ImagesFolder);
            }

            // Destination file path

            // Copy the image to the destination path
            try
            {
                File.Copy(SourcePath, fullPath, true);
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Return the path where the image is saved
            SourcePath = fullPath;

            return true;
        }




        //public static void LoadImageToPictureBox(PictureBox pic, string FilePath)
        //{
        //    // Get the project directory (the root where your solution is)

        //    // Define the folder where images are saved
        //     // Get the full path of the image
        //    string FullPath = Path.Combine(ImagesFolder, FilePath);

        //    if (File.Exists(FullPath))
        //    {
        //        using (var fs = new FileStream(FullPath, FileMode.Open, FileAccess.Read))
        //        {
        //            pic.Image = Image.FromStream(fs);
        //        }
        //    }
        //    else
        //    {
        //        pic.Image = null;  // Clear the PictureBox if the image doesn't exist
        //    }
        //}

         


    }
}
