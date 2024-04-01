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

Console.WriteLine("Enter the document number in the format: xxxx-yyy-xxxx-yyy-xyxy, where x is a number\nand y is a letter.");

var numberDoc = Console.ReadLine();
Console.WriteLine("\n" + numberDoc);

string[] elements = numberDoc.Split(new char[] { '-' });

StringBuilder[] sb = new StringBuilder[elements.Length];

for (var i = 0; i < elements.Length; i++)
{
    sb[i] = new StringBuilder(elements[i]);
}

Console.WriteLine("Select the method by number:\n1 GetFirstDigit\n2 GetReplace\n3 GetSmallLeters\n4 GetUpperLeters\n5 IsContains\n6 GetStartIndex\n7 GetEndIndex");



while (true)
{
    var button = Console.ReadLine();

    if (button == "exit")
    {   
        break;
    }

    switch (button)
    {
        case "1":
            GetFirstDigit(elements);
            break;

        case "2":
            Replacer(elements);
            break;

        case "3":
            GetSmallLeters(elements);
            break;

        case "4":
            GetUpperLeters(sb);
            break;

        case "5":
            IsContains(numberDoc);
            break;

        case "6":
            GetStartIndex(elements);
            break;

        case "7":
            GetEndIndex(elements);
            break;

        default:
            Console.WriteLine("Unknown method. Try again.");
            break;
    }
}
//GetFirstDigit(elements);
//Replacer(elements);
//GetSmallLeters(elements);
//GetUpperLeters(sb);
//IsContains(numberDoc);
//GetStartIndex(elements);
//GetEndIndex(elements);







void GetFirstDigit(string[] array)
{
    Console.WriteLine($"The first two blocks have 4 digits each: {array[0]}-{array[2]}");
}


void Replacer(string[] array)
{
    StringBuilder[] tmp = new StringBuilder[array.Length];
    var counter = 0;

    foreach(string s in array)
    {
        var sb = new StringBuilder(s);
        
        if (sb.Length == 3)
        {
            sb.Replace(sb[0], '*');
            sb.Replace(sb[1], '*');
            sb.Replace(sb[2], '*');

        }

        tmp[counter] = sb;
        counter++;
        

    }

    Console.WriteLine(string.Format("{0}-{1}-{2}-{3}-{4}", tmp[0], tmp[1], tmp[2], tmp[3], tmp[4]));

}

void GetSmallLeters(string[] array)
{
    int counter1 = GetSizeString(array);
    char[] leters = new char[counter1];

    var counter2 = 0;

    foreach (string s in array)
    {
        for (var i = 0; i < s.Length; i++)
        {
            if (char.IsLetter(s[i]))
            {
                leters[counter2] = s[i];
                counter2++;

            }
        }
    }
    
    for (var i = 0; i <  leters.Length; i++)
    {
        leters[i] = char.ToLower(leters[i]);
    }

    Console.WriteLine(string.Format("{0}{1}{2}/{3}{4}{5}/{6}/{7}", leters[0], leters[1], leters[2], leters[3], leters[4],
                                                                            leters[5], leters[6], leters[7], leters[7]));
}



void GetUpperLeters(StringBuilder[] array)
{

    int counter1 = GetSizeBuilder(array);
    char[] leters = new char[counter1];

    var counter2 = 0;

    foreach (StringBuilder s in array)
    {
        for (var i = 0; i < s.Length; i++)
        {
            if (char.IsLetter(s[i]))
            {
                leters[counter2] = s[i];
                counter2++;

            }
        }
    }

    for (var i = 0; i < leters.Length; i++)
    {
        leters[i] = char.ToUpper(leters[i]);
    }

    Console.WriteLine(string.Format("{0}{1}{2}/{3}{4}{5}/{6}/{7}", leters[0], leters[1], leters[2], leters[3], leters[4],
                                                                            leters[5], leters[6], leters[7], leters[7]));
}


void IsContains(string numberDoc)
{
    var str = "abc";
    
    if (numberDoc.Contains(str, StringComparison.CurrentCultureIgnoreCase))
    {
        Console.WriteLine("The string contains \"abc\"");
    }
    
    else
    {
        Console.WriteLine("The string does not contains \"abc\"");
    }
}

void GetStartIndex(string[] array)
{
    var check = "555";
    string srt = array[0];

    if (srt.StartsWith(check))
    {
        Console.WriteLine($"The line starts with \"{check}\"");
    }

    else
    {
        Console.WriteLine($"The line does not start with \"{check}\"");
    }
}

/*Проверить заканчивается ли номер документа на
последовательность 1a2b.*/
void GetEndIndex(string[] array)
{
    var check = "1a2b";
    string srt = array[^1];

    if (srt.EndsWith(check))
    {
        Console.WriteLine($"The line ends with \"{check}\"");
    }

    else
    {
        Console.WriteLine($"The line does not ends with \"{check}\"");
    }
}

int GetSizeBuilder(StringBuilder[] array)
{
    var counter = 0;

    foreach (StringBuilder s in array)
    {
        for (var i = 0; i < s.Length; i++)
        {
            if (char.IsLetter(s[i]))
            {
                counter++;

            }
        }
    }
    return counter;
}


int GetSizeString(string[] array)
{
    var counter = 0;

    foreach (string s in array)
    {
        for (var i = 0; i < s.Length; i++)
        {
            if (char.IsLetter(s[i]))
            {
                counter++;

            }
        }
    }
    return counter;
}
