using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {   //Initialize required paramters           
                var firstArg = string.Empty;
                var secondArg = string.Empty;
                string[] versionArgExamples = new string[] { "-v", "--v", "/v", "--version" };
                string[] sizeArgExamples = new string[] { "-s", "--s", "/s", "--size" };

                //Check for minimum 2 arguments
                if (args.Length < 2)
                {
                    Console.WriteLine("Required 2 arguments.");
                    return;
                }

                // Assign argument values
                firstArg = args[0];
                secondArg = args[1];

                //Main logic for getting version or size
                if (versionArgExamples.Contains(firstArg))
                {
                    FileDetails fileDetails = new FileDetails();
                    var versionstr = fileDetails.Version(secondArg);
                    Console.WriteLine(versionstr);
                }
                else if (sizeArgExamples.Contains(firstArg))
                {
                    FileDetails fileDetails = new FileDetails();
                    var sizestr = fileDetails.Size(secondArg);
                    Console.WriteLine(sizestr);
                } else {
                    Console.WriteLine("Please enter valid First argument");
                }

            }
            catch (Exception ex)
            {
                //Catche the Exception and Display Error message 
                Console.WriteLine("Something went wrong, Please see below Error message :\n");
                Console.WriteLine(ex.Message);
            }     
        }
    }
}
