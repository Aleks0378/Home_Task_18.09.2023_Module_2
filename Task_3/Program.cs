using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 3
//Користувач вводить рядок із клавіатури. Необхідно зашифрувати цей рядок, використовуючи шифр Цезаря. 
//З Вікіпедії:
//Шифр Цезаря — це вид підстановочного шифру, в якому кожна буква відкритого тексту заміняється на ту,
//що віддалена від неї в алфавіті на сталу кількість позицій. 
//Наприклад, у шифрі зі зсувом правіше на 3, замість A була б D, замість B-E, і т.д.
//Детальніше тут: https://uk.wikipedia.org / wiki / Шифр_Цезаря.
//Окрім механізму шифрування, реалізуйте механізм розшифрування.
namespace Task_3
{
    internal class Program
    {
        static string CezarChipherRight(string a, int key)
        {
            char[] c = a.ToCharArray();
            int[] k = new int[c.Length];
            for (int i = 0; i < c.Length; i++)
            {
                k[i] = Convert.ToInt32(c[i]);
                if (k[i] >= 65 && k[i] <= 90)
                {
                    if ((k[i] + key) > 90)
                        k[i] = 65 + (k[i] + key) - 90;
                    else
                        k[i] = (k[i] + key);
                }
                else if (k[i] >= 97 && k[i] <= 122)
                {
                    if ((k[i] + key) > 122)
                        k[i] = 97 + (k[i] + key) - 122;
                    else
                        k[i] = (k[i] + key);
                }
                else
                    k[i] = k[i];
                c[i] = Convert.ToChar(k[i]);
            }
            return new string(c);
        }
        static string CezarChipherLeft(string a, int key)
        {
            char[] c = a.ToCharArray();
            int[] k = new int[c.Length];
            for (int i = 0; i < c.Length; i++)
            {
                k[i] = Convert.ToInt32(c[i]);
                if (k[i] >= 65 && k[i] <= 90)
                {
                    if ((k[i] - key) < 65)
                        k[i] = 90 - 65 + (k[i] - key);
                    else
                        k[i] = (k[i] - key);
                }
                else if (k[i] >= 97 && k[i] <= 122)
                {
                    if ((k[i] - key) < 97)
                        k[i] = 122 - 97 + (k[i] - key);
                    else
                        k[i] = (k[i] - key);
                }
                else
                    k[i] = k[i];
                c[i] = Convert.ToChar(k[i]);
            }
            return new string(c);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string a = Console.ReadLine();
            Console.WriteLine($"The string is:\n\t{a}");
            Console.Write("Enter the cipher key: ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the cipher direction(Right or Left): ");
            string d = Console.ReadLine();
            Console.WriteLine("\nYour ciphered string:");
            Console.Write("\t");
            if (d == "Right")
                a = CezarChipherRight(a, key);
            else if (d == "Left")
                a = CezarChipherLeft(a, key);
            else
                a = "Entered wrong cipher direction!";
            Console.WriteLine(a + "\n");
            Console.WriteLine("\nYour decrypted cipher string:");
            Console.Write("\t");
            if (d == "Right")
                a = CezarChipherLeft(a, key);
            else if (d == "Left")
                a = CezarChipherRight(a, key);
            else
                Console.WriteLine("Something went wrong!");
            Console.WriteLine(a + "\n");
        }
    }
}
