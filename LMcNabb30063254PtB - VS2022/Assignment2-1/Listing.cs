using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment2_1.Listing;

namespace Assignment2_1
{
    //base class for holding all universal fields
    public class Listing
    {
        //fields
        private int code;
        protected string fullinfo;
        public static Random gen = new Random();

        //properties
        public string ListingTitle { get; set; }
        public string Condition { get; set; }
        public double ListingPrice { get; set; }

        //used to store codes for validation. hashset chosen over list so it prohibits duplicates
        private static HashSet<int> existingCodes = new HashSet<int>();

        // Constructor
        public Listing()
        {
            code = GenerateUniqueCode();
        }

        //code validation to ensure no duplicates
        private int GenerateUniqueCode()
        {
            int temp;
            while (true)
            {
                //the code below commented out was used with the autoadded listings to ensure there are no duplicates, left it in as a comment just in case
                // temp = gen.Next(0, 16);

                //validate
                temp = gen.Next(100000, 999999);
                if (!existingCodes.Contains(temp))
                {
                    existingCodes.Add(temp);
                    return temp;
                }
            }
        }

        //derived classes -  hold their own unique fields and methods
        public class Property : Listing
        {
            //properties
            public string city { get; set; }
            public int numbedrooms { get; set; }
            public string suburb { get; set; }

            //constructor
            public Property(string c, int numbed, string suburb)
            {
                city = c;
                numbedrooms = numbed;
                this.suburb = suburb;
            }

            //method
            public string PropertyListingInfo()
            {
                return code + ", " + ListingTitle + ", " + numbedrooms + ", " + city + ", " + suburb + ", $" + ListingPrice;
            }
        }

        public class Car : Listing
        {
            //properties
            public string carrego { get; set; }

            //constructor
            public Car(string reg)
            {
                carrego = reg;
            }

            //method
            public string CarListingInfo()
            {
                return code + ", " + ListingTitle + ", " + Condition + ", " + carrego + ", $" + ListingPrice;
            }
        }

        public class Marketplace : Listing
        {
            //field
            private string description;

            //constructor
            public Marketplace(string desc)
            {
                description = desc;
            }

            //method
            public string MarketplaceInfo()
            {
                return code + ", " + ListingTitle + ", " + Condition + ", " + description + ", $" + ListingPrice;
            }
        }
    }
}
