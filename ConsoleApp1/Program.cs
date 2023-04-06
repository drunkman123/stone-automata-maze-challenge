//using ConsoleApp1;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Text;

var watch = new Stopwatch();
watch.Start();

#region Global Variables
(uint, uint) Goal = (0, 0);
(uint, uint) Start = (0, 0);
bool DeadEnd = false;
bool Found = false;
int lastIndex = 0;
int loopCounter = 0;
ArrayList route = new ArrayList();
//StringBuilder route = new StringBuilder();

HashSet<PositionStep> listPositionStepTmp = new HashSet<PositionStep>(new TupleEqualityComparer());

#endregion

#region Setup Data Set

uint[][] baseMatrice;
ReadFileToMatrix();
List<List<PositionStep>> listAllPositionSteps = new List<List<PositionStep>>()
{
    new List<PositionStep>()
    {
        new PositionStep{End = Start,Start=Start, Step = '\0'}
    }
};
int lines;
int columns;
uint[][] tempMatrice = new uint[baseMatrice.Length][];
for (uint i = 0; i < baseMatrice.Length; i++)
{
    tempMatrice[i] = new uint[columns + 2];
}
baseMatrice[Start.Item1][Start.Item2] = 0;
baseMatrice[Goal.Item1][Goal.Item2] = 0;
#endregion

while (!Found && !DeadEnd)
{
    //PathTeste(); //descomente o método embaixo e escolha o tipo de input
    //start and goal set to 0 to not mess with the stepexecute
    StepExecute();
    CheckChanges();
    baseMatrice[Start.Item1][Start.Item2] = 0;
    baseMatrice[Goal.Item1][Goal.Item2] = 0;
    //printMatrix(baseMatrice, "vai");
    TryPath();
}
if (DeadEnd) 
{ 
    Console.WriteLine("No Paths Available!"); 
}
else
{
    GetPath();
    Console.WriteLine($"{loopCounter} Steps to found a solution\r\n");
    route.Remove('\0');
    route.Reverse();
    Console.WriteLine("Steps:");

    Console.WriteLine(string.Join(" ", route.ToArray()));
}
watch.Stop();
TimeSpan ts = watch.Elapsed;
Console.WriteLine($"\r\nExecution Time: {ts.TotalMinutes} minutes and {ts.TotalMilliseconds} ms");


//Methods
void GetPath()
{
    for (int i = listAllPositionSteps.Count - 1; i >= 0; i--)
    {
        for (int j = listAllPositionSteps[i].Count - 1; j >= 0; j--)
        {
            if (listAllPositionSteps[i][j].End == Goal)
            {
                route.Add(listAllPositionSteps[i][j].Step);
                lastIndex = j;
                break;
            }
            if (listAllPositionSteps[i + 1][lastIndex].Start == listAllPositionSteps[i][j].End)
            {
                route.Add(listAllPositionSteps[i][j].Step);
                lastIndex = j;
                break;
            }
        }
    }
}
void StepExecute()
{
    //tempMatrice = baseMatrice;
    for (uint i = 1; i <= lines; i++)
    {
        for (uint j = 1; j <= columns; j++)
        {
            if (baseMatrice[i][j] == 0) continue;
            tempMatrice[i - 1][j - 1]++;
            tempMatrice[i - 1][j]++;
            tempMatrice[i - 1][j + 1]++;
            tempMatrice[i][j - 1]++;
            tempMatrice[i][j + 1]++;
            tempMatrice[i + 1][j - 1]++;
            tempMatrice[i + 1][j]++;
            tempMatrice[i + 1][j + 1]++;
        }
    }
}
void CheckChanges()
{
    for (uint i = 1; i <= lines; i++)
    {
        for (uint j = 1; j <= columns; j++)
        {
            if (baseMatrice[i][j] == 0 && (tempMatrice[i][j] > 1 && tempMatrice[i][j] < 5))
            {
                baseMatrice[i][j]++;
                continue;
            }
            if (baseMatrice[i][j] == 1 && (tempMatrice[i][j] <= 3 || tempMatrice[i][j] >= 6)) baseMatrice[i][j]--;
        }
    }
    for (uint i = 0; i < tempMatrice.Length; i++)
    {
        Array.Clear(tempMatrice[i], 0, tempMatrice[i].Length);
    }
}
void TryPath()
{
    listAllPositionSteps[loopCounter].ForEach(t =>
    {
        if (baseMatrice[t.End.Item1][t.End.Item2 - 1] == 0 && !Found) AddRoute(t.End, 'L');

        if (baseMatrice[t.End.Item1 - 1][t.End.Item2] == 0 && !Found) AddRoute(t.End, 'U');

        if (baseMatrice[t.End.Item1][t.End.Item2 + 1] == 0 && !Found) AddRoute(t.End, 'R');

        if (baseMatrice[t.End.Item1 + 1][t.End.Item2] == 0 && !Found) AddRoute(t.End, 'D');
    });

    DeadEnd = listPositionStepTmp.Count == 0;
    listAllPositionSteps.Add(listPositionStepTmp.ToList());
    listPositionStepTmp.Clear();
    //Console.WriteLine(loopCounter);
    loopCounter++;
}
void printMatrix(int[][] matrix, string name)
{
    Console.Write(name + "\n");

    for (int i = 0; i < lines + 2; i++)
    {
        for (int j = 0; j < columns + 2; j++)
        {

            Console.Write(matrix[i][j].ToString() + " ");
        }

        Console.Write("\n");

    }
    Console.Write("\n");

}
void AddRoute((uint, uint) lastPosition, char route)
{
    //var lastPosition = j;
    var newPosition = lastPosition;
    switch (route)
    {
        case 'D':
            newPosition.Item1 += 1;
            break;
        case 'R':
            newPosition.Item2 += 1;
            break;
        case 'L':
            newPosition.Item2 -= 1;
            break;
        case 'U':
            newPosition.Item1 -= 1;
            break;
    }
    var tuple = new PositionStep { End = newPosition, Start = lastPosition, Step = route };
    listPositionStepTmp.Add(tuple);
    Found = newPosition == Goal;
}
void ReadFileToMatrix()
{
    //using (FileStream fileStream = new FileStream("C:\\Users\\felip\\OneDrive\\Área de Trabalho\\input.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
    //using (FileStream fileStream = new FileStream("C:\\Users\\41140878859\\Desktop\\projetos_git\\stone-automata-maze-challenge\\input.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
    using (FileStream fileStream = new FileStream("E:\\Git pessoal\\stone-automata-maze-challenge\\input.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
    {
        // Construct the input string
        StringBuilder inputBuilder = new StringBuilder();
        byte[] buffer = new byte[1024];
        int bytesRead;
        while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
        {
            string chunk = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            inputBuilder.Append(chunk);
        }
        string input = inputBuilder.ToString();

        // Get matrix dimensions from input contents
        string[] FileLines = input.Trim().Split('\n');
        columns = FileLines[0].Split(' ').Length;
        lines = FileLines.Length;

        // Create new jagged array with border
        baseMatrice = new uint[lines + 2][];
        for (uint i = 0; i < baseMatrice.Length; i++)
        {
            baseMatrice[i] = new uint[columns + 2];
        }

        // Read and parse lines
        for (uint row = 1; row <= lines; row++)
        {
            string[] values = FileLines[row - 1].Trim().Split(' ');
            for (uint col = 1; col <= columns; col++)
            {
                if (uint.TryParse(values[col - 1], NumberStyles.None, CultureInfo.InvariantCulture, out uint value))
                {
                    baseMatrice[row][col] = value;
                    if (value == 3) Start = (row, col);
                    if (value == 4) Goal = (row, col);
                }
            }
        }
        for (uint j = 0; j <= columns + 1; j++)
        {
            baseMatrice[0][j] = 1; // top border
            baseMatrice[lines + 1][j] = 1; // bottom border
        }
        for (uint i = 1; i <= lines + 1; i++)
        {
            baseMatrice[i][0] = 1; // left border
            baseMatrice[i][columns + 1] = 1; // right border
        }
    }
}
/*void PathTeste()
{
    PathTest teste= PathTest.Default;
    int i = 1, j = 1;
    (int, int) posicao = (i, j);

    foreach (var rota in teste.PathChallenge1)
    {
        StepExecute();
        CheckChanges();
        baseMatrice[Start.Item1][Start.Item2] = 0;
        baseMatrice[Goal.Item1][Goal.Item2] = 0;
        //printMatrix(baseMatrice, "Matriz para andar");

        if (rota == "R")
        {
            j++;
            posicao = (i, j);
            if (baseMatrice[i][j] == 0)
            {
                Console.WriteLine("Passo ok");
            }
            else
            {
                Console.WriteLine("passo proibido");
                i = 99;
                break;

            }
        }
        else if(rota == "L")
        {
            j--;
            posicao = (i, j);
            if (baseMatrice[i][j] == 0)
            {
                Console.WriteLine("Passo ok");
            }
            else
            {
                Console.WriteLine("passo proibido");
                i = 99;
                break;

            }

        }
        else if(rota == "U")
        {
            i--;
            posicao = (i, j);
            if (baseMatrice[i][j] == 0)
            {
                Console.WriteLine("Passo ok");
            }
            else
            {
                Console.WriteLine("passo proibido");
                i = 99;
                break;
            }
        }
        else if(rota == "D")
        {
            i++;
            posicao = (i, j);
            if (baseMatrice[i][j] == 0)
            {
                Console.WriteLine("Passo ok");
            }
            else
            {
                Console.WriteLine("passo proibido");
                i = 99;
                break;
            }
        }
        baseMatrice[posicao.Item1][posicao.Item2] = 5;
        //printMatrix(baseMatrice, "matrix movimentada");
        baseMatrice[posicao.Item1][posicao.Item2] = 0;
    }
    if (i == 99)
    {
        Console.WriteLine("bateu xabu");
    }
}*/

public class TupleEqualityComparer : IEqualityComparer<PositionStep>
{
    public bool Equals(PositionStep x, PositionStep y)
    {
        return x.End.Equals(y.End);
    }

    public int GetHashCode(PositionStep obj)
    {
        return obj.End.GetHashCode();
    }
}
public struct PositionStep
{
    public (uint, uint) Start { get; set; }
    public (uint, uint) End { get; set; }
    public char Step { get; set; }
}