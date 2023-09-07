using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment2_1.Listing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Assignment2_1
{
    public partial class Form1 : Form
    {
        //making new list collections/arrays to store listing items
        private List<Marketplace> marketplaces = new List<Marketplace>();
        private List<Property> properties = new List<Property>();
        private List<Car> car = new List<Car>();

        //these will be used for number validation
        private double num = -1;
        private int numInt = -1;

        public Form1()
        {
            InitializeComponent();

            //auto check general/marketplace on start
            generalcheck.Checked = true;

            //text styles
            name.Font = new Font(name.Font, FontStyle.Bold);
            name.Font = new Font(name.Font.FontFamily, 15, name.Font.Style);
            name2.Font = new Font(name2.Font, FontStyle.Bold);
            name2.Font = new Font(name2.Font.FontFamily, 25, name2.Font.Style);


            //All pre-added listings
            Marketplace newListing = new Marketplace("Listing to Delete");
            newListing.ListingTitle = "Test Listing";
            newListing.ListingPrice = 100;
            newListing.Condition = "Used";
            marketplaces.Add(newListing);

            Marketplace newListing2 = new Marketplace("Gaming Monitor");
            newListing2.ListingTitle = "New in box";
            newListing2.ListingPrice = 125;
            newListing2.Condition = "New";
            marketplaces.Add(newListing2);

            Marketplace newListing3 = new Marketplace("iPad Case");
            newListing3.ListingTitle = "Bought new for $100 a year ago";
            newListing3.ListingPrice = 50;
            newListing3.Condition = "Used";
            marketplaces.Add(newListing3);

            Marketplace newListing4 = new Marketplace("Wii Motion Plus Remote");
            newListing4.ListingTitle = "Sold my Wii so no longer needed";
            newListing4.ListingPrice = 60;
            newListing4.Condition = "Used";
            marketplaces.Add(newListing4);

            Marketplace newListing5 = new Marketplace("Windows 11 Pro License Key");
            newListing5.ListingTitle = "My PC already has it";
            newListing5.ListingPrice = 99;
            newListing5.Condition = "New";
            marketplaces.Add(newListing5);



            Car newListingCar = new Car("Listing to Delete");
            newListingCar.ListingTitle = "Test Listing";
            newListingCar.ListingPrice = 100;
            newListingCar.Condition = "Used";
            car.Add(newListingCar);

            Car newListingCar2 = new Car("ABC123");
            newListingCar2.ListingTitle = "BMW 325ti Compact A 2002";
            newListingCar2.ListingPrice = 5000;
            newListingCar2.Condition = "Used";
            car.Add(newListingCar2);

            Car newListingCar3 = new Car("DEF456");
            newListingCar3.ListingTitle = "Honda Accord 2002";
            newListingCar3.ListingPrice = 2000;
            newListingCar3.Condition = "Used";
            car.Add(newListingCar3);

            Car newListingCar4 = new Car("GHI789");
            newListingCar4.ListingTitle = "BMW 320i 2000";
            newListingCar4.ListingPrice = 1500;
            newListingCar4.Condition = "Used";
            car.Add(newListingCar4);

            Car newListingCar5 = new Car("JKL420");
            newListingCar5.ListingTitle = "Volvo XC90 2005";
            newListingCar5.ListingPrice = 6000;
            newListingCar5.Condition = "Used";
            car.Add(newListingCar5);



            Property newListingProp1 = new Property("Hamilton", 2, "Springfield");
            newListingProp1.ListingTitle = "Bungalow";
            newListingProp1.ListingPrice = 1000000;
            properties.Add(newListingProp1);

            Property newListingProp2 = new Property("Auckland", 1, "Albany");
            newListingProp2.ListingTitle = "Flat";
            newListingProp2.ListingPrice = 950000;
            properties.Add(newListingProp2);

            Property newListingProp3 = new Property("Tauranga", 3, "Pyes Pa");
            newListingProp3.ListingTitle = "Family Home";
            newListingProp3.ListingPrice = 1900000;
            properties.Add(newListingProp3);

            Property newListingProp4 = new Property("Rotorua", 1, "Rotovegas");
            newListingProp4.ListingTitle = "Condo";
            newListingProp4.ListingPrice = 860000;
            properties.Add(newListingProp4);

            Property newListingProp5 = new Property("Greymouth", 2, "Cobden");
            newListingProp5.ListingTitle = "Beachside Holiday Home";
            newListingProp5.ListingPrice = 1200000;
            properties.Add(newListingProp5);
        }

        //runs when form is loaded
        private void FlickOff_Load(object sender, EventArgs e)
        {
            //clear listbox
            display.Items.Clear();
            //autoadd general listings
            LoadMarket();
        }

        //runs when the corresponding button is clicked
        private void general_Click(object sender, EventArgs e)
        {
            display.Items.Clear();
            LoadMarket();
            //ensures general check is clicked in add listings
            generalcheck.Checked = true;
        }

        private void motors_Click(object sender, EventArgs e)
        {
            display.Items.Clear();
            LoadCar();
            motorscheck.Checked = true;
        }

        private void property_Click(object sender, EventArgs e)
        {
            display.Items.Clear();
            LoadPlace();
            propcheck.Checked = true;
        }


        //delete
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (display.SelectedIndex != -1) 
            {
                // Display a confirmation prompt
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Check if the selected item is in the marketplace list
                    string selectedListing = display.SelectedItem.ToString();
                    Marketplace itemToDelete = marketplaces.FirstOrDefault(m => m.MarketplaceInfo() == selectedListing);

                    // Code to check where it is stored, so it can be deleted from the correct list
                    if (itemToDelete != null)
                    {
                        // If item exists, then delete from marketplace
                        marketplaces.Remove(itemToDelete);
                        display.Items.RemoveAt(display.SelectedIndex);
                        MessageBox.Show("Listing has been deleted from marketplace.");
                    }
                    else
                    {
                        // Check if the selected item is in the car list
                        Car itemToDelete2 = car.FirstOrDefault(c => c.CarListingInfo() == selectedListing);
                        if (itemToDelete2 != null)
                        {
                            car.Remove(itemToDelete2);
                            display.Items.RemoveAt(display.SelectedIndex);
                            MessageBox.Show("Listing has been deleted from cars.");
                        }
                        else
                        {
                            // Check if the selected item is in the properties list
                            Property itemToDelete3 = properties.FirstOrDefault(p => p.PropertyListingInfo() == selectedListing);
                            if (itemToDelete3 != null)
                            {
                                properties.Remove(itemToDelete3);
                                display.Items.RemoveAt(display.SelectedIndex);
                                MessageBox.Show("Listing has been deleted from properties.");
                            }
                            else
                            {
                                MessageBox.Show("Listing doesn't exist?");
                            }
                        }
                    }

                }
                else
                {
                    // If the user selects "No" or closes the prompt, do nothing
                }
            }
        }

        //when method is called, loop through and display what is in the list
        private void LoadMarket()
        {

            //change name title
            name.Text = "General Listings";

            //clear any previous in listbox
            display.Items.Clear();

            foreach (Marketplace marketplace in marketplaces)
            {
                display.Items.Add(marketplace.MarketplaceInfo());
            }
        }

        private void LoadCar()
        {
            //change name title
            name.Text = "Car Listings";

            //clear any previous in listbox
            display.Items.Clear();

            foreach (Car car in car)
            {
                display.Items.Add(car.CarListingInfo());
            }
        }

        private void LoadPlace()
        {
            //change name title
            name.Text = "Property Listings";

            //clear any previous in listbox
            display.Items.Clear();

            foreach (Property prop in properties)
            {
                display.Items.Add(prop.PropertyListingInfo());
            }

        }

        //submit button for general listings
        private void gensubmit_Click(object sender, EventArgs e)
        {
            //validate all fields have been completed
            if (string.IsNullOrEmpty(DescBox.Text) || string.IsNullOrEmpty(TitleBox.Text) || string.IsNullOrEmpty(PriceBox.Text))
            {
                MessageBox.Show("Please fill in the form.");
            }
            else
            {
                // Retrieve the input
                Marketplace newListingCustom = new Marketplace(DescBox.Text);
                newListingCustom.ListingTitle = TitleBox.Text;
                //validate if a number has been entered into where it is numbers only
                if (!double.TryParse(PriceBox.Text, out num))
                {
                    MessageBox.Show("Enter a correct price.");
                }
                else
                {
                    //if number is in fact a number, then convert
                    newListingCustom.ListingPrice = Convert.ToDouble(PriceBox.Text);

                    //check which condition
                    if (usedbutton.Checked)
                    {
                        newListingCustom.Condition = "Used";

                        //add listing into general/marketplace
                        MessageBox.Show($"You have added: \n{newListingCustom.MarketplaceInfo()}");
                        marketplaces.Add(newListingCustom);

                        //loop through list and display
                        LoadMarket();
                    }
                    else if (newbutton.Checked)
                    {
                        newListingCustom.Condition = "New";

                        //add listing into general/marketplace
                        MessageBox.Show($"You have added: \n{newListingCustom.MarketplaceInfo()}");
                        marketplaces.Add(newListingCustom);

                        //loop through list and display
                        LoadMarket();
                    }
                    else { MessageBox.Show("Please select a condition."); }                
                }
            }
        }

        //submit button for cars
        private void carsubmit_Click(object sender, EventArgs e)
        {
            //ensure all fields have been filled
            if (string.IsNullOrEmpty(CarReg.Text) || string.IsNullOrEmpty(TitleCar.Text) || string.IsNullOrEmpty(PriceCar.Text))
            {
                MessageBox.Show("Please fill in the form.");
            }
            else 
            {
                // Retrieve the input
                Car newListingCarCustom = new Car(CarReg.Text);
                newListingCarCustom.ListingTitle = TitleCar.Text;

                //make sure numbers have been entered where numbers are only allowed
                if (!double.TryParse(PriceCar.Text, out num))
                {
                    MessageBox.Show("Enter a correct price.");
                }
                else
                {
                    //convert
                    newListingCarCustom.ListingPrice = Convert.ToDouble(PriceCar.Text);

                    //new or used check
                    if (usedcar.Checked)
                    {
                        newListingCarCustom.Condition = "Used";

                        //add to cars listing
                        MessageBox.Show($"You have added: \n{newListingCarCustom.CarListingInfo()}");
                        car.Add(newListingCarCustom);

                        //loop through car list and display
                        LoadCar();
                    }
                    else if (newcar.Checked)
                    {
                        newListingCarCustom.Condition = "New";

                        //add to cars listing
                        MessageBox.Show($"You have added: \n{newListingCarCustom.CarListingInfo()}");
                        car.Add(newListingCarCustom);

                        //loop through car list and display
                        LoadCar();
                    }
                    else { MessageBox.Show("Please select a condition."); }
                }
            }
        }

        //submit for properties
        private void propsubmit_Click(object sender, EventArgs e)
        {
            //validate number for bedrooms FIRST
            if (!int.TryParse(Numbeds.Text, out numInt))
            {
                MessageBox.Show("Enter a correct bedroom number.");
            }
            else
            {
                // Retrieve the input in constructor after validation
                Property newListingPropCustom = new Property(CityBox.Text, Convert.ToInt32(Numbeds.Text), Suburb.Text);
                newListingPropCustom.ListingTitle = Address.Text;

                //validate number price
                if (!double.TryParse(PriceProp.Text, out num))
                {
                    MessageBox.Show("Enter a correct price.");
                }
                else
                {
                    newListingPropCustom.ListingPrice = Convert.ToDouble(PriceProp.Text);

                    //ensure all fields are filled
                    if (string.IsNullOrEmpty(CityBox.Text) || string.IsNullOrEmpty(Numbeds.Text) || string.IsNullOrEmpty(Suburb.Text) || string.IsNullOrEmpty(Address.Text) || string.IsNullOrEmpty(PriceProp.Text))
                    {
                        MessageBox.Show("Please fill in the form.");
                    }
                    else
                    {
                        //add
                        MessageBox.Show($"You have added: \n{newListingPropCustom.PropertyListingInfo()}");
                        properties.Add(newListingPropCustom);

                        //loop through property list and display
                        LoadPlace();
                    }
                }
            } 
        }

        //locations for input field groups
        private void AdjustGroupBoxPositions()
        {
            generalinput.Location = new Point(38, 110);
            carinput.Location = new Point(38, 110);
            propertyinput.Location = new Point(38, 110);
        }

        //runs when the check has been changed
        private void generalcheck_CheckedChanged(object sender, EventArgs e)
        {
            //make all inputs but general invisible
            generalinput.Visible = true;
            carinput.Visible = false;
            propertyinput.Visible = false;

            //location
            AdjustGroupBoxPositions();

            LoadMarket();
        }

        private void motorscheck_CheckedChanged(object sender, EventArgs e)
        {
            
            generalinput.Visible = false;
            carinput.Visible = true;
            propertyinput.Visible = false;
            AdjustGroupBoxPositions();
            LoadCar();  
        }

        private void propcheck_CheckedChanged(object sender, EventArgs e)
        {
            generalinput.Visible = false;
            carinput.Visible = false;
            propertyinput.Visible = true;
            AdjustGroupBoxPositions();
            LoadPlace();
        }
    }
}
