internal class Program
{
    private static void Main(string[] args)
    {
       
        Console.Write("Type your age:");
        
        byte age = Convert.ToByte(Console.ReadLine());


        if (age > 18)
        {
            Console.WriteLine("Access granted");
        }
        else if (age < 15)
        {
            Console.WriteLine("Access denied");
        }
        else if (age >= 15 && age <= 18)
        {
            Console.WriteLine("Do you have parental consent? (yes / no)");
            if (Console.ReadLine() == "yes") 
            {
                Console.WriteLine("Access granted");
            }
            else 
            { 
                Console.WriteLine("Access denied"); 
            }
               
           
        }
        Console.ReadKey();
    }
}