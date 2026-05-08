using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassForProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassName className = new ClassName("Витто","Скалетти");
            ClassNumber classNumber = new ClassNumber("+7 (322) 228 67 69", className);
            classNumber.GetFullInfo();
            Console.WriteLine();
        }
    }
}
