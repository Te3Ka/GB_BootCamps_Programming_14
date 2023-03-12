double[,] GenerateMatrix(int rows, int columns)
{
    double[,] result = new double[rows, columns]

    return result;
}

void PrintMatrix(double[,] matrix)
{

}

double[,] MultiplySync(double[,] m1, double[,] m2)
{
    int i = 0, j = 0, k = 0;
    double[,] result = new double[i, j];

    return result;
}

double[,] MultiplyParallel(double[,] m1, double[,] m2)
{
    int i = 0, j = 0, k = 0;
    double[,] result = new double[i, j];

    return result;
}

var m1 = GenerateMatrix(100, 100);
PrintMatrix(m1);
var m2 = GenerateMatrix(100, 100);
PrintMatrix(m2);
var mSync = MultiplySync(m1, m2);
PrintMatrix(mSync);
var mParallel = MultiplyParallel(m1, m2);
PrintMatrix(mParallel);
