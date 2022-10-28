/*  Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */ 


double [,] GetMatrix(int line, int column){
    double [,] arrMat = new double[line, column];
    for (int i = 0; i < line; i++){
        for (int j = 0; j < column; j++){
            arrMat[i ,j] = (Elements() * Value10_100() + 2);
            Console.Write("{0:0.00}   ", arrMat[i ,j]);
        }
        Console.WriteLine();
    }
    return arrMat;
}

double Elements() {
    Random rnd = new Random();
    double el = rnd.NextDouble();
    return el;
}

int Value10_100(){
    Random rnd = new Random();
    int[] arr = new int[4] { -100, -10, 10, 100 };
    int i = rnd.Next(arr.Length);
    return arr[i];
}

double [,] matrix = GetMatrix(3, 4);