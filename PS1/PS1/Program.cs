using System;

namespace PS1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inFilePath = "PS1Q.csv";
            var outFilePath = "PS1Q_out.csv";
            RemoveVowelsNumbersAndSaveFile(inFilePath, outFilePath);

            /* Don't add any code here, add everything in RemoveVowelsNumbersAndSaveFile */
        }


        public static void RemoveVowelsNumbersAndSaveFile(string inFilePath, string outFilePath)
        {
            /* 
                You need to do the following:
                1. Read all text from the specified inFilePath (csv file)
                2. Find and remove all vowels from the csv file
                3. Find and remove all numbers from the csv file
                4. Save the file in the same format with file name as passed in outFilePath, ideally if you open this CSV file in excel it should work fine.

                Do note that there more than one way to do all of these steps, 
                it is possible to do something as small as 1 line, and several 30 lines :)
            */
        }

    }
}
