// // Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double [n];
    for (int i = 0; i < array.Length; i++)
//              Для рандомных чисел от до          *(end - begin) + begin)
    array[i] = Math.Round(new Random().NextDouble()*(10-1)+1, 2);
Console.WriteLine($"[{string.Join(" ,",array)}]");

double test(double[] array)
{
    double min = array[0];
    double max = array[0];

    foreach (double i in array){
        if (min > i) 
            min = i;
        if (i > max)
            max = i;
    }
    return max - min;
}
Console.WriteLine(Math.Round(test(array)));
  