using System;

namespace Dog
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Dog
    {
        string name;
        string owner;
        int age;
        Gender gender;
        public Dog(string n,string o, int a, Gender g)
        {
            name=n;
            owner=o;
            age=a;
            gender=g;
        }
        public void Bark(int times)
        {
            for(int i=0;i<times;i++)
            {
                Console.WriteLine("Woof!");
            }
             
        }
        public string GetTag()
        {
            string lost="If lost, call "+owner+". "+gender+" name is "+name+" and "+gender+" is "+age+" years old.";
            return lost;
        }
        
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            puppy.Bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.GetTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.
        }
    }
    
}
