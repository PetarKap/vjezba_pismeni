using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace vjezba_pismeni
{
    public static class Admin
    {
        
        public static void SaveBook(string s)
        {
            using (StreamWriter sw = new StreamWriter("books.txt", true))
            {
                sw.WriteLine(s.)
            }
            
        }
        







    }
}
