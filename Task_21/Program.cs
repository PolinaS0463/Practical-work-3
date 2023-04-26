Console.WriteLine("Введите координаты точки A по оси X: ");
double A_X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки A по оси Y: ");
double A_Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки A по оси Z: ");
double A_Z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси X: ");
double B_X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси Y: ");
double B_Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси Z: ");
double B_Z = Convert.ToInt32(Console.ReadLine());

double distance(double arg_1, double arg_2, double arg_3, double arg_4, double arg_5, double arg_6){
    double distance_3D = Math.Sqrt(Math.Pow(arg_1 - arg_4, 2) + Math.Pow(arg_2 - arg_5, 2) + Math.Pow(arg_3 - arg_6, 2));
    return Math.Round(distance_3D, 2);
}

Console.WriteLine(distance(A_X, A_Y, A_Z, B_X, B_Y, B_Z));