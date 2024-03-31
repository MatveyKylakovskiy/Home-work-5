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


var check1 = "плохой";
var str = "Плохой день.";

var index1 = str.Length - check1.Length;
str = str.Substring(check1.Length, index1);

var substring1 = "Хороший";
var substring2 = "!!!!!!!!!";

str = str.Insert(0, substring1);
str = str.Insert(str.Length-1, substring2);

var check2 = "!";
var substring3 = "?";

var index2 = str.LastIndexOf(check2) + 1;
str = str.Insert(index2, substring3);

Console.WriteLine(str);




