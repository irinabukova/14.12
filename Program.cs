// Написать программу которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры 
// либо задать на старте выполнения алгоритма.

string[] text = {"Я", "gjvy", "чудное", "мнгновенье", "145", "передо", "мной", "ты", "как"};
string result = String.Empty;

for(int i = 0; i< text.Length; i++)
{
    if (text[i].Length <= 3)  result += text[i];
}

    Console.Write($"{result}, ");



