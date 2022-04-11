
int MakeIntFromStr(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int Stop = MakeIntFromStr("Сколько значений Вы хотите посчитать?: ");
int count = 0;

while (Stop != 0)
{
    int input = MakeIntFromStr("Введите число: ");
    if (input > 0) count++;
    Stop--;
}

Console.WriteLine($"Вы ввели чисел больше 0:- {count}.");