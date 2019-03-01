using System;
using DAL.HardCoded;

namespace DAL
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProjectsHC.CreateProjects();
            Console.WriteLine("Done!");
        }
    }
}