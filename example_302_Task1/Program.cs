// Текст. заменить пробелы черточками, маленькие буквы к - на большие К, а большие С - на маленикие с

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldvalue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for(int i = 0; i < lenght; i++)
    {
        if(text[i]== oldvalue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);

