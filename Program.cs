namespace ConsoleApp10
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our car store");
            int Action = ChooseAction();
            while(Action != 0)
            {
                Console.WriteLine("you choosed " + Action);
                switch (Action)
                {
                    case 1:
                        Console.WriteLine("you choosed to add car to the inventory");
                        string CarMake = " ";
                        string CarModel = " ";
                        int CarPrice = 0;

                        Console.WriteLine("enter the car model");
                        CarMake=   Console.ReadLine();
                        Console.WriteLine("enter the car make");
                         CarModel =  Console.ReadLine();
                        Console.WriteLine("enter the car price");
                        CarPrice = int.Parse(Console.ReadLine());

                        Car newcar = new Car(CarMake, CarModel, CarPrice);
                        Store st = new Store();
                        st.ShoppingList.Add(newcar);

                       
                            break;

                }


                Action = ChooseAction();
            }
            
 
            Car c3 = new Car();

            Store s1 = new Store();


        }
        
        public static int ChooseAction()
        {
            
                int Choice = 0;
                Console.WriteLine("choose 0 to quit the program, 1 to add car to inventory, 2 to add car to the cart , 3 to checkout");
                Choice = int.Parse(Console.ReadLine());
            return Choice;
            
        }

       
    }
}