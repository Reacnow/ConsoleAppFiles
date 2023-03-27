using System.Text;
Console.WriteLine("Практическая работа №13");
Console.WriteLine("Выполнил студент группы ИСП.21.1А");
Console.WriteLine("Девяткин Эдуард");
Console.WriteLine("Вариант №7");
string path = @"Input.txt";
double U = 0, A = 0, h = 0, C = 0, m = 0; //Фактические значения 
try
{
    U = double.Parse(Console.ReadLine());
    A = double.Parse(Console.ReadLine());
    h = double.Parse(Console.ReadLine());
    C = double.Parse(Console.ReadLine());
    m = double.Parse(Console.ReadLine());
    InputData(path, U, A, h, C, m);
    ReadData(path);
}
catch (Exception ex)
{
    Console.WriteLine($"Исключение: {ex.Message}");
}
static void InputData(string p, double UU, double AA, double hh, double CC, double mm)
{
    StreamWriter sw = new StreamWriter(p, false, Encoding.Default);
    sw.WriteLine(UU);
    sw.WriteLine(AA);
    sw.WriteLine(hh);
    sw.WriteLine(CC);
    sw.WriteLine(mm);
    sw.Close();
}
//static void InputData(string p, double zz)
//{
//        StreamWriter sw = new StreamWriter(p, false, Encoding.Default);
//        sw.WriteLine(zz);
//        sw.Close();
//}

//метод чтения из файла
static void ReadData(string p)
{
    StreamReader sr = new StreamReader(p, Encoding.Default);
    double UU = double.Parse(sr.ReadLine());
    double AA = double.Parse(sr.ReadLine());
    double hh = double.Parse(sr.ReadLine());
    double CC = double.Parse(sr.ReadLine());
    double mm = double.Parse(sr.ReadLine());
    double lyam = Solve(UU, AA, hh, CC, mm);
    Console.WriteLine($"Результат = {lyam}");
    InputData(@"Result.txt", lyam, 0, 0, 0, 0);
}

//метод вычисления результата
static double Solve(double UU, double AA, double hh, double CC, double mm)
{
    return (2 * hh * CC) / (2 * AA + mm * Math.Pow(UU,2));
}