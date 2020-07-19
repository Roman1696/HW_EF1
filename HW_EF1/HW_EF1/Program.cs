using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EF1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            var insertAll = manager.Insert();
            var pupils = manager.GetInfoAboutPupil();
            foreach (var p in pupils)
            {
                Console.WriteLine(p);
                foreach (var i in insertAll)
                {
                    Console.WriteLine(i);
                    Console.ReadKey();
                }
            }

            var deletePupils = manager.DeletePupilById(2);
            foreach (var d in deletePupils)
            {
                Console.WriteLine(d);
                Console.ReadKey();
            }
            
        }
    }
}
