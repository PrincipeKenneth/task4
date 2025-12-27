// See https://aka.ms/new-console-template for more information
class task4
{
    public static float Addtwonums(float a,float b)
    {
        return a+b;
    }
    public static float Subtwonums(float a,float b)
    {   
        return a-b;       
    } 
    public static float Multwonums(float a,float b)
    {   
        return a*b;       
    } 
    public static float Divtwonums(float a,float b)
    {   
        return a/b;       
    } 

    public static void ask()
    {
        System.Console.WriteLine("1 - Addition");
        System.Console.WriteLine("2 - Subtraction");
        System.Console.WriteLine("3 - Multipliation");
        System.Console.WriteLine("4 - Division");
        int option = 0;
        option= int.Parse(Console.ReadLine());
        System.Console.Write("Enter Value 1: ");
        float val1 =int.Parse(Console.ReadLine());
        System.Console.Write("Enter Value 2: ");
        float val2 =int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1: System.Console.WriteLine($"{val1} + {val2} = {Addtwonums(val1,val2)}");
            break;
            case 2: System.Console.WriteLine($"{val1} - {val2} = {Subtwonums(val1,val2)}");
            break;
            case 3: System.Console.WriteLine($"{val1} * {val2} = {Multwonums(val1,val2)}");
            break;
            case 4: System.Console.WriteLine($"{val1} / {val2} = {Divtwonums(val1,val2)}");
            break;
        }
    }
    static void main(string[] args) 
    {
    
        bool repeat = true;
        while (repeat)
        {
            ask();
            System.Console.WriteLine("do you want to contine (Y/N)?");
            string continueProg = Console.ReadLine();
            if (continueProg.ToUpper().Equals("N"))
            {
                repeat = false;
            }
            else
            {
                repeat = true;
            }

        }
    }   
    
}
