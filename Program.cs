// 1
int dayNumber = 6;

switch (dayNumber)
{
    case 5 or 6 or 7:
        Console.WriteLine("Выходной");
        break;
    default:
        Console.WriteLine("Будний");
        break;
}

// 2
Console.WriteLine();
int score = 78;

switch (score)
{
    case >= 0 and <= 39:
        Console.WriteLine("Неудовлетворительно");
        break;
    case >= 40 and <= 59:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 60 and <= 79:
        Console.WriteLine("Хорошо");
        break;
    case >= 80 and <= 100:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Некорректный балл");
        break;
}

// 3
Console.WriteLine();
int temperature = 22;

string weather = temperature switch
{
    < 0 => "Мороз",
    >= 0 and <= 14 => "Прохладно",
    >= 15 and <= 24 => "Комфортно",
    >= 25 and <= 34 => "Жарко",
    >= 35 => "Очень жарко"
};

Console.WriteLine(weather);

// 4 not
Console.WriteLine();
string role = "user";

string access = role switch
{
    "admin" => "Полный доступ",
    "teacher" => "Доступ преподавателя",
    not "admin" => "Ограниченный доступ"
};

Console.WriteLine(access);

// 4 when
Console.WriteLine();
int age = 20;
bool hasTicket = true;

switch (age)
{
    case >= 18 when hasTicket:
        Console.WriteLine("Вход разрешён");
        break;
    case >= 18:
        Console.WriteLine("Нет билета");
        break;
    default:
        Console.WriteLine("Возраст не подходит");
        break;
}

// 5
Console.WriteLine();
int level = 2;

switch (level)
{
    case 1:
        Console.WriteLine("Начальный уровень");
        break;
    case 2:
        Console.WriteLine("Средний уровень");
        goto case 1;
    case 3:
        Console.WriteLine("Продвинутый уровень");
        break;
}

// А
Console.WriteLine();
Console.Write("Введите номер месяца (1-12): ");
int month = int.Parse(Console.ReadLine()!);

string season = month switch
{
    12 or 1 or 2 => "Зима",
    3 or 4 or 5 => "Весна",
    6 or 7 or 8 => "Лето",
    9 or 10 or 11 => "Осень",
    _ => "Неверный месяц"
};

Console.WriteLine(season);

// В
Console.WriteLine();
Console.Write("Введите номер дня недели (1-7): ");
int day = int.Parse(Console.ReadLine()!);

string dayType = day switch
{
    1 or 2 or 3 or 4 or 5 => "Будний",
    6 or 7 => "Выходной",
    _ => "Неверный день"
};

Console.WriteLine(dayType);

// Вариант 2
Console.WriteLine();
Console.Write("Введите число от 0 до 100: ");
int scoreV2 = int.Parse(Console.ReadLine()!);

string resultV2 = scoreV2 switch
{
    >= 0 and <= 39 => "Неудовлетворительно",
    >= 40 and <= 59 => "Удовлетворительно",
    >= 60 and <= 79 => "Хорошо",
    >= 80 and <= 100 => "Отлично",
    _ => "Ошибка"
};

Console.WriteLine(resultV2);

// Вариант 8
Console.WriteLine();
Console.Write("Введите транспорт (автобус, метро, такси): ");
string transport = Console.ReadLine()!;

string transportType = transport switch
{
    "автобус" => "Наземный транспорт",
    "метро" => "Подземный транспорт",
    "такси" => "Индивидуальный транспорт",
    _ => "Неизвестный транспорт"
};

Console.WriteLine(transportType);