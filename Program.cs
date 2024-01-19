double[] A = new double[5];
double[,] B = new double[3, 4];
Random random = new Random();

Console.WriteLine(":");
for (int i = 0; i < A.Length; i++)
    A[i] = Convert.ToDouble(Console.ReadLine());

for (int i = 0; i < 3; i++)
    for (int j = 0; j < 4; j++)
        B[i, j] = random.NextDouble();

Console.WriteLine("\nArray A:");
foreach (var element in A)
    Console.Write(element + " ");

Console.WriteLine("\n\nArray B:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
        Console.Write(B[i, j] + "\t");
    Console.WriteLine();
}

double maxA = A[0], minA = A[0], sumA = 0, productA = 1, sumEvenA = 0;

foreach (var element in A)
{
    if (element > maxA)
        maxA = element;
    if (element < minA)
        minA = element;
    sumA += element;
    productA *= element;
    if (element % 2 == 0)
        sumEvenA += element;
}

double maxB = B[0, 0], minB = B[0, 0], sumB = 0, productB = 1, sumOddColumnsB = 0;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (B[i, j] > maxB)
            maxB = B[i, j];
        if (B[i, j] < minB)
            minB = B[i, j];
        sumB += B[i, j];
        productB *= B[i, j];
        if (j % 2 != 0)
            sumOddColumnsB += B[i, j];
    }
}

Console.WriteLine($"\nMax A: {maxA}, Min A: {minA}, Sum A: {sumA}, Product A: {productA}, Sum Even A: {sumEvenA}");
Console.WriteLine($"\nMax B: {maxB}, Min B: {minB}, Sum B: {sumB}, Product B: {productB}, Sum Odd Columns B: {sumOddColumnsB}");