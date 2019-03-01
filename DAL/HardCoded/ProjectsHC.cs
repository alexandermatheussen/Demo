using System.Collections.Generic;
using System.Linq;
using DAL.EF;
using Domain;

namespace DAL.HardCoded
{
    public class ProjectsHC
    {
        
        public static void CreateProjects()
        {
           
           DAL.EF.DemoContext ctx = new DemoContext();

           Project p1 = new Project(1, "SAFE THE DOGS!",
               "A project started by the city of antwerp with the intention to adopt street dogs");
           Project p2 = new Project(2, "SAFE THE BIRDS!",
               "A project started by the city of antwerp with the intention to adopt street birds");
           Project p3 = new Project(3, "SAFE THE CATS!",
               "A project started by the city of antwerp with the intention to adopt street cats");

           ctx.projects.Add(p1);
           ctx.projects.Add(p2);
           ctx.projects.Add(p3);
           ctx.SaveChanges();



        }
    }
}