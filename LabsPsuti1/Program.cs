internal class Program
{
    private static void Main(string[] args)
    {
        double a = 16.5;
        double b = 3.4;
        double x = 0.61;
        var s1 = ((Math.Pow(x, 3) * Math.Pow((a / b), 2)) * Math.Pow((x + b), 2) + (a / Math.Sqrt(x + b)));
        Console.WriteLine($"s = {s1}"); // По логике не математический спсособ
        var s11 = ((Math.Pow(x, 3) * Math.Pow(Math.Sin(a) / Math.Cos(b), 2) * Math.Pow((x + b), 2) + (a / Math.Sqrt(x + b))));
        Console.WriteLine($"s = {s11}"); // Не математический способ с тангенсом через sin и cos
        var s12 = ((Math.Pow(x, 3) * Math.Pow(Math.Tan((Math.Sin(a) / Math.Cos(b))), 2)) * (Math.Pow((x + b), 2)) + (a / Math.Sqrt(x + b)));
        Console.WriteLine($"s = {s12}"); // Не математический способ с тангенсом sin и cos используя еще и Tan

        // Что то из этого скорее всего верно
        var verno = $"{Math.Pow(x, 3)} * tg^2 * {Math.Pow((x + b), 2) + (a / Math.Sqrt(x + b))}";
        Console.WriteLine($"s = {verno}"); // не математический способ
        // Фаворит ответов думаю это самое правильное
        var verno2 = $"{Math.Pow(x, 3)} * tg^2 * {(Math.Pow(a, 2) + (2 * a * b) + Math.Pow(b, 2)) + (a / Math.Sqrt(x + b))}";
        Console.WriteLine($"s = {verno2}"); // математический способ


        var s = ((Math.Pow(x, 3) * Math.Pow((a / b), 2)) * (Math.Pow(a, 2) + (2 * a * b) + Math.Pow(b, 2))) + (a / Math.Sqrt(x + b));
        Console.WriteLine($"s = {s}"); // Математический способ скорее всего он верный (используем формулу)
        var s2 = ((Math.Pow(x, 3) * Math.Pow((Math.Sin(a) / Math.Cos(b)), 2)) * (Math.Pow(a, 2) + (2 * a * b) + Math.Pow(b, 2))) + (a / Math.Sqrt(x + b));
        Console.WriteLine($"s = {s2}"); // Математический способ но с другой формулой тангенса думаю верно это
        var s21 = ((Math.Pow(x, 3) * Math.Pow(Math.Tan((Math.Sin(a) / Math.Cos(b))), 2)) * (Math.Pow(a, 2) + (2 * a * b) + Math.Pow(b, 2))) + (a / Math.Sqrt(x + b));
        Console.WriteLine($"s = {s21}");

        var q = ((b * Math.Pow(x, 2) - a)) / (Math.Pow(Math.E, a * x) - 1);
        Console.WriteLine($"q = {q} + y");
    }
}