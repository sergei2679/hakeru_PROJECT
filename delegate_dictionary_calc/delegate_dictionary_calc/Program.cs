using System;

namespace delegate_dictionary_calc
{
    class Program
    {      
        static void Main(string[] args)
        {
            var calc = new Calculator();

            //ומעבירים למחלקה SWITH CASE מתפטרים בתוכנית הראשית מ
            var add = calc.PerformOperation("+", 2, 7);
            Console.WriteLine("add operation = " + add);


            //   אם נרצה מחר להוסיף למחלקה המקומפלת עוד פעולות זה שינוי די יקר,
            
            calc.DefineOperation("mod", (x, y) => x % y);        // כך נוכל להוסיף פעולות בלי לקמפל מחדש את המחלקה
            var mod = calc.PerformOperation("mod", 4.0, 2.0);    // לדוגמא מוסיפים פעולת מודולו
            Console.WriteLine("mod operation = " + mod);


            calc.DefineOperation("-", (x, y) => x - y);  // במקרה הזה פעולה כבר קיימת , יזרוק שגיאה


            Console.ReadLine();
        } 
    }
}
