namespace Car_List
{
    public class Car
    {
        //Variables which start with car are properties of the car class
        //Variables which start with new are arguments the constructor will pass to the class upon instantiation. newMake == carMake, for example
        private string carMake;
        private string carModel;
        private int carYear;
        private double carPrice;
        private bool carNew;

        //This will be our static variable to count the number of instances
        private static int numberOfCars;

        //This is the constructor we will use to define the class.
        //newNew is a ridiculous variable name and I refuse to change it, fight me
        public Car()
        {
            numberOfCars++;
        }
        public Car(string newMake, string newModel, int newYear, double newPrice, bool newNew)
        {
            carMake = newMake;
            carModel = newModel;
            carYear = newYear;
            carPrice = newPrice;
            carNew = newNew;
            numberOfCars++;
        }

        //Public methods for accessing the properties of the car
        //much like the new prefix for constructing the class, we will use get to access all of the properties
        //These functions are all the same, they return a variable of the property type they're getting with the same value
        public string getMake()
        {
            return carMake;
        }
        public string getModel()
        {
            return carModel;
        }
        public string getYear()
        {
            return carYear.ToString();
        }
        public double getPrice()
        {
            return carPrice;
        }
        public bool getNew()
        {
            return carNew;
        }
        //This returns the number of cars
        public static int GetNumberOfCars()
        {
            return numberOfCars;
        }

        //These public methods can be used to set all of the properties
        public void setMake(string newMake)
        {
            carMake = newMake;
        }
        public void setModel(string newModel)
        {
            carModel = newModel;
        }
        public void setYear(int newYear)
        {
            carYear = newYear;
        }
        public void setPrice(double newPrice)
        {
            carPrice = newPrice;
        }
        public void setNew(bool newNew)
        {
            carNew = newNew;
        }
    }
}
