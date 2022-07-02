using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reponse = "Кратчайший путь ";
            int answer = 0;
            Console.Write("Введите расстояние от 1 до 2: ");
            int one_two = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 1 до 3: ");
            int one_three = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 1 до 4: ");
            int one_four = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 2 до 5: ");
            int two_five = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 2 до 6: ");
            int two_six = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 3 до 5: ");
            int three_five = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 3 до 6: ");
            int three_six = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 4 до 5: ");
            int four_five = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 4 до 6: ");
            int four_six = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 5 до 7: ");
            int five_seven = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 5 до 8: ");
            int five_eight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 5 до 9: ");
            int five_nine = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 6 до 7: ");
            int six_seven = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 6 до 8: ");
            int six_eight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 6 до 9: ");
            int six_nine = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 7 до 10: ");
            int seven_ten = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 8 до 10: ");
            int eight_ten = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 9 до 10: ");
            int nine_ten = Convert.ToInt32(Console.ReadLine());
            if (one_two < one_three && one_two < one_four)
            {
                reponse += " 1 --> 2 --> ";
                answer += one_two;
                if (two_five < two_six)
                {
                    reponse += "5 --> ";
                    answer += two_five;
                    if (five_seven < five_eight && five_seven < five_nine)
                    {
                        reponse += "7 --> 10";
                        answer += five_seven += seven_ten;
                    }
                    else if (five_eight < five_seven && five_eight < five_nine)
                    {
                        reponse += "8 --> 10";
                        answer += five_eight += eight_ten;
                    }
                    else if (five_nine < five_seven && five_nine < five_eight)
                    {
                        reponse += "9 --> 10";
                        answer += five_nine += nine_ten;
                    }
                }
                else if (two_six < two_five)
                {
                    reponse += "6 --> ";
                    answer += two_six;
                    if (six_seven < six_eight && six_seven < six_nine)
                    {
                        reponse += "7 --> 10";
                        answer += five_seven += seven_ten;
                    }
                    else if (six_eight < six_seven && six_eight < six_nine)
                    {
                        reponse += "8 --> 10";
                        answer += five_eight += eight_ten;
                    }
                    else if (six_nine < six_seven && six_nine < six_eight)
                    {
                        reponse += "9 --> 10";
                        answer += five_nine += nine_ten;
                    }
                }
            }
            else if (one_four < one_two && one_four < one_three)
            {
                reponse += " 1 --> 4 --> ";
                answer += one_four;
                if (four_five < four_six)
                {
                    reponse += "5 --> ";
                    answer += four_five;
                    if (five_seven < five_eight && five_seven < five_nine)
                    {
                        reponse += "7 --> 10";
                        answer += five_seven += seven_ten;
                    }
                    else if (five_eight < five_seven && five_eight < five_nine)
                    {
                        reponse += "8 --> 10";
                        answer += five_eight += eight_ten;
                    }
                    else if (five_nine < five_seven && five_nine < five_eight)
                    {
                        reponse += "9 --> 10";
                        answer += five_nine += nine_ten;
                    }
                }
                else if (four_six < four_five)
                {
                    reponse += "6 --> ";
                    answer += four_six;
                    if (six_seven < six_eight && six_seven < six_nine)
                    {
                        reponse += "7 -->1 0";
                        answer += five_seven += seven_ten;
                    }
                    else if (six_eight < six_seven && six_eight < six_nine)
                    {
                        reponse += "8 --> 10";
                        answer += five_eight += eight_ten;
                    }
                    else if (six_nine < six_seven && six_nine < six_eight)
                    {
                        reponse += "9 --> 10";
                        answer += five_nine += nine_ten;
                    }
                }
            }
            else if (one_three < one_four && one_three < one_two)
            {
                reponse += " 1 --> 3 --> ";
                answer += one_three;
                if (three_five < three_six)
                {
                    reponse += "5 --> ";
                    answer += three_five;
                    if (five_seven < five_eight && five_seven < five_nine)
                    {
                        reponse += "7 --> 10";
                        answer += five_seven += seven_ten;
                    }
                    else if (five_eight < five_seven && five_eight < five_nine)
                    {
                        reponse += "8 --> 10";
                        answer += five_eight += eight_ten;
                    }
                    else if (five_nine < five_seven && five_nine < five_eight)
                    {
                        reponse += "9 --> 10";
                        answer += five_nine += nine_ten;
                    }
                }
                else if (three_six < three_five)
                {
                    reponse += "6 --> ";
                    answer += three_six;
                    if (six_seven < six_eight && six_seven < six_nine)
                    {
                        reponse += "7 --> 10";
                        answer += five_seven += seven_ten;
                    }
                    else if (six_eight < six_seven && six_eight < six_nine)
                    {
                        reponse += "8 --> 10";
                        answer += five_eight += eight_ten;
                    }
                    else if (six_nine < six_seven && six_nine < six_eight)
                    {
                        reponse += "9 --> 10";
                        answer += five_nine += nine_ten;
                    }
                }
            }
            Console.WriteLine($"\n {reponse} = {answer}");
            Console.ReadKey();
        }
    }
}
