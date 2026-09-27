Console.WriteLine("Введите оценку 1-5: ");
int a = int.Parse(Console.ReadLine());
switch (a)
{
    case 1:
    Console.WriteLine("Плохо");
    break;

    case 2:
    Console.WriteLine("Неудовлетворительно");
    break;

    case 3:
    Console.WriteLine("Удовлетворительно");
    break;

    case 4:
    Console.WriteLine("Хорошо");
    break;

    case 5:
    Console.WriteLine("Отлично");
    break;

    default:
    Console.WriteLine("Ошибка, оценка должна быть 1-5");
    break;

}