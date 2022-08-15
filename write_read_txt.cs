using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mes_tests
{
    internal class write_read_txt
    {
        public write_read_txt()
        {
            Console.WriteLine("Hello, World!");

            try
            {
                StreamWriter sw = new StreamWriter("test.txt", false);//don't overwrite
                sw.Close();
                sw = new StreamWriter("test.txt", true);//overwritting
                sw.WriteLine("work1");
                sw.Write("work2");
                sw.Close();
                sw.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error sw : " + e.Message);
            }

            String line;

            try
            {
                StreamReader sr = new StreamReader("test.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine("Error sr : " + e.Message);
            }
        }


    }
}
