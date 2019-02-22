using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLEncoder
{
    class Program
    {
        static bool flag = false;
        static void Main(string[] args)
        {
            do
            {
                string project_name = " ";
                string activity_name = " ";

                try
                {
                    Console.WriteLine("Enter the project name");
                    project_name = Console.ReadLine();

                    Console.WriteLine("Enter the project name");
                    activity_name = Console.ReadLine();

                    string url = "https://companyserver.com/content/" + project_name + "/files/" + activity_name + "/" + activity_name + "Report.pdf";
                    Console.WriteLine("\n");
                    Console.WriteLine(url);
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Please enter valid details");
                }
                Console.WriteLine("\n");
                Console.WriteLine("Do you want another URL say y/n");
                char res = Convert.ToChar(Console.ReadLine());
                if (res == 'y')
                {
                    flag = true;
                }
            } while (flag == true);
        }
    }
}
