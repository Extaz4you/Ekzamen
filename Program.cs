Console.Clear(); // Очищенте консоли
string[] result = (from arg in args             // решение задачи
                   where arg.Length <= 3
                   select arg).ToArray();
Console.Write(string.Join(",",result));


