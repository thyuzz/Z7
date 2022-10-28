/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


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

void Average(){
    int [,] matrix = GetMatrix(3, 4);
    double avarage = 0;
    for (int i = 0; i < 3; i++){
        int sum = 0;
        for (int j = 0; j < 4; j++){
            sum = sum + matrix[i, j];
        }
        avarage = sum/4.0;
        Console.Write("\t" + "{0:0.00}", avarage);
    }
}

Average();

