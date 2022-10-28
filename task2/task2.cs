/*  Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого числа в массиве нет ([1,7] это позиция элемента) */

int [,] GetMatrix(int line, int column){
    int [,] arrMat = new int[line, column];
    for (int i = 0; i < line; i++){
        for (int j = 0; j < column; j++){
            arrMat[i ,j] = Elements();
            Console.Write("\t" + arrMat[i ,j]);
        }
        Console.WriteLine();
    }
    return arrMat;
}

int Elements() {
    Random rnd = new Random();
    int el = rnd.Next(11);
    return el;
}

int [,] matrix = GetMatrix(3, 4);

void Position(int i, int j){
    if ((i < 3) && (j < 4)){
        Console.WriteLine(matrix[i ,j]);
    } else {
        Console.WriteLine("Такого числа в массиве нет.");
    }
}

Console.Write("Введите позицию элемента: ");
Position(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
