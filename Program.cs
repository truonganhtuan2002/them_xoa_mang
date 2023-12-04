using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OntapMang_them_xoa_snt_hh_cp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.Write("Nhap so phan tu : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Nhap mang : ");
            for(i = 0; i < a.Length; i++)
            {
                Console.Write("Phan tu thu {0} la : ", (i + 1));
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nmang vua nhap la : ");
           foreach(int xuatmang in a)
            {
                Console.Write(" " + xuatmang);
            }

            // them phan tu vao vitri trong mang
            Console.Write("\nNhap gia tri can them : ");int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap vitri can them : "); int vitri = int.Parse(Console.ReadLine());
            
            //Console.Write("Mang sau khi them la : ");
            //Them(a, x, vitri);


            for(i = a.Length; i >= vitri; i--)
            {
                a[i] = a[i - 1];
            } a[vitri] = x;
            ++n;
            Console.Write("Mang sau khi them la : ");
            for (i = 0; i <a.Length; i++)
            {
                Console.Write(" " + a[i]);
            }
            // xoa phan tu trong mang 
            while (i != vitri-1)
            {
                i++;
            } while (i < n)
            {
                a[i] = a[i + 1];
                i++;
            }
            n--;
            // mang sau khi xoa

            Console.ReadKey();
        }
    }
}
