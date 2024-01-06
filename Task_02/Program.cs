//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int result = Akkerman(numberN,numberM);
Console.WriteLine(result);

int Akkerman(int n, int m){
    if (n==0) {
        return m+1;
    } else if (n > 0 && m==0) {
        return Akkerman(n-1,1);
    } else {
        return Akkerman(n-1,Akkerman(n,m-1));
    }
}
