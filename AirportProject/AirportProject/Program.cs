using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            AirPort a1 = new Employees("Ivan Ivanov", "Sanitar", 34, "Sofiq Terminal 1","Ivanvazovsko");
            AirPort a2 = new Employees("Martin Marinov", "Pilot", 55, "Varna Terminal 2","Stambolisko");
            AirPort a3 = new Employees("Ivanka Stoyanova", "Stuardesa", 26, "Plovdiv Terminal 2","Lozovsko");

            AirPort a4 = new Pasanger("Mariyan", "09876532",22, 45678, "Sofiq Terminal 1", "Ivanvazovsko");
            AirPort a5 = new Pasanger("Mariyana", "08624523",13, 87123, "Varna Terminal 2", "Stamboliisko");

            AirPort a6 = new Fly(89, 411, "Plovdiv Terminal 2", "Lozovsko");
            AirPort a7 = new Fly(67, 430, "Varna Terminal 2", "Stamboliisko");

            a1.PrintInfo();
            a2.PrintInfo();
            a3.PrintInfo();
            a4.PrintInfo();
            a5.PrintInfo();
            a6.PrintInfo();
            a7.PrintInfo();
        }
    }
}
