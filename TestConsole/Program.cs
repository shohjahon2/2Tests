using FileSystemVisitor;
using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Finder finder = new Finder();
            finder.GetFiles(@"C:\Users\User\Desktop\Exeption handling", ".");
            finder.Started += () => Onstarted();
            finder.OnStarted();
            foreach (var item in finder.Files)
            {
                Console.WriteLine(item);
            }
            finder.Finishied += () => OnFinished();
            finder.OnFinished();
        }
        static void Onstarted()
        {
            Console.WriteLine("Process Started!");
        }
        static void OnFinished()
        {
            Console.WriteLine("Process Started!");
        }
    }
}
