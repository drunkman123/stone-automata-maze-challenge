using System.Diagnostics;

var watch = new Stopwatch();
watch.Start();
#region Global Variables
int countGreen = 0;
(int,int) Goal = ( 0, 0 );
(int,int) Start = ( 0, 0 );
bool DeadEnd = false;
bool Found = false;
int lastIndex = 0;
int loopCounter = 0;
List<List<PositionStep>> listAllPositionSteps = new List<List<PositionStep>>();
string route = string.Empty;
HashSet<PositionStep> listPositionStepTmp = new HashSet<PositionStep>(new TupleEqualityComparer());

List<PositionStep> listPositionSteps = new List<PositionStep>()
{
    new PositionStep(Start, Start, string.Empty)
};




#endregion

#region Setup Data Set
int lines;
int columns;
int[,] baseMatrice;
int[,] tempMatrice;

//using (StreamReader reader = new StreamReader("C:\\Users\\felip\\OneDrive\\Área de Trabalho\\input sigma 3.txt"))
using (StreamReader reader = new StreamReader("C:\\Users\\felip\\OneDrive\\Área de Trabalho\\input2.txt"))
{
    string line;
    List<int[]> rows = new List<int[]>();

    while ((line = reader.ReadLine()!) != null)
    {
        string[] values = line.Split(' ');
        int[] row = new int[values.Length];

        for (int i = 0; i < values.Length; i++)
        {
            row[i] = int.Parse(values[i]);
        }

        rows.Add(row);
    }

    int numRows = rows.Count;
    int numCols = rows[0].Length;
    baseMatrice = new int[numRows, numCols];

    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numCols; j++)
        {
            baseMatrice[i, j] = rows[i][j];
            if (rows[i][j] == 3) Start = ( i,j );
            if (rows[i][j] == 4) Goal = ( i,j );
        }
    }
    lines = numRows;
    columns = numCols;
}
#endregion
tempMatrice = new int[lines, columns];

while (!Found && !DeadEnd)
{
    baseMatrice[Start.Item1, Start.Item2] = 0;
    baseMatrice[Goal.Item1, Goal.Item2] = 0;
    StepExecute();
    baseMatrice = tempMatrice;
    TryPath();
    tempMatrice= new int[lines, columns];
}
if (DeadEnd) Console.WriteLine("No Paths Available!");
else
{
    GetPath();
}
watch.Stop();

Console.WriteLine($"\r\nExecution Time: {watch.ElapsedMilliseconds} ms");


//Methods
async void StepExecute()
{
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {

            #region first line
            //verificação segundo elemento(ateh penultino)/primeira linha
            if (i == 0 && j != 0 && j != columns - 1)
            {
                countGreen += baseMatrice[i, j - 1];
                countGreen += baseMatrice[i + 1, j - 1];
                countGreen += baseMatrice[i + 1, j];
                countGreen += baseMatrice[i + 1, j + 1];
                countGreen += baseMatrice[i, j + 1];

                CheckChangeAndResetCount(i, j);
            }

            //verificação ultimo elemento/primeira linha
            if (i == 0 && j == columns - 1)
            {
                countGreen += baseMatrice[i, j - 1];
                countGreen += baseMatrice[i + 1, j - 1];
                countGreen += baseMatrice[i + 1, j];

                CheckChangeAndResetCount(i, j);
            }
            #endregion

            #region mid lines
            //verificação primeiro elemento/lines internas
            if (i != 0 && i != lines - 1 && j == 0 && !Found)
            {
                countGreen += baseMatrice[i - 1, j];
                countGreen += baseMatrice[i - 1, j + 1];
                countGreen += baseMatrice[i, j + 1];
                countGreen += baseMatrice[i + 1, j + 1];
                countGreen += baseMatrice[i + 1, j];


                CheckChangeAndResetCount(i, j);
            }

            //verificação segundo elemento(ateh penultino)/lines internas
            if (i != 0 && i != lines - 1 && j != 0 && j != columns - 1)
            {
                countGreen += baseMatrice[i - 1, j - 1];
                countGreen += baseMatrice[i - 1, j];
                countGreen += baseMatrice[i - 1, j + 1];
                countGreen += baseMatrice[i, j - 1];
                countGreen += baseMatrice[i, j + 1];
                countGreen += baseMatrice[i + 1, j - 1];
                countGreen += baseMatrice[i + 1, j];
                countGreen += baseMatrice[i + 1, j + 1];
                CheckChangeAndResetCount(i, j);
            }

            //verificação ultimo elemento/lines internas
            if (i != 0 && i != lines - 1 && j == columns - 1)
            {
                countGreen += baseMatrice[i - 1, j];
                countGreen += baseMatrice[i - 1, j - 1];
                countGreen += baseMatrice[i, j - 1];
                countGreen += baseMatrice[i + 1, j - 1];
                countGreen += baseMatrice[i + 1, j];
                CheckChangeAndResetCount(i, j);
            }
            #endregion

            #region last line
            //verificação primeiro elemento/ultima linha
            if (i == lines - 1 && j == 0 && !Found)
            {
                countGreen += baseMatrice[i - 1, j];
                countGreen += baseMatrice[i - 1, j + 1];
                countGreen += baseMatrice[i, j + 1];
                CheckChangeAndResetCount(i, j);
            }

            //verificação segundo elemento(ateh penultino)/ultima linha
            if (i == lines - 1 && j != 0 && j != columns - 1)
            {
                countGreen += baseMatrice[i, j - 1];
                countGreen += baseMatrice[i - 1, j - 1];
                countGreen += baseMatrice[i - 1, j];
                countGreen += baseMatrice[i - 1, j + 1];
                countGreen += baseMatrice[i, j + 1];
                CheckChangeAndResetCount(i, j);
            }
            #endregion
        }
    }
}

