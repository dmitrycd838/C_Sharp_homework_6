// Задайте произвольную строку. Выясните, является ли она палиндромом.

string input = "шалаш";

// Вызов метода для проверки, является ли строка палиндромом 
bool isPalindrome = IsPalindrome(input);

System.Console.WriteLine(isPalindrome ? "Да" : "Нет");

// Метод для проверки, является ли строка палиндромомpu
bool IsPalindrome(string str)
{
    // Нормализация строки путем удаления не буквенно-цифровых символов и приведения к нижнему регистру
    string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    // Сравнение строки с ее перевернутым вариантом
    return normalized.SequenceEqual(normalized.Reverse());
}
