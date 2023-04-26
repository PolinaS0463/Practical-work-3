// В виде функции:
// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// double Cube(int arg1){
//     int count = 1;
//     while (count <= arg1){
//         Console.WriteLine(Math.Pow(count, 3));
//         count += 1;
//     }
//     return Math.Pow(count, 3);
// }
// Cube(N);

// Обычный код:

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= N){
    Console.WriteLine(Math.Pow(count, 3));
    count += 1;
}