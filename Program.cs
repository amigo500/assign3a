using System;

namespace Persona
{
    public class Person
    {
        private int age;
        private string fname;
        private string lname;
        private double height;
        private double weight;


        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }
        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public Person(int age, string fname, string lname, double height, double weight)
        {
            Age = age;
            Fname = fname;
            Lname = lname;
            Height = height;
            Weight = weight;
        }
    }
    public class PersonHandler
    {
        private int age;
        private string fname;
        private string lname;
        private double height;
        private double weight;


        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }
        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public PersonHandler(int age, string fname, string lname, double height, double weight)
        {
            Age = age;
            Fname = fname;
            Lname = lname;
            Height = height;
            Weight = weight;
        }


        public void SetAge(int age)
        {
            Age = age;
        }

        public void SetFname(string fname)
        {
            Fname = fname;
        }

        public void SetLname(string lname)
        {
            Lname = lname;
        }

        public void SetHeight(double height)
        {
            Height = height;
        }

        public void SetWeight(double weight)
        {
            Weight = weight;
        }
        public void CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Age = age;
            Fname = fname;
            Lname = lname;
            Height = height;
            Weight = weight;
            }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                PersonHandler person1;
                person1 = new PersonHandler(-10, "a", "Levirrrrrrrrrrrrrrrrrrn", 180, 70);
                if (person1.Age < 0)
                    {
                    throw new ArgumentException();

                }

                else
                {
                    Console.WriteLine("ok input");
                        }
            }
            catch (ArgumentException) { Console.WriteLine("Age cannot be below zero."); }

            try
            {
                PersonHandler person1;
                person1 = new PersonHandler(10, "alex", "Levirrrrrrrrrrrrrrrrrrn", 180, 70);
                if (person1.Fname.Length < 2)
                { 
                    throw new ArgumentException();

            }
                if (person1.Fname.Length > 10)
                {
                    throw new ArgumentException();

                }
                if (string.IsNullOrEmpty(person1.Fname))
                {
                    throw new ArgumentException();

                }
                else
                {
                    Console.WriteLine("Thanks, correct format of first name.");
                }
            }
            catch (ArgumentException) { Console.WriteLine("First name cannot be empty or shorter than 2 letters or longer than 10 letters."); }

            try
            {
                PersonHandler person1;
                person1 = new PersonHandler(10, "a", "", 180, 70);
                if (person1.Lname.Length < 3)
                {
                    throw new ArgumentException();

                }
                if (person1.Lname.Length > 15)
                {
                    throw new ArgumentException();

                }
                if (string.IsNullOrEmpty(person1.Lname))
                {
                    throw new ArgumentException();

                }
                else
                {
                    Console.WriteLine("Thanks, correct format of last name.");
                }
            }
            catch (ArgumentException) { Console.WriteLine("Last name cannot be empty or shorter than 3 letters or longer than 15 letters."); }


            //PersonHandler pers;
            //pers = new PersonHandler(-10, "a", "Levirrrrrrrrrrrrrrrrrrn", 180, 70);
            //pers.SetAge(34);
            //Console.WriteLine("Person details, age: " + pers.Age);
            PersonHandler pers;
            pers = new PersonHandler(-10, "a", "Levirrrrrrrrrrrrrrrrrrn", 180, 70);
            
            pers.SetAge(34);
            Console.WriteLine("Person details, age: " + pers.Age);
            pers.SetFname("Alex");
            Console.WriteLine("Person details, first name: " + pers.Fname);
            pers.SetLname("Levin");
            Console.WriteLine("Person details, last name: " + pers.Lname);
            pers.SetHeight(180);
            Console.WriteLine("Person details, height: " + pers.Height);
            pers.SetWeight(70);
            Console.WriteLine("Person details, weight: " + pers.Weight);
            pers.CreatePerson(34, "Alex", "Levin", 180, 70);
            Console.WriteLine("Person details, age: " + pers.Age);
            Console.WriteLine("Person details, first name: " + pers.Fname);
            Console.WriteLine("Person details, last name: " + pers.Lname);
            Console.WriteLine("Person details, height: " + pers.Height);
            Console.WriteLine("Person details, weight: " + pers.Weight);


            //Console.WriteLine("Person details, age: " + pers.Age);


            //   {
            //       Console.WriteLine("Age: {0} \r\nFirst Name: {1} \r\nLast Name: {2} \r\nHeight: {3} \r\nWeight: {4}", person1.Age, person1.Fname, person1.Lname, person1.Height, person1.Weight);
            //   }
        }

    }        
    }
    
