

namespace ConsoleApp10
{
    internal class Child
    {
        private string name;
        private string last_name;
        private int age;
        
        public Child(string Name, string Last_name, int Age)
        {
            name = Name;
            age = Age;
            last_name = Last_name;
            Console.WriteLine($"Name & last name:{name} {last_name} \nAge:{age}");
        }
      
    }
}
