using System;
using System.IO;

namespace IoFileStreams
{
    class BinaryReaderExample
    {
        const string fileName = "AppSettings.dat";
        public static void WriteDefaultValues()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(1.250F);
                writer.Write(@"c:\Temp");
                writer.Write(10);
                writer.Write(true);
            }
        }

        public static void DisplayValues()
        {
            if (File.Exists(fileName))
            {
                try
                {
                    float aspectRatio;
                    string tempDirectory;
                    int autoSaveTime;
                    bool showStatusBar;

                    BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open));
                    aspectRatio = reader.ReadSingle();
                    tempDirectory = reader.ReadString();
                    autoSaveTime = reader.ReadInt32();
                    showStatusBar = reader.ReadBoolean();

                    Console.WriteLine("Aspect ratio set to: " + aspectRatio);
                    Console.WriteLine("Temp directory is: " + tempDirectory);
                    Console.WriteLine("Auto save time set to: " + autoSaveTime);
                    Console.WriteLine("Show status bar: " + showStatusBar);
                }
                catch
                {

                }
            }
        }

        private void Writer()
        {
            try
            {
                Console.Out.WriteLine("Preparing to Write ...");

                //Open a FileStream on the file "aboutme"
                FileStream fout = new FileStream("aboutme.txt", FileMode.OpenOrCreate,
                FileAccess.Write, FileShare.ReadWrite);

                //Create a BinaryWriter from the FileStream
                BinaryWriter bw = new BinaryWriter(fout);

                //Create some arbitrary variables
                string name = "Ilyas";
                int age = 20;
                double height = 5.11;
                bool single = true;
                char gender = 'M';

                //Write the values to file
                bw.Write(name);
                bw.Write(age);
                bw.Write(height);
                bw.Write(single);
                bw.Write(gender);

                //Close the file and free resources
                bw.Close();
                Console.WriteLine("Data Written!");
                Console.WriteLine();
            }

            catch (IOException e)
            {
                Console.WriteLine("An IO Exception Occurred :" + e);
            }
        }

        private void Reader()
        {
            try
            {
                Console.WriteLine("Preparing to Read ...");

                //Open a FileStream in Read mode
                FileStream fin = new FileStream("aboutme.txt", FileMode.Open,
                FileAccess.Read, FileShare.ReadWrite);

                //Create a BinaryReader from the FileStream
                BinaryReader br = new BinaryReader(fin);

                //Seek to the start of the file
                br.BaseStream.Seek(0, SeekOrigin.Begin);

                //Read from the file and store the values to the variables
                string name = br.ReadString();
                int age = br.ReadInt32();
                double height = br.ReadDouble();
                bool single = br.ReadBoolean();
                char gender = br.ReadChar();

                //Display the data on the console
                Console.WriteLine("Name :" + name);
                Console.WriteLine("Age :" + age);
                Console.WriteLine("Height :" + height);
                Console.WriteLine("Single? :" + single);
                Console.WriteLine("Gender M/F:" + gender);

                //Close the stream and free the resources
                br.Close();
                Console.WriteLine("Data Read!");
            }

            catch (IOException e)
            {
                Console.WriteLine("An IO Exception Occurred :" + e);
            }
        }
    }
}

