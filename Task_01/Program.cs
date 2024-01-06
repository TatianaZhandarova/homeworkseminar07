//Задайте значения M и N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.WriteLine("Введите число: ");
int startNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int finishNumber = Convert.ToInt32(Console.ReadLine());

if (!CheckNumber(startNumber) || !CheckNumber(finishNumber) ){
    Console.WriteLine("введенное число не является натуральным");
};

bool CheckNumber(int i){
    if (i<0){
        return false;
    } else return true;
    
}

int listNumber(int numStart, int numFin){
    if(numStart <= numFin){
        Console.Write(numStart);
        listNumber(numStart+1, numFin);
    }
    return listNumber(numStart,numFin);
}

listNumber(startNumber, finishNumber);
Console.WriteLine();