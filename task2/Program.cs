/*
 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18


*/

int[,] generate2DArray(int height, int width, int start, int end)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i,j] = new Random().Next(start, end + 1);
        }
    }
    return twoDArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void printArray(int[,] arrayToPrint)
{
    Console.Write("\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i+"\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i+"\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] resultMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] newMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(0); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(1); k++)
            {
                newMatrix[i, k] += firstMatrix[i, j] * secondMatrix[j, k];
            }
        }    
    }
    return newMatrix;
}

int[,] generetedArray1 = generate2DArray(2, 2, -100, 100);
printArray(generetedArray1);
int[,] generetedArray2 = generate2DArray(2, 2, -100, 100);
printArray(generetedArray2);

int[,] outcomingMatrix = resultMatrix(generetedArray1, generetedArray2);
printArray(outcomingMatrix);
