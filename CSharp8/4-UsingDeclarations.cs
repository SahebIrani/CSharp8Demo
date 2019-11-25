using System.IO;

namespace CSharp8
{
    public static class UsingDeclarationsDemo
    {
        public static int ConvertFiles()
        {
            int output = 0;

            using StreamReader inputFile = new StreamReader(@"D:\Demos\TestFile.txt");
            using StreamWriter outputFile = new StreamWriter(@"D:\Demos\OutputFile.txt");

            using (StreamReader inputFile2 = new StreamReader(@"D:\Demos\TestFile.txt"))
            {
                using StreamWriter outputFile2 = new StreamWriter(@"D:\Demos\OutputFile.txt");
                string line2;
                while ((line2 = inputFile2.ReadLine()) != null)
                {
                    outputFile2.WriteLine(line2);
                    output += 1;
                }
            }

            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                outputFile.WriteLine(line);
                output += 1;
            }

            return output;
        }
    }
}
