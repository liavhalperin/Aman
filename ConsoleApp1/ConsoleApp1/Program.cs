using System;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("HI Aman Group");
                Console.WriteLine();
                tar tar1 = new tar("", 0, 'e');
                Console.WriteLine("What is your name?");
                tar1.Name = Console.ReadLine();

                if (tar1.Name == null)
                {
                    throw new NullReferenceException("Name cannot be null.");
                }
                Console.WriteLine("What is your age?");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    tar1.Age = age;
                }
                else
                {
                    throw new ArgumentException("Age must be a valid integer.");
                }

                Console.WriteLine("What is your city?");
                if (char.TryParse(Console.ReadLine(), out char city))
                {
                    tar1.City = city;
                }
                else
                {
                    throw new ArgumentException("City must be a single character.");
                }

                Console.WriteLine(tar1.ToString());
            }
            catch (IOException ex)
            {
                Console.WriteLine($"IO Exception occurred: {ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Null Reference Exception occurred: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument Exception occurred: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Input format error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
                ToString();
            }
        }
    }

    class tar
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char City { get; set; }

        public tar(string name, int age, char city)
        {
            Name = name;
            Age = age;
            City = city;
        }

        public override string ToString()
        {
            return $"\nYour name is: {Name}\nYour age: {Age}\nYour city: {City}\n";
        }
    }
}
