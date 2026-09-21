// // 1
// int dayNumber = 6;

// switch (dayNumber){
//     case 5 or 6 or 7:
//         Console.WriteLine("Выходной");
//         break;
//     default:
//         Console.WriteLine("Будний");
//         break;
// }

// // 2
// Console.WriteLine();
// int score = 101;

// switch (score){
//     case >= 0 and <= 39:
//         Console.WriteLine("Неудовлетворительно");
//         break;
//     case >= 40 and <= 59:
//         Console.WriteLine("Удовлетворительно");
//         break;
//     case >= 60 and <= 79:
//         Console.WriteLine("Хорошо");
//         break;
//     case >= 80 and <= 100:
//         Console.WriteLine("Отлично");
//         break;
//     default:
//         Console.WriteLine("Некорректный балл");
//         break;
// }

// // 3
// Console.WriteLine();
// int temperature = 50;

// string weather = temperature switch
// {
//     < 0 => "Мороз",
//     >= 0 and <= 14 => "Прохладно",
//     >= 15 and <= 24 => "Комфортно",
//     >= 25 and <= 34 => "Жарко",
//     >= 35 => "Очень жарко"
// };

// Console.WriteLine(weather);

// // 4
// Console.WriteLine();
// string role = "teacher";

// string access = role switch
// {
//     "admin" => "Полный доступ",
//     "teacher" => "Доступ преподавателя",
//     not "admin" => "Ограниченный доступ"
// };

// Console.WriteLine(access);

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