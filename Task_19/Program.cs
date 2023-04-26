//First option

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string num_text = Convert.ToString(num);
// char[] arr_text = num_text.ToCharArray();
// Array.Reverse(arr_text);
// string reversed = new string(arr_text);

// if (num_text == reversed)
// {
//     Console.WriteLine("Это палидром");
// }

// else
// {
//     Console.WriteLine("Это не палидром");
// }

//Second option

Console.WriteLine("Введите число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
string num_text_2 = Convert.ToString(num_2);
char[] arr_text_2 = num_text_2.ToCharArray();
int index = 0;

while(index < arr_text_2.Length/2)
{
    char temp = arr_text_2[index];
    arr_text_2[index] = arr_text_2[arr_text_2.Length - 1 - index];
    arr_text_2[arr_text_2.Length - 1 - index] = temp;
    index += 1;
}

string reversed_2 = new string(arr_text_2);

if (num_text_2 == reversed_2)
{
    Console.WriteLine("Это палидром");
}

else
{
    Console.WriteLine("Это не палидром");
}

