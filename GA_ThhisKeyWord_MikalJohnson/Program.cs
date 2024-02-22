namespace GA_ThhisKeyWord_MikalJohnson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Mikal", 99);
            person1.Display(); // Outputs: Name: Alice, Age: 25

            Person person2 = new Person("Sarah");
            person2.Display(); // Outputs: Name: Bob, Age: 0
            person2.SetAge(51);
            person2.Display(); // Outputs: Name: Bob, Age: 30
        }
    }
}