string[] array = new string[] {"Hello", "2", "world", ":-)"};
//string[] array = new string[] {"1234", "1567", "-2", "computer science"};
//string[] array = new string[] {"Russia", "Denmark", "Kazan"};
string[] res = new string[5];
int j = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        res[j] = array[i];
        Console.Write(res[j] + "  ");
        j = j + 1;
    }
}