//Задайте произвольный массив. Выведете его элементы, 
//начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = NewMassive(5);
PrintArray(array);
Console.WriteLine();
backArray(array,array.Length-1);


int [] NewMassive(int j){
    int[] count = new int [j];
    for(int i = 0; i<count.Length; i++) count[i] = new Random().Next(1,100);
    return count;
}

void PrintArray(int[] col){
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

void backArray(int [] num, int i){
    if(i>=0){
        Console.Write(num[i] + " ");
        backArray(num, i-1);
    }
}