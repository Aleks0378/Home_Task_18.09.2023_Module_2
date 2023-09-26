using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 5
//Користувач з клавіатури вводить до рядка арифметичний вираз. Додаток має підрахувати його результат. 
//Необхідно дотримуватися лише двох операцій: +і –.
namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the arithmetic expression using only - or + operators: ");
            string str = Console.ReadLine();
            char[] arr = { '-', '+' };
            string[] strArr = str.Split(arr, StringSplitOptions.RemoveEmptyEntries);
            foreach (string c in strArr) 
                c.Trim();
            Console.WriteLine();
            float Rez = Convert.ToInt32(strArr[0]);
            Console.Write(str+" = ");
            for (int i = 1; i < strArr.Length; i++)
            {
                if (str[str.IndexOfAny(arr)] == '-')
                {
                    Rez -= Convert.ToInt32(strArr[i]);
                }
                if (str[str.IndexOfAny(arr)] == '+')
                {
                    Rez += Convert.ToInt32(strArr[i]);
                }
                str=str.Substring(str.IndexOfAny(arr)+1);
            }
            Console.Write($"{Rez}\n\n");
        }
    }
}
