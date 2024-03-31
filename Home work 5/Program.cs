//Firs task

/*using System.Text;


StringBuilder str = new StringBuilder("13 test this solution test 13 ");

str = str.Replace("test", "testing");

var str1 = str.ToString();


for (var i = 0; i < str1.Length - 1; i++)
{
    if (char.IsDigit(str1[i]))
    {
        str1 = str1.Replace($"{str1[i]}", "");

    }
}

Console.WriteLine(str1);
*/

//Second task

/*var s1 = "Welcome";
var s2 = "to";
var s3 = "the";
var s4 = "TMS";
var s5 = "lesons";

Console.WriteLine(string.Concat(s1, " " , s2, " " , s3," " , s4, " " , s5));
*/

//Third task

/*var check = "abc";
var str = "teamwithsomeofexcersicesabcwanttomakeitbetter";

var firstIndex = str.IndexOf(check);
var secondIndex = str.LastIndexOf(check);

var str1 = str.Substring(0, firstIndex);

var index1 = secondIndex + check.Length;
var index2 = str.Length - index1;

var str2 = str.Substring(index1,index2 );

Console.WriteLine("Expected result:      teamwithsomeofexcersices");
Console.WriteLine($"The result obtained:  {str1}");

Console.WriteLine("Expected result:      wanttomakeitbetter");
Console.WriteLine($"The result obtained:  {str2}");*/


//Fourth task

/*
var check1 = "плохой";
var str = "Плохой день.";

var index1 = str.Length - check1.Length;
str = str.Substring(check1.Length, index1);

var substring1 = "Хороший";
var substring2 = "!!!!!!!!!";

str = str.Insert(0, substring1);
str = str.Insert(str.Length - 1, substring2);

var check2 = "!";
var substring3 = "?";

var index2 = str.LastIndexOf(check2) + 1;
str = str.Insert(index2, substring3);

Console.WriteLine(str);
*/


//Fifth task

/*5.Написать программу со следующим функционалом:
На вход передать строку (будем считать, что это номер документа).
Номер документа имеет формат xxxx-yyy-xxxx-yyy-xyxy, где x — это число,
а y — это буква.
-Вывести на экран в одну строку два первых блока по 4 цифры.
-Вывести на экран номер документа, но блоки из трех букв заменить
на *** (каждая буква заменятся на *).
-Вывести на экран только одни буквы из номера документа в
формате yyy/yyy/y/y в нижнем регистре.
Вывести на экран буквы из номера документа в формате
"Letters:yyy/yyy/y/y" в верхнем регистре(реализовать с помощью
класса StringBuilder).
Проверить содержит ли номер документа последовательность abc и
вывети сообщение содержит или нет(причем, abc и ABC считается
одинаковой последовательностью).
Проверить начинается ли номер документа с последовательности
555.
Проверить заканчивается ли номер документа на
последовательность 1a2b.
Все эти методы реализовать в отдельном классе в статических методах,
которые на вход (входным параметром) будут принимать вводимую на
вход программы строку.*/


using System.Text;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Enter the document number in the format: xxxx-yyy-xxxx-yyy-xyxy, where x is a number\nand y is a letter.");

var numberDoc = "1478-dgg-4947-ddf-4k6j";

string[] elements = numberDoc.Split(new char[] { '-' });


//GetFirstDigit(elements);
//GetReplace(elements);
GetSmallLeters(elements);




void GetFirstDigit(string[] array)
{
    Console.WriteLine($"The first two blocks have 4 digits each: {array[0]}-{array[2]}");
}


void GetReplace(string[] array)
{
    
    foreach(string s in array)
    {
        var sb = new StringBuilder(s);

        if (sb.Length == 3)
        {
            sb.Replace(sb[0], '*');
            sb.Replace(sb[1], '*');
            sb.Replace(sb[2], '*');
        }
        Console.Write(sb.ToString() + "-");

    }
    

}

void GetSmallLeters(string[] array)
{
    int counter1 = GetSize(array);
    char[] leters = new char[counter1];

    var counter2 = 0;

    foreach (string s in array)
    {
        for (var i = 0; i < array.Length - 1; i++)
        {
            if (char.IsLetter(s[i]))
            {
                leters[counter2] = s[i];
                counter2++;

            }
        }
    }
    Console.WriteLine(string.Join(" , ", leters));




    int GetSize (string[] array)
    {
        var counter1 = 0;

        foreach (string s in array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    counter1++;

                }
            }
        }
        return counter1;
    }
}