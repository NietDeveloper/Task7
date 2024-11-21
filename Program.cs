// 1. 1 dan 1000 gacha bo’lgan toq sonlarni yig’indisi
int i = 1;
int s = 0;
while(i <= 1000)
{
    if(i % 2 != 0)
    s+=i;
    i++;
}
 System.Console.WriteLine(s);
// 2. Array ichidagi eng katta va eng kichik qiymatlarni ko’paytmasi
int[] numbers = { 5, 8, 7, 6, 3, 9};
int max = numbers[0];
int min = numbers[0];
for(int j = 1; j < numbers.Length; j++)
{
    if(numbers[j] > max)
    {
        max = numbers[j];
    }
    if(numbers[j] < min)
    {
        min = numbers[j];
    }
}
System.Console.WriteLine($"Eng katta va eng kichigi ko'paytmasi: {max*min}");
// 3. (x factorial) ni hisoblaydigan dastur tuzing
System.Console.Write("Butun son kiriting:");
int n = Convert.ToInt32(Console.ReadLine());
int y = 1;
for(int h = 1; h <= n; h++)
{
    y*=h;
}
System.Console.WriteLine(y);



