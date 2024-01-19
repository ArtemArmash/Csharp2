int[,] arr = new int[5, 5];
Random random = new Random();

for (int i = 0; i < 5; i++)
    for (int j = 0; j < 5; j++)
        arr[i,j] = random.Next(-100, 101);

Console.WriteLine("2X2 Array:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
        Console.Write(arr[i, j] + "\t");
    Console.WriteLine();
}

int minElement = arr[0, 0], maxElement = arr[0, 0];
int minRow = 0, minColumn = 0, maxRow = 0, maxColumn = 0;

for (int i = 0; i < 5; i++){
    for (int j = 0; j < 5; j++){
        if (arr[i, j] < minElement){
            minElement = arr[i, j];
            minRow = i;
            minColumn = j;
        }
        if (arr[i, j] > maxElement) {
            maxElement = arr[i, j];
            maxRow = i;
            maxColumn = j;
        }
    }
}

int sumBetweenMinMax = 0;

for (int i = Math.Min(minRow, maxRow) + 1; i < Math.Max(minRow, maxRow); i++)
    for (int j = Math.Min(minColumn, maxColumn) + 1; j < Math.Max(minColumn, maxColumn); j++)
        sumBetweenMinMax += arr[i, j];

Console.WriteLine($"\nSum Between Min and Max: {sumBetweenMinMax}");