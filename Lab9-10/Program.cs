using System;
using System.Collections.Generic;

namespace Lab9_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> inputData = new List<float>();

            bool moreData = true;
            while (moreData)
            {
                // Prompt the user to enter the data 
                Console.Write("Enter a value for the distribution.");
                float number;

                while (!float.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("Please enter a number.");
                }

                // add the data to the list in the distribution 
                inputData.Add(number);

                // Prompt user to enter another data 
                string inputString;
                do
                {
                    Console.Write("Key in another data? Y/N.");
                    inputString = Console.ReadLine().ToUpper();
                } while (!(inputString == "Y" || inputString == "N"));

                // Stop data entry loop once the user Enters No. 
                if (inputString == "N")
                {
                    moreData = false;
                }
            }

            // convert the List to array to be processed by the Skewness object 
            float[] myData = inputData.ToArray();

            // Instantiate an object of the skewness class. 
            Skewness mySkewness = new Skewness(myData);

            // Print the results of methods inherited from the Statistics class 
            Console.WriteLine("Mean of Distribution: " + mySkewness.Mean.ToString("F2"));

            Console.WriteLine("Median of Distribution: " + mySkewness.Median.ToString("F2"));


            Console.WriteLine("Mode of Distribution: " + mySkewness.Mode.ToString("F2"));

            Console.WriteLine("Standard Deviation of Distribution: " + mySkewness.StandardDeviation.ToString("F2"));

            // Print the results of methods in Skewness class 
            Console.WriteLine("Pearson Mode Skewness: " + mySkewness.PearsonModeSkewness.ToString("F2"));


            Console.WriteLine("Pearson Median Skewness: " + mySkewness.PearsonMedianSkewness.ToString("F2"));


        }
    }
}
