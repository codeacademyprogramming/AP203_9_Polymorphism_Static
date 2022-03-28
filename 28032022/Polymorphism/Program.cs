using System;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            human1.Name = "Hikmet";
            human1.Surname = "Abbasov";

            Student student1 = new Student
            {
                Name = "Abdulla",
                Surname = "Qurbanov",
                GroupNo = "AP123"
            };

            Human human2 = new Student()
            {
                Name = "Gulsen",
                Surname = "Abdullazade",
                GroupNo = "AP123"
            };

            Human human3 = student1;
            Employee employee1 = new Employee()
            {
                Name = "Nazim",
                Surname = "Tofiqzade",
                Position = "Satici"
            };

            Human human4 = employee1;


            Teacher teacher1 = new Teacher
            {
                Salary = 250
            };

            Human human5 = teacher1;


            Human[] humans = { employee1, student1, human1,teacher1 };


            human3.ShowInfo();
            student1.ShowInfo();
            human4.ShowInfo();



            #region Task

            Notebook notebook1 = new Notebook
            {
                Name = "Acer Predator",
                Price = 3500,
                RAM = 16,
                Storage = 512
            };

            Notebook notebook2 = new Notebook
            {
                Name = "Lenova Thinkpad Ectreme",
                Price = 3400,
                RAM = 16,
                Storage = 1024
            };

            Notebook notebook3 = new Notebook
            {
                Name = "Macbook pro 13",
                Price = 2600,
                RAM = 8,
                Storage = 256
            };

            Phone phone1 = new Phone
            {
                Name = "Iphone 12 pro",
                Price = 2500,
                SIMCount = 1
            };
            Phone phone2 = new Phone
            {
                Name = "Samsung Galaxy S22",
                Price = 2800,
                SIMCount = 2
            };

            Product product = phone2;
            ISellable sellableProduct = new Notebook();
            sellableProduct.Sell();


            Product[] products = {notebook1,notebook2,notebook3,phone1,phone2};

            Console.WriteLine("Products");
            foreach (var item in products)
            {
                Console.WriteLine(item.GetInfo());
            }

            #endregion
        }


    }
}
