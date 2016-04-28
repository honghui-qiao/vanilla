using System;
using Vanilla.Repository.EF;

namespace VanillaTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (VanillaContext ctx = new VanillaContext())
            {
                ctx.Database.CreateIfNotExists();
            }
            Console.WriteLine("Created Vanilla database.");
        }
    }
}