async void TryPath()
{
    //item1 eh posicao anterior, item2 eh posicao atual, item3 é o movimento
    foreach (var t in listPositionSteps)
    {

        int i = t.End.Item1;
        int j = t.End.Item2;

        #region primeira linha

        //verificação primeiro elemento/primeira linha
        if (i == 0 && j == 0 && !Found)
        {

            if (baseMatrice[i + 1, j] == 0 && !Found)
            {
                AddRoute(i, j, "D");
            }            

            if (baseMatrice[i, j + 1] == 0 && !Found)
            {
                AddRoute(i, j, "R");
            }
        }

        //verificação segundo elemento(ateh penultino)/primeira linha
        if (i == 0 && j != 0 && j != columns - 1 && !Found)
        {
            
            if (baseMatrice[i + 1, j] == 0 && !Found)
            {
                AddRoute(i, j, "D");
            }

            if (baseMatrice[i, j + 1] == 0 && !Found)
            {
                AddRoute(i, j, "R");
            }

            if (baseMatrice[i, j - 1] == 0 && !Found)
            {
                AddRoute(i, j, "L");
            }
        }

        //verificação ultimo elemento/primeira linha
        if (i == 0 && j == columns - 1 && !Found)
        {

            if (baseMatrice[i + 1, j] == 0 && !Found)
            {
                AddRoute(i, j, "D");
            }

            if (baseMatrice[i, j - 1] == 0 && !Found)
            {
                AddRoute(i, j, "L");
            }
        }
        #endregion

        #region lines do meio
        //verificação primeiro elemento/lines internas
        if (i != 0 && i != lines - 1 && j == 0 && !Found)
        {

            if (baseMatrice[i + 1, j] == 0 && !Found)
            {
                AddRoute(i, j, "D");
            }

            if (baseMatrice[i - 1, j] == 0 && !Found)
            {
                AddRoute(i, j, "U");
            }

            if (baseMatrice[i, j + 1] == 0 && !Found)
            {
                AddRoute(i, j, "R");
            }
        }

        //verificação segundo elemento(ateh penultino)/lines internas
        if (i != 0 && i != lines - 1 && j != 0 && j != columns - 1 && !Found)
        {

            if (baseMatrice[i - 1, j] == 0 && !Found)
            {
                AddRoute(i, j, "U");
            }

            if (baseMatrice[i, j + 1] == 0 && !Found)
            {
                AddRoute(i, j, "R");
            }

            if (baseMatrice[i + 1, j] == 0 && !Found)
            {
                AddRoute(i, j, "D");
            }

            if (baseMatrice[i, j - 1] == 0 && !Found)
            {
                AddRoute(i, j, "L");
            }

        }

        //verificação ultimo elemento/lines internas
        if (i != 0 && i != lines - 1 && j == columns - 1 && !Found)
        {
            if (baseMatrice[i - 1, j] == 0 && !Found)
            {
                AddRoute(i, j, "U");
            }

            if (baseMatrice[i, j - 1] == 0 && !Found)
            {
                AddRoute(i, j, "L");
            }

            if (baseMatrice[i + 1, j] == 0 && !Found)
            {
                AddRoute(i, j, "D");
            }
        }
        #endregion

        #region ultima linha
        //verificação primeiro elemento/ultima linha
        if (i == lines - 1 && j == 0 && !Found)
        {
            if (baseMatrice[i - 1, j] == 0 && !Found)
            {
                AddRoute(i, j, "U");
            }

            if (baseMatrice[i, j + 1] == 0 && !Found)
            {
                AddRoute(i, j, "R");
            }
        }

        //verificação segundo elemento(ateh penultino)/ultima linha
        if (i == lines - 1 && j != 0 && j != columns - 1 && !Found)
        {

            if (baseMatrice[i, j - 1] == 0 && !Found)
            {
                AddRoute(i, j, "L");
            }

            if (baseMatrice[i - 1, j] == 0 && !Found)
            {
                AddRoute(i, j, "U");
            }

            if (baseMatrice[i, j + 1] == 0 && !Found)
            {
                AddRoute(i, j, "R");
            }

        }
        #endregion
    }
    if (listPositionStepTmp.Count == 0) DeadEnd = true;
    listPositionSteps = listPositionStepTmp.ToList();
    listAllPositionSteps.Add(listPositionSteps);
    listPositionStepTmp.Clear();
    loopCounter++;
}
void CheckChangeAndResetCount(int i, int j)
{
    if (baseMatrice[i, j] == 0)
    {
        if (countGreen > 1 && countGreen < 5) tempMatrice[i, j] = 1;
        else if (countGreen <= 1 || countGreen >= 5) tempMatrice[i, j] = 0;
    }
    else // baseMatrice[i, j] == 1
    {
        if (countGreen <= 3 || countGreen >= 6) tempMatrice[i, j] = 0;
        else if (countGreen > 3 && countGreen < 6) tempMatrice[i, j] = 1;
    }
    countGreen = 0;
}

//void printMatrix(int[,] matrix, string name)
//{
//    Console.Write(name + "\n");

//    for (int i = 0; i < lines; i++)
//    {
//        for (int j = 0; j < columns; j++)
//        {

//            Console.Write(matrix[i, j].ToString() + " ");
//        }

//        Console.Write("\n");

//    }
//    Console.Write("\n");

//}
void AddRoute(int i, int j, string route)
{
    var lastPosition = (i, j);
    var newPosition = (i, j);
    switch (route)
    {
        case "D":
            newPosition.i += 1;
            break;
        case "R":
            newPosition.j += 1;
            break;
        case "L":
            newPosition.j -= 1;
            break;
        case "U":
            newPosition.i -= 1;
            break;
    }
    var tuple = new PositionStep(lastPosition, newPosition, route);
    listPositionStepTmp.Add(tuple);
    if (newPosition == Goal) Found = true;
}

async void GetPath()
{
    for (int i = listAllPositionSteps.Count - 1; i >= 0; i--)
    {
        for (int j = listAllPositionSteps[i].Count - 1; j >= 0; j--)
        {
            if (listAllPositionSteps[i][j].End == Goal)
            {
                route +=listAllPositionSteps[i][j].Step;
                lastIndex = j;
                break;
            }
            if (listAllPositionSteps[i + 1][lastIndex].Start == listAllPositionSteps[i][j].End)
            {
                route+=" " + listAllPositionSteps[i][j].Step;
                lastIndex = j;
                break;
            }
        }
    }
    Console.WriteLine($"{loopCounter} Steps to found a solution\r\n");

    char[] arr = route.ToString().ToCharArray();
    Array.Reverse(arr);
    Console.WriteLine("Steps:");
    Console.WriteLine(arr);
}
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
    public (int, int) Start { get; set; }
    public (int, int) End { get; set; }
    public string Step { get; set; }

    public PositionStep((int, int) start, (int, int) end, string step)
    {
        Start = start;
        End = end;
        Step = step;
    }
}