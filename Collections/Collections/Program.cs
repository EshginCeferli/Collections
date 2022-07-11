using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> nums = new List<int>();
            //nums.Add(1);
            //nums.Add(10);
            //nums.Add(15);
            //nums.Add(50);

            //nums.AddRange(nums);
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < nums.Count; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //if (nums.Count == 4)
            //{
            //    Console.WriteLine("List count is {0}",nums.Count);
            //}

            //Hashtable datas = new Hashtable();
            //datas.Add(1, "Fidan");
            //datas.Add(2, "Seid");
            //datas.Add(3, "Eshgin");

            //foreach (DictionaryEntry item in datas)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //SortedList datas = new SortedList();
            //datas.Add(1, "Fidan");
            //datas.Add(2, "Seid");
            //datas.Add(3, "Eshgin");
            //foreach (DictionaryEntry item in datas)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //SortedList<int, string> keyValuePairs = new SortedList<int, string>();
            //keyValuePairs.Add(1, "Player1");
            //keyValuePairs.Add(2, "Player2");
            //foreach (KeyValuePair<int,string> item in keyValuePairs)
            //{
            //    Console.WriteLine(item.Key + " " + " " + item.Value);
            //}

            //HashSet<string> datas = new HashSet<string>();
            //datas.Add("data1");
            //datas.Add("data2");
            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}


            //Stack<int> datas = new Stack<int>();
            //datas.Push(1);
            //datas.Push(10);
            //datas.Push(20);
            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue<int> datas = new Queue<int>();
            //datas.Enqueue(1);
            //datas.Enqueue(10);
            //datas.Enqueue(20);
            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<string, string> datas = new Dictionary<string, string>();
            //datas.Add("Admin", "Orxan");
            //datas.Add("Member", "Samir");
            //foreach (KeyValuePair<string,string> item in datas)
            //{
            //    if (item.Key == "Admin")
            //    {
            //        Console.WriteLine($"Name : {item.Value}, Role: {item.Key}");
            //        break;
            //    }
            //}

            //ArrayList datas = new ArrayList();
            //datas.Add(1);
            //datas.Add(true);
            //datas.Add("player");
            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Person> people = new List<Person>();
          
            
            //Person person1 = new Person();
            //person1.Id = 1;
            //person1.name = "Sadiq";
            //person1.mail = "sadiq@mail.ru";

            //Person person2 = new Person()
            //{
            //    Id = 2,
            //    name = "Ramil",
            //    mail = "ramil@mail.ru"
            //};

            //people.Add(person1);
            //people.Add(person2);

            //people.Add(new Person { Id = 3, name = "Orxan", mail = "orxan@mail.ru" });
            //people.Add(new Person { Id = 4, name = "Cavidan", mail = "cavidan@mail.ru" });
            //people.Add(new Person { Id = 5, name = "Nermin", mail = "nermin@mail.ru" });

            //GetStudents(people);
            //GetNumbers(nums);
            //var result = GetPersonByName(people, "Orxan");
            //Console.WriteLine(result.name + " " + result.Id + " " + result.mail);
            
        }

        //public static void GetStudents(List<Person> students)
        //{
        //    foreach (var stu in students)
        //    {
        //        Console.WriteLine("Student Id-{0}, Student Name-{1}, Student Mail-{2}", stu.Id, stu.name, stu.mail);
        //    }
        //}

        //public static void GetNumbers(List<int> nums)
        //{
        //    foreach (var item in nums)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        //public static Person GetPersonByName(List<Person> people, string name)
        //{
        //    var person = people.Find(m => m.name == name);
        //    return person;
        //}

    }
    //public class Person
    //{
    //    public int Id { get; set; }
    //    public string name { get; set; }
    //    public string mail { get; set; }

    //}
}
