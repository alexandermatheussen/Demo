using System;
using DAL.HardCoded;

namespace UI.CA
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectsHC.CreateProjects();
            Console.WriteLine("Done!");
        }
    }
}