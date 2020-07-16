using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_List
{

    public partial class frm : Form
    {
        //This list of cars will hold all of our cars as one big happy family aww isn't that wholesome <3
        List<Car> listOfCars = new List<Car>();

        //both of these variables represent years of pandemic hahahahaha I'm not crying you're crying
        const int FIRST_YEAR = 1920;
        const int CURRENT_YEAR = 2020;

        public frm()
        {
            InitializeComponent();
        }
        //This method will check if the user's input is valid, if there is any car selected in the listview, and decide what to do based on that
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Checks that the input validation returns true
            if (InputValidation())
            {
                //Here we add a car via the constructor defined in the Car.cs script which defines the Car class
                //We have to convert some of these. I'd rather do that here than within the Car class because that script is super clean right now
                //My form scripts always become messy, but right now Car.cs is virgin snow falling for the first time, I will protect it from corruption
                Car newCar = new Car(lstMake.Text, txtModel.Text,int.Parse(lstYear.Text),Convert.ToDouble(txtPrice.Text),chkNew.Checked);
                //We check if there is no current item selected on the list, if so we add it to the list
                if (lvwCars.FocusedItem == null)
                {
                    //Pass the new car to the function which adds cars to both the list of cars and the listView of cars
                    ModifyList(newCar, true);
                }
                else
                {
                    ModifyList(newCar, false);
                }
                ResetForm();
            }
        }

        //When the form loads we're going to run the function to set the combo box to the range of dates so I don't have to put them in manually.
        public void frm_Load(object sender, EventArgs e)
        {
            SetComboBoxes();
        }

        //This function will set the combo box list of the years at runtime because that's better than adding 100 years in sequence and I'm lazy
        public void SetComboBoxes()
        {
            //This for loop will add years to the box until it hits the current year
            //Every use of the CURRENT_YEAR constant curses us to yet another month of 2020
            for(int counter = FIRST_YEAR; counter <= CURRENT_YEAR;counter++)
            {
                lstYear.Items.Add(counter);
            }
        }

        //This will validate the information the user has entered into the form to make sure that it's all valid before accepting input
        public bool InputValidation()
        {
            bool inputValid = true;

            txtDetails.Text = String.Empty;
            //Validate the Model txtbox first
            if(txtModel.TextLength > 20 || txtModel.Text == null)
            {
                txtDetails.Text += "Oof, car name too long, please try something 20 characters or less." + Environment.NewLine;
                inputValid = false;
            }

            if(lstMake.SelectedItem == null)
            {
                txtDetails.Text += "Please select a make." + Environment.NewLine;
                inputValid = false;
            }

            if(txtModel.Text == "")
            {
                txtDetails.Text += "Please input a model.";
                inputValid = false;
            }

            //I don't think this is strictly necessary since the list box won't display any invalid options as it is defined by a range
            if(lstYear.SelectedIndex == null)
            {
                txtDetails.Text += "Year of manufacture must be between " + FIRST_YEAR + " and " + CURRENT_YEAR + ", please try again." + Environment.NewLine;
                inputValid = false;
            }

            if(double.TryParse(txtPrice.Text,out double price))
            {
                if(price <= 0)
                {
                    txtDetails.Text += "Price must be a positive value. Cannot be 0 or negative." + Environment.NewLine;
                    inputValid = false;
                }
            }
            else
            {
                txtDetails.Text += "Price must be a numerical value." + Environment.NewLine;
                inputValid = false;
            }

            return inputValid;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //This function will create a listview item 
        //and then depending on the toAdd boolean, add it to the end of the list (if true) or modify the selected item (if false)
        private void ModifyList(Car newCar,bool toAdd)
        {
            Console.WriteLine("ModifyList called");
            //Condition for whether or not you're Adding or modifying the list
            if (toAdd == true)
            {
                Console.WriteLine("ModifyList with add");
                listOfCars.Add(newCar);
            }
            else
            {
                Console.WriteLine("ModifyList with change");
                listOfCars[lvwCars.FocusedItem.Index] = newCar;
            }
            Console.WriteLine("Step before RenderList");
            RenderList();
        }

        private void lvwCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            //idk why this event is here we'll see?
        }

        private void RenderList()
        {
            Console.WriteLine("RenderList called");
            lvwCars.Items.Clear();
            Console.WriteLine("List cleared");
            for (int currentCar = 0;currentCar < listOfCars.Count; currentCar++)
            {
                Console.WriteLine("For loop running");
                ListViewItem nextCar = new ListViewItem(listOfCars[currentCar].getNew()? "New":"Used");
                nextCar.Checked = listOfCars[currentCar].getNew();
                nextCar.SubItems.Add(listOfCars[currentCar].getMake());
                nextCar.SubItems.Add(listOfCars[currentCar].getModel());
                nextCar.SubItems.Add(listOfCars[currentCar].getYear());
                nextCar.SubItems.Add(listOfCars[currentCar].getPrice().ToString());
                lvwCars.Items.Add(nextCar);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            lstMake.SelectedItem = null;
            lstYear.SelectedItem = null;
            txtDetails.Text = "Input reset.";
            txtModel.Text = String.Empty;
            txtPrice.Text = String.Empty;
        }
    }
}
