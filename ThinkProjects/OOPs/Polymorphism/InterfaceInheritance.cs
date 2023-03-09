namespace ThinkProjects.OOPs.Polymorphism
{
    interface IFirst
    {
        void Run();
    }

    interface ISecond
    {
        void Display();
    }

    class InterfaceTest : IFirst, ISecond
    {
        public void Run()
        {
            Console.WriteLine("Its method Run");
        }
        public void Display()
        {
            Console.WriteLine("its method Display");
        }
    }

    class InterfaceInheritance
    {
        static void Main(string[] args)
        {
            InterfaceTest IT = new InterfaceTest();
            IT.Run();
            IT.Display();
        }
    }
}
