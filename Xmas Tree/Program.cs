using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int center;

            int height; // ความสูงพิระมิด
            int.TryParse(Console.ReadLine(), out height); //รับค่า
            int width = (height * 2) - 1; //ความกว้างของพีรามิด(max)
            center = height; //center ของ พิรามิด เป็น

            for (i = 1; i <= height; i++) {

        
                for (j = 1; j <= width; j++) {
                    if (i == 1 && j == center) //บรรทัดแรกสุด print ตรงกลางพิรามิด
                    {
                        Console.Write("*");
                    }
                    else if (j > center - i && j < center + i) // บรรทัดต่อมาปริ้น ตรงกลาง -1 และ ตรงกลาง + 1
                    {
                        Console.Write("*");
                    }
                    else {
                        Console.Write(" "); //ตำแหน่งไหนไม่ปริ้น * ก็ปริ้น space
                    }
                }

                Console.WriteLine();
            }
            for (i = 1; i <= 2; i++) {
                for (j = 1; j <= width; j++) {
                    if (j == center-1 || j == center) // ฐานต้นไม้ปริ้น ตรงกลางกับ ตรงกลาง -1 
                    {
                        Console.Write("*");
                    }
                    else {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
