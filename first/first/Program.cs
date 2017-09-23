using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{

    
    class new_class
    {
      
       public static int bsearch(List<int> mus, int x)
        {
           


            int count=0;
            for(int i = 0; i < mus.Count; i++)
            {
                if (mus[i] == x) { count++; }

            }
            if (count == mus.Count) { return (-1); }



            count = mus.Count - 1;



            if (mus[0] < x) return (0);
                else
                {
                if (mus[count] > x) { return (-1); }
                else
                {
                    bool itog = false;
                    int a=0;
                    int b=0;
                    int left = 0;
                    int right = count;
                    while (itog != true)
                    {
                        a = left + (right - left) / 2;
                        b = mus[a];
                        if (x <= b) { left = a; }
                        if (x > b) { right = a; }
                        if ((left+1) == right)
                        {
                            b = a;
                            itog = true;
                        }
                       
                    };

                    if (mus[b] == x) return (b + 1); else return (b);

                }

            }


            return (0);
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> muss = new List<int>();

            muss.AddRange(new int[] { 10, 9, 8, 6, 5, 4 });    
            int X = -6;

            Console.WriteLine(new_class.bsearch(muss, X));
 


        }
    }
}
