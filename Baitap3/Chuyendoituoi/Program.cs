using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuyendoituoi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success = false;
            while (!success)
            {
                Console.WriteLine("nhap tuoi");
                string strInput = Console.ReadLine() ?? "";
                

                success = int.TryParse(strInput, out int soTuoi);


                if (soTuoi > 0 && soTuoi <= 120)
                {
                    int ngay = soTuoi * 365;
                    Console.WriteLine("ngay: " + ngay);
                    success = true;
                    break;

                }
                else
                {
                    Console.WriteLine("khong hop le ");
                    success = false;
                }
            }
            

        }
    }
}
