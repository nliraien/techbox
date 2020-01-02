using System;
using System.IO;

namespace EventTryout
{
    class Program
    {
        static void Main(string[] args)
        {
            int foundFilesCount = 0;

            EventHandler<FileFoundArgs> onFileFound = (sender, eventArgs) =>
            {
                Console.WriteLine(eventArgs.FoundFileName);
                foundFilesCount++;

                if (foundFilesCount >= 2)
                {
                    eventArgs.CancelRequested = true;
                }
            };

            FileSearcher fileLister = new FileSearcher();
            fileLister.FileFound += onFileFound;
            fileLister.Search(@"C:\TEMP_ALLUSERS\AzureIcons", "*.*");

            FileSearcherEx fs2 = new FileSearcherEx();
            fs2.FileFound += onFileFound;
            fs2.Search(@"C:\TEMP_ALLUSERS\AzureIcons", "*.*");
        }
    }

    public class FileFoundArgs : EventArgs
    {
        public string FoundFileName { get; }
        public bool CancelRequested { get; set; }

        public FileFoundArgs(string fileName)
        {
            FoundFileName = fileName;
        }
    }

    public class FileSearcher
    {
        public event EventHandler<FileFoundArgs> FileFound;

        public void Search(string directory, string searchPattern)
        {
            foreach (var file in Directory.EnumerateFiles(directory, searchPattern))
            {
                var args = new FileFoundArgs(file);
                FileFound?.Invoke(this, args);

                if (args.CancelRequested)
                {
                    break;
                }
            }
        }
    }

    public class FileSearcherEx
    {
        private EventHandler<FileFoundArgs> fileFound;

        public event EventHandler<FileFoundArgs> FileFound
        {
            add
            {
                fileFound -= value;
                fileFound += value;
            }
            
            remove
            {
                fileFound -= value;
            }
        }

        public void Search(string directory, string searchPattern)
        {
            foreach (var file in Directory.EnumerateFiles(directory, searchPattern))
            {
                var args = new FileFoundArgs(file);
                fileFound?.Invoke(this, args);

                if (args.CancelRequested)
                {
                    break;
                }
            }
        }
    }
}
