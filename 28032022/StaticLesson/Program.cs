using System;

namespace StaticLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Employee employee1 = new Employee("Nigar Abbasova");
            employee1.Salary = 100;

            Employee employee2 = new Employee("Hikmet Abbasov");
            Employee employee3 = new Employee("Tofiq Abbasov");


            Console.WriteLine(Employee.Count);


            Console.WriteLine("Username daxil edin:");
            string username = Console.ReadLine();


            string password;
            do
            {
                Console.WriteLine("Password daxil edin:");
                password = Console.ReadLine();

            } while (!User.CheckPassword(password));

            User user = new User()
            {
                Password = password,
                UserName = username
            };


            Console.WriteLine($"UserName: {user.UserName}");

            #region Task

            Console.WriteLine("Student task:");

            Student student1 = new Student()
            {
                FullName = "Ekber Abbasov"
            };



            Student student2 = new Student()
            {
                FullName = "Elekber Abbasov"
            };

            Student student3 = new Student()
            {
                FullName = "Eli Abbasov"
            };

            Student student4 = new Student()
            {
                FullName = "Fidan Abbasova"
            };


            Console.WriteLine(student1.No);
            Console.WriteLine(student2.No);
            Console.WriteLine(student3.No);
            Console.WriteLine(student4.No);


            #endregion

            Console.WriteLine(Checker.HasDigit("salam123"));


            string name = "Hik1met";

            string word = "sAlAm";

            Console.WriteLine(name.Contains("H"));
            Console.WriteLine(name.HasDigit());

            Console.WriteLine(word.ToName());

            int num = 45;

            var result = num.Add(50);
            Console.WriteLine(result);
        }



    }
}
