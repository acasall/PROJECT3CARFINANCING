using System;
using System.Collections.Generic;
using System.IO; //lets us read in data from external files
using System.Windows.Forms;

namespace PROJECT3CARFINANCING
{
    public partial class MainForm : Form
    {
        Dictionary<string, int> carPrice = new Dictionary<string, int>();
        string[] costData;
        //dict stores values in key, value pairs
        public MainForm()
        {
            InitializeComponent();
            GetData();
            rd1.Checked = true; //makes a default selection for this button
            cmbCar.SelectedItem = "Sonata"; //default again
        }

        public void GetData()
        {
            string price;
            string[] pricedata;

            //Create a StreamReader to read data from the "Carpricedata.txt" file
            StreamReader data = new StreamReader("Carpricedata.txt");

            // Iterate through the file until the end is reached
            while (data.EndOfStream == false)
            {
                price = data.ReadLine();
                //MessageBox.Show(price); Note: It works 

                // Split the "price" string into an array using a comma as the delimiter
                pricedata = price.Split(',');

                // Store the data from the "pricedata" array in the "carPrice" dictionary
                carPrice[pricedata[0]] = int.Parse(pricedata[1]);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty; //clears name 
            txtAge.Text = string.Empty; //clears age
            txtInitialPay.Text = string.Empty; //clears initial payment amount
            cmbCar.Text = string.Empty; //clears selection of car type
            cmbCar.SelectedIndex = 0;
            lstMonthly.Items.Clear(); //clears the list box
            rd1.Checked = false; rd2.Checked = false; rd3.Checked = false; //deselects the radio buttons

        }

        private void tbCarPurchase_Click(object sender, EventArgs e)
        {
            
        }

        private void btnShowPay_Click(object sender, EventArgs e)
        // calculates and displays payment information based on user inputs
        {
           string selection = cmbCar.Text;
           double monthyInterestRate;         
           double carSelection;
           int downPayment;
            double annualInterestRate = .07;
           int loanTermMonths = 24;
           int.TryParse(txtInitialPay.Text, out downPayment);
           double totalCarPrice;
           double carTypePrice = 0.0;
            double carPrices = 0.0;

            if (rd2.Checked)
            {
                carTypePrice = 1.2;
            }

            else if (rd3.Checked)
            {
                carTypePrice = 1.3;
            }

            if (carPrice.ContainsKey(selection))
            {
                totalCarPrice = carPrice[selection] * carTypePrice;
            }
            else
            {
                MessageBox.Show("Car not found in the dictionary.");
                return; // Exit the event handler if the selected car is not found in the dictionary
            }

            carPrices = carPrice [selection] * carTypePrice;
            double monthlyInterestRate = annualInterestRate / 12;
            double loanAmount = carPrices - downPayment;
            lstMonthly.Items.Clear();

            while (loanAmount > 0)
            {
                double monthlyPayment = (loanAmount * monthlyInterestRate) / (1 - Math.Pow(1 + monthlyInterestRate, -loanTermMonths));

                // Display the monthly payment in the list box
                lstMonthly.Items.Add("Payments: " + monthlyPayment.ToString("C"));

                // Update the loan amount 
                loanAmount -= monthlyPayment;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add validation to verify if the file exists.
            StreamReader data = new StreamReader("p3purchasesmade.txt");
            string line;

            lstPrevPurchases.Items.Add("Existing purchases");

            while (data.EndOfStream == false)
            {
                line = data.ReadLine();
                lstPrevPurchases.Items.Add(line);
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            // Check if all the necessary fields are filled out
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtInitialPay.Text) || string.IsNullOrWhiteSpace(cmbCar.Text) ||
                (!rd1.Checked && !rd2.Checked && !rd3.Checked))
            {
                // Display in messagebox
                MessageBox.Show("Please fill out all required fields");
                return;
            }

            //Accept the user inputs (Name, age, car selected, model type, down payment)
            //Write this data to an external file
            string name = txtName.Text; //gets the name
            int age;
            int.TryParse(txtAge.Text, out age); //parses the age
            string carSelection = cmbCar.Text; //gets the car selection
            int intDownPay;
            int.TryParse(txtInitialPay.Text, out intDownPay); //parses the down payment
            string modelType; //determines the model type based on what radio button is checked
            if (rd1.Checked)
            {
                modelType = "Basic";
            }

            else if (rd2.Checked)
            {
                modelType = "Hybrid";
            }

            else
            {
                modelType = "Sport";
            }

            //writes data as formatted into a file
            using (StreamWriter writer = new StreamWriter("p3purchasesmade.txt", append: true))
            {
                writer.WriteLine("Name: " + name + " " + "Age: " + age + " " + "Selection: " + carSelection + " " + "Model: " + modelType + " " + "Initial Down Payment: " + intDownPay);
            }

         
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            {
                
                StreamReader data = new StreamReader("p3purchasesmade.txt");
                string line;

                //Displays history of purchases onto the 2nd tab in a listbox
                lstPrevPurchases.Items.Add("Previous purchases");

                while (data.EndOfStream == false)
                {
                    line = data.ReadLine();
                    lstPrevPurchases.Items.Add(line);
                }
            }
        }
    }
}
