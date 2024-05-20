namespace TerminalCurrencyManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] money = { "USD", "RUB", "TRY" };
            double[] rates = { 1.7000, 0.0187, 0.0527 };
            int i = 0,j=0;
            string selected,ratecode;
            bool k = false;
            int idx = 0;
            double result = 0;
            double amount = 0;

            while (true)
            {


                Console.WriteLine("Hansi emeliyyati icra etmek isteyirsiniz?(show,find,calculate,exit)");
                selected = Console.ReadLine();
                if (selected == "exit")
                {
                    break;
                }
                else if (selected == "show")
                {
                    i = 0;
                    while (i < money.Length)
                    {
                        Console.WriteLine(money[i] + "-" + rates[i]);
                        i++;
                    }
                }
                else if (selected == "find")
                {
                    Console.WriteLine("Valyutani daxil edin.(USD,RUB,TRY)");
                    ratecode = Console.ReadLine();
                    k = false;
                    i = 0;
                    while (i < money.Length)
                    {
                        if (ratecode == money[i])
                        {
                            k = true;
                            idx = i;
                            break;
                        }
                        i++;
                    }
                    if (k)
                    {
                        Console.WriteLine(money[idx] + "-" + rates[idx]);
                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz Valyuta sistemde movcud deyil");
                        
                    }
                }
                else if(selected=="calculate")
                {
                    Console.WriteLine("Meblegi daxil edin");
                    amount = double.Parse(Console.ReadLine());
                    Console.WriteLine("Valyutani daxil edin.(USD,RUB,TRY)");
                    ratecode = Console.ReadLine();
                    k = false;
                    i = 0;
                    while (i < money.Length)
                    {
                        if (ratecode == money[i])
                        {
                            k = true;
                            idx = i;
                            break;
                        }
                        i++;
                    }
                    if (k)
                    {
                        result = amount / rates[idx];
                        Console.WriteLine(result + " " + money[idx]);
                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz Valyuta sistemde movcud deyil");

                    }


                }
                else {
                    Console.WriteLine("Duzgun emeliyyat daxil edin");
                        }
               
            }
        }
    }
}