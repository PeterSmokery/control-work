int massive_result=0;
Console.WriteLine("введите длинну вводимого массива :");
int length =int.Parse(Console.ReadLine());
string[ ] massive = new string[length];
for(int i=0;i <length ;i++)
{
    Console.WriteLine("вводите строку:");
    massive[i] = Console.ReadLine();
    if(massive[i].Length<4)
    {
        massive[massive_result]=massive[i];
        massive_result++; 
    }
}
Console.WriteLine();
for (int i = 0; i < massive_result; i++)
{
       
    Console.Write($" {massive[i]}");
    if(i==massive_result-1)
    {
        break;
    }
    Console.Write(',');
}