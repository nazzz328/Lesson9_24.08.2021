using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Task 1\n");
            System.Console.WriteLine("Enter exchange rate for USD - SMN: ");
            double.TryParse(Console.ReadLine(), out double usd);
            System.Console.WriteLine("Enter exchange rate for EUR - SMN: ");
            double.TryParse(Console.ReadLine(), out double eur);
            System.Console.WriteLine("Enter exchange rate for RUB - SMN: ");
            double.TryParse(Console.ReadLine(), out double rub);
            Converter conv = new Converter(usd, eur, rub);
            conv.MethodConverter();
            System.Console.WriteLine();

            System.Console.WriteLine("Task 2\n");
            System.Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter last name:");
            string lastname = Console.ReadLine();
            System.Console.WriteLine("Enter one of the occupations below:\n 'Cashier', 'Operator', 'Head Operator', 'Engineer', 'Project Manager'");
            string occupation = Console.ReadLine();
            System.Console.WriteLine("Enter years of experience:");
            int experience = int.Parse(Console.ReadLine());
            Employee emp = new Employee(name, lastname, occupation, experience);
            emp.ShowInfo();


    {
    
    }
            
            

        }
    }

    public class Converter
    {

        public double usd;
        public double eur;
        public double rub;
        public Converter (double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public void MethodConverter ()
        {
        System.Console.WriteLine ("If you want to convert SMN to USD-EUR-RUB, press '1';\n If you want to convert USD to SMN, press '2';\n If you want to convert EUR to SMN, press '3';\n If you want to convert RUB to SMN, press '4'.\n");

        int selector = int.Parse(System.Console.ReadLine());
        double amountSMN;
        double amountUSD;
        double amountEUR;
        double amountRUB;

        if (selector == 1)

        {
        System.Console.WriteLine("Enter amount of SMN: ");
        amountSMN = double.Parse(Console.ReadLine());
        amountUSD = amountSMN/usd;
        amountEUR = amountSMN/eur;
        amountRUB = amountSMN/rub;
        System.Console.WriteLine($"USD: {Math.Round(amountUSD, 2)},\n EUR: {Math.Round(amountEUR, 2)},\n RUB: {Math.Round(amountRUB, 2)}.");
        }

        else if (selector == 2)

        {
        System.Console.WriteLine("Enter amount of USD: ");
        amountUSD = double.Parse(Console.ReadLine());
        amountSMN = amountUSD * usd;
        System.Console.WriteLine($"SMN: {Math.Round(amountSMN, 2)}."); 
        }

        else if (selector == 3)

        {
        System.Console.WriteLine("Enter amount of EUR: ");
        amountEUR = double.Parse(Console.ReadLine());
        amountSMN = amountEUR * eur;
        System.Console.WriteLine($"SMN: {Math.Round(amountSMN, 2)}."); 
        }

        else if (selector == 4)

        {
        System.Console.WriteLine("Enter amount of RUB: ");
        amountRUB = double.Parse(Console.ReadLine());
        amountSMN = amountRUB * rub;
        System.Console.WriteLine($"SMN: {Math.Round(amountSMN, 2)}."); 
        }

        else
        {
        System.Console.WriteLine("Error");
        }

        }
    
    }

    public class Employee
    {
    public string name;
    public string lastname;
    public string occupation;
    public int experience;

    public string[] occupations = new string[] {"Cashier", "Operator", "Head Operator", "Engineer", "Project Manager"};
    public int[] salary = new int[] {2000, 3000, 4000, 7000, 15000};
    public Employee (string name, string lastname, string occupation, int experience)
    {
    this.name = name;
    this.lastname = lastname;
    this.occupation = occupation;
    this.experience = experience;
    }

    double finalSalary = 0;
    double tax = 0;
    public double CalcSalary()
    {
    for (int i = 0; i < occupations.Length; i++)
    {
        if (occupations[i] == occupation)
        {
        finalSalary += salary[i];
        }
    }
    if (experience >= 0 && experience < 4)
    {
    finalSalary += 300;
    }

    else if (experience >= 4 && experience < 10)
    {
    finalSalary += 1000;
    }

    else if (experience >= 10)
    {
    finalSalary += 4000;
    }
    return finalSalary;
    }

    public double CalcTax ()
    {
    tax = CalcSalary() * 0.14;
    return Math.Round(tax, 2);
    }

    public void ShowInfo()
    {
    System.Console.WriteLine($"Name: {name}, Last Name: {lastname}, Occupation: {occupation}, Salary: {CalcSalary()}, Tax: {CalcTax()}");
    }    
    
    }
}
