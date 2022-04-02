Console.Clear(); // Очищенте консоли
string[] Word = { "Age", "Place", "Pen", "Class", "Work", "Book" };
var SelectWord = from s in Word where(s.Length <=3) select s;
foreach (string text in SelectWord)
Console.WriteLine(text);