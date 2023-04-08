using ConsoleApp1;
using System.Diagnostics;
using System.Globalization;
using System.Text;


var watch = new Stopwatch();
watch.Start();

#region Global Variables
(int, int) Goal = (0, 0);
(int, int) Start = (0, 0);
bool DeadEnd = false;
bool Found = false;
int loopCounter = 0;
Stack<PositionStep> stack = new Stack<PositionStep>();
HashSet<PositionStep> listRodada = new(new TupleEqualityComparer());

#endregion

#region Setup Data Set

int[][] baseMatrice;
ReadFileToMatrix();

stack.Push(new PositionStep(Start.Item1, Start.Item2, '\0', null));
int lines;
int columns;
int[][] tempMatrice = new int[baseMatrice.Length][];
for (int i = 0; i < baseMatrice.Length; i++)
{
    tempMatrice[i] = new int[columns + 2];
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
    TryPath();
    //Console.WriteLine(loopCounter);
}
if (DeadEnd)
{
    Console.WriteLine("No Paths Available!");
}
else
{
    GetPathNew();
}
watch.Stop();
TimeSpan ts = watch.Elapsed;
Console.WriteLine($"\r\nExecution Time: {ts.TotalMinutes} minutes and {ts.TotalMilliseconds} ms");


//Methods


void GetPathNew()
{
    Console.WriteLine("Steps:");

    Stack<char> sb = new Stack<char>();
    //while (stack.Count > 0)
    //{
    PositionStep step = stack.Pop();
    //PositionStep? currentStep = step;
    while (step?.Parent != null)
    {
        sb.Push(step.Step);
        step = step.Parent;
    }
    //break;
    //}

    var EndRoute = sb.ToArray();
    //Array.Reverse(EndRoute);
    Console.WriteLine(string.Join(' ', EndRoute));
    Console.WriteLine($"{loopCounter} Steps to found a solution\r\n");

}


void StepExecute()
{
    //tempMatrice = baseMatrice;
    Parallel.For(1, (int)lines + 1, i =>
    {
        for (int j = 1; j <= columns; j++)
        {
            if (baseMatrice[i][j] == 0) continue;
            Interlocked.Increment(ref tempMatrice[i - 1][j - 1]);
            Interlocked.Increment(ref tempMatrice[i - 1][j]);
            Interlocked.Increment(ref tempMatrice[i - 1][j + 1]);
            Interlocked.Increment(ref tempMatrice[i][j - 1]);
            Interlocked.Increment(ref tempMatrice[i][j + 1]);
            Interlocked.Increment(ref tempMatrice[i + 1][j - 1]);
            Interlocked.Increment(ref tempMatrice[i + 1][j]);
            Interlocked.Increment(ref tempMatrice[i + 1][j + 1]);
        }
    });
}
void CheckChanges()
{
    for (int i = 1; i <= lines; i++)
    {
        for (int j = 1; j <= columns; j++)
        {
            if (baseMatrice[i][j] == 0 && (tempMatrice[i][j] > 1 && tempMatrice[i][j] < 5))
            {
                baseMatrice[i][j]++;
                continue;
            }
            if (baseMatrice[i][j] == 1 && (tempMatrice[i][j] <= 3 || tempMatrice[i][j] >= 6)) baseMatrice[i][j]--;
        }
    }
    for (int i = 0; i < tempMatrice.Length; i++)
    {
        Array.Clear(tempMatrice[i], 0, tempMatrice[i].Length);
    }
}
void TryPath()
{

    while (stack.Count > 0)
    {
        PositionStep loopStack = stack.Pop();
        if (baseMatrice[loopStack.item1][loopStack.item2 - 1] == 0) listRodada.Add(new PositionStep(loopStack.item1, loopStack.item2 - 1, 'L', loopStack));

        if (baseMatrice[loopStack.item1 - 1][loopStack.item2] == 0) listRodada.Add(new PositionStep(loopStack.item1 - 1, loopStack.item2, 'U', loopStack));

        if (baseMatrice[loopStack.item1][loopStack.item2 + 1] == 0) listRodada.Add(new PositionStep(loopStack.item1, loopStack.item2 + 1, 'R', loopStack));

        if (baseMatrice[loopStack.item1 + 1][loopStack.item2] == 0) listRodada.Add(new PositionStep(loopStack.item1+1, loopStack.item2, 'D', loopStack));
    }
    foreach (var i in listRodada)
    {
        if (i.item1 == Goal.Item1)
        {
            if (i.item2 == Goal.Item2)
            {
                stack.Push(i);
                Found = true;
                break;
            }
        }
        stack.Push(i);
    };

    //DeadEnd = listRodada.Count == 0;
    listRodada.Clear();
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
/*void AddRoute(PositionStep parent, (int, int) lastPosition, char route)
{
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
    listRodada.Add(new PositionStep { End = newPosition, Start = lastPosition, Step = route, Parent = parent });

    //countDeadEnd++;
    //Found = newPosition == Goal;
    //if (newPosition == Goal)
    //{
    //    Found = true;
    //    PositionStep lastElement = listRodada.Last();
    //    listRodada.Clear();
    //    stack.Clear();
    //    stack.Push(lastElement);
    //}
}*/
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
        baseMatrice = new int[lines + 2][];
        for (int i = 0; i < baseMatrice.Length; i++)
        {
            baseMatrice[i] = new int[columns + 2];
        }

        // Read and parse lines
        for (int row = 1; row <= lines; row++)
        {
            string[] values = FileLines[row - 1].Trim().Split(' ');
            for (int col = 1; col <= columns; col++)
            {
                if (int.TryParse(values[col - 1], NumberStyles.None, CultureInfo.InvariantCulture, out int value))
                {
                    baseMatrice[row][col] = value;
                    if (value == 3) Start = (row, col);
                    if (value == 4) Goal = (row, col);
                }
            }
        }
        for (int j = 0; j <= columns + 1; j++)
        {
            baseMatrice[0][j] = 1; // top border
            baseMatrice[lines + 1][j] = 1; // bottom border
        }
        for (int i = 1; i <= lines + 1; i++)
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
    int countt = 0;
    foreach (var rota in teste.PathMonalisa)
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
        countt++;
        baseMatrice[posicao.Item1][posicao.Item2] = 0;
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
        return x.item1.Equals(y.item1) && x.item2.Equals(y.item2);
    }

    public int GetHashCode(PositionStep obj)
    {
        return (obj.item1, obj.item2).GetHashCode();
    }
}
public class PositionStep
{
    //public (int,int) end { get; set; }
    public int item1 { get; set; }
    public int item2 { get; set; }
    public char Step { get; set; }
    public PositionStep? Parent { get; set; }

    public PositionStep(int Item1, int Item2, char step, PositionStep? parent)
    {
        item1 = Item1;
        item2 = Item2;
        Step = step;
        Parent = parent;
    }
    //public PositionStep((int,int) End, char step, PositionStep? parent)
    //{
    //    end = End;
    //    Step = step;
    //    Parent = parent;
    //}




    //public bool Equals(PositionStep? other)
    //{
    //    if (other == null)
    //        return false;

    //    return this.end == other.end;
    //}
}