// Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string input = "Hello my friends";

// Вызов метода для обращения порядка слов в строке
string result = ReverseWords(input);

System.Console.WriteLine(result);

// Метод для обращения порядка слов в строке
string ReverseWords(string str)
{
    // Разделение строки на слова
    string[] words = str.Split(' ');

    // Обращение порядка слов
    Array.Reverse(words);

    // Соединение слов обратно в строку с пробелами
    return string.Join(" ", words);
}