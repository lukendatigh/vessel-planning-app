using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManningAlgorithm
{
    public class Methods
    {

        //Data Manipulation
        public class Data
        {
            public static void addSeafarer()
            {
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                Console.WriteLine("Select Rank");
                
            }
        }


        //Time Calculating Methods
        public class Time
        {
            //calculating the days left on board
            public static int calcLeave(Seafarer sailor)
            {
                int days = 0;
                return days;

            }

            


        }


        //Seafarer Actions
        public class SeafarerAction
        {
            public static void putOnBoard()
            {
                
            }

            public static void sendOnLeave()
            {
                
            }

        }




        //Others
        public class Just
        {
            //Finding Rank Type
            public static string whatRankType(string rank)
            {
                int location = 0;
                string rankType = null; 
                string[] ranks =
                {
                    "Master", "Chief Officer","Chief Engineer", "2nd Engineer", "Gas Engineer", "ETO",
                    "2nd Officer", "3rd Officer", "3rd Engineer", "4th Engineer",
                    "Bosun", "Able Seaman", "Ordinary Seaman", "Junior Ordinary Seaman",
                    "Machinist", "Oiler", "Trainee Oiler",
                    "Chief Cook", "2nd Cook", "Messman"
                };

                for (int i = 0; i < ranks.Length; i++)
                {
                    if (rank == ranks[i])
                        location = i;
                }

                if (location >= 0 && location <= 5)
                    rankType = "snr";
                if (location >= 6 && location <= 9)
                    rankType = "jnr";
                if (location >= 10 && location <= ranks.Length)
                    rankType = "rating";

                return rankType;
            }
        }


    }
}
