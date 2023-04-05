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
int lastIndex = 0;
int loopCounter = 0;
(int,int) checkpoint = (0, 0);
int midLoopCounter = 0;
StringBuilder tempRoute = new StringBuilder();
StringBuilder endRoute = new StringBuilder();
string route = string.Empty;
HashSet<PositionStep> listPositionStepTmp = new HashSet<PositionStep>(new TupleEqualityComparer());
//List <(int,int)> teste = new List<(int,int)>();

#endregion

#region Setup Data Set

uint[][] baseMatrice;
ReadFileToMatrix();
List<List<PositionStep>> listAllPositionSteps = new List<List<PositionStep>>()
{
    new List<PositionStep>()
    {
        new PositionStep{End = Start,Start=Start, Step = string.Empty}
    }
};
int lines;
int columns;
uint[][] tempMatrice = new uint[lines + 2][];
for (int i = 0; i < baseMatrice.Length; i++)
{
    tempMatrice[i] = new uint[columns + 2];
}

#endregion

startAgain:
while (!Found && !DeadEnd)
{
    baseMatrice[Start.Item1][Start.Item2] = 0;
    baseMatrice[Goal.Item1][Goal.Item2] = 0;
    StepExecute();
    tempMatrice[Start.Item1][Start.Item2] = 0;
    tempMatrice[Goal.Item1][Goal.Item2] = 0;
    baseMatrice = tempMatrice;
    TryPath();
    tempMatrice = new uint[lines + 2][];
    for (int i = 0; i < baseMatrice.Length; i++)
    {
        tempMatrice[i] = new uint[columns + 2];
    }
    if(checkpoint != (0, 0) && checkpoint != Goal)
    {
        break;
    }
}
if (DeadEnd) Console.WriteLine("No Paths Available!");
else
{
    if (checkpoint != (0, 0) && midLoopCounter == 0)
    {
        GetMidPath();
        listAllPositionSteps.Clear();
        listAllPositionSteps = new List<List<PositionStep>>()
{
    new List<PositionStep>()
    {
        new PositionStep{End = checkpoint,Start=Start, Step = string.Empty}
    }
};
        //Start = checkpoint;
        checkpoint = (0,0);
        midLoopCounter += 1;
        loopCounter= 0;
        
        goto startAgain;
    }
    if (checkpoint != (0, 0) && midLoopCounter == 1)
    {
        GetMidPath();
        listAllPositionSteps.Clear();
        listAllPositionSteps = new List<List<PositionStep>>()
{
    new List<PositionStep>()
    {
        new PositionStep{End = checkpoint,Start=Start, Step = string.Empty}
    }
};
        //Start = checkpoint;
        checkpoint = (0,0);
        midLoopCounter += 1;
        loopCounter = 0;

        goto startAgain;
    }
    if (checkpoint != (0, 0) && midLoopCounter == 2)
    {
        GetMidPath();
        listAllPositionSteps.Clear();
        listAllPositionSteps = new List<List<PositionStep>>()
{
    new List<PositionStep>()
    {
        new PositionStep{End = checkpoint,Start=Start, Step = string.Empty}
    }
};
        //Start = checkpoint;
        checkpoint = (0,0);
        midLoopCounter += 1;
        loopCounter = 0;

        goto startAgain;
    }
    GetLastPath();
}
watch.Stop();

Console.WriteLine($"\r\nExecution Time: {watch.ElapsedMilliseconds} ms");


//Methods

void GetLastPath()
{
    //getpath
    for (int i = listAllPositionSteps.Count - 1; i >= 0; i--)
    {
        for (int j = listAllPositionSteps[i].Count - 1; j >= 0; j--)
        {
            if (listAllPositionSteps[i][j].End == Goal)
            {
                route += " "+listAllPositionSteps[i][j].Step;
                lastIndex = j;
                break;
            }
            if (listAllPositionSteps[i + 1][lastIndex].Start == listAllPositionSteps[i][j].End)
            {
                route += " " + listAllPositionSteps[i][j].Step;
                lastIndex = j;
                break;
            }
        }
    }
    //Console.WriteLine($"{loopCounter+midLoopCounter} Steps to found a solution\r\n");

    char[] arr = route.ToString().ToCharArray();
    Array.Reverse(arr);
    endRoute.Append(arr);
    Console.WriteLine("Steps:");
    Console.WriteLine(endRoute.Replace("  "," "));
}

void GetMidPath()
{
    //getpath
    for (int i = listAllPositionSteps.Count - 1; i >= 0; i--)
    {
        for (int j = listAllPositionSteps[i].Count - 1; j >= 0; j--)
        {
            if (listAllPositionSteps[i][j].End == checkpoint)
            {
                if (midLoopCounter > 0)
                {
                    tempRoute.Append(" "+listAllPositionSteps[i][j].Step);

                }
                else
                {
                    tempRoute.Append(listAllPositionSteps[i][j].Step);
                }
                lastIndex = j;
                Start = listAllPositionSteps[i][j].Start;
                break;
            }
            if (listAllPositionSteps[i + 1][lastIndex].Start == listAllPositionSteps[i][j].End)
            {
                tempRoute.Append(" " + listAllPositionSteps[i][j].Step);
                lastIndex = j;
                Start = listAllPositionSteps[i][j].Start;
                break;
            }
        }
    }
    char[] arr = tempRoute.ToString().ToCharArray();
    Array.Reverse(arr);
    endRoute.Append(arr);
    tempRoute.Clear();

}
void StepExecute()
{
    for (int i = 1; i <= lines; i++)
    {
        for (int j = 1; j <= columns; j++)
        {
            uint countGreen = baseMatrice[i - 1][j - 1] + baseMatrice[i - 1][j] + baseMatrice[i - 1][j + 1] + baseMatrice[i][j - 1] + baseMatrice[i][j + 1] + baseMatrice[i + 1][j - 1] + baseMatrice[i + 1][j] + baseMatrice[i + 1][j + 1];
            if (baseMatrice[i][j] == 0)
            {
                if (countGreen > 1 && countGreen < 5) tempMatrice[i][j] = 1;
                else { tempMatrice[i][j] = 0; }
            }
            else
            {
                if (countGreen <= 3 || countGreen >= 6) tempMatrice[i][j] = 0;
                else { tempMatrice[i][j] = 1; }
            }
        }
    }
}

void TryPath()
{
    //item1 eh posicao anterior, item2 eh posicao atual, item3 é o movimento
    listAllPositionSteps[loopCounter].ForEach(t =>
    {

        var i = t.End;

        #region primeira linha

        uint down = baseMatrice[i.Item1 + 1][i.Item2];
        uint up = baseMatrice[i.Item1 - 1][i.Item2];
        uint left = baseMatrice[i.Item1][i.Item2 - 1];
        uint right = baseMatrice[i.Item1][i.Item2 + 1];
        //verificação primeiro elemento/primeira linha
        if (i == (1, 1))
        {

            if (down == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "D");


            if (right == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "R");

        }

        //verificação segundo elemento(ateh penultino)/primeira linha
        if (i.Item1 == 1 && i.Item2 != 1 && i.Item2 != columns)
        {

            if (down == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "D");


            if (right == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "R");


            if (left == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "L");

        }

        //verificação ultimo elemento/primeira linha
        if (i == (1, columns))
        {

            if (down == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "D");


            if (left == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "L");

        }
        #endregion

        #region lines do meio
        //verificação primeiro elemento/lines internas
        if (i.Item1 != 1 && i.Item1 != lines && i.Item2 == 1)
        {

            if (down == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "D");


            if (up == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "U");


            if (right == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "R");

        }

        //verificação segundo elemento(ateh penultino)/lines internas
        if (i.Item1 != 1 && i.Item1 != lines && i.Item2 != 1 && i.Item2 != columns)
        {

            if (up == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "U");


            if (right == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "R");


            if (down == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "D");


            if (left == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "L");


        }

        //verificação ultimo elemento/lines internas
        if (i.Item1 != 1 && i.Item1 != lines && i.Item2 == columns)
        {
            if (up == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "U");


            if (left == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "L");


            if (down == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "D");

        }
        #endregion

        #region ultima linha
        //verificação primeiro elemento/ultima linha
        if (i == (lines, 1))
        {
            if (up == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "U");


            if (right == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "R");

        }

        //verificação segundo elemento(ateh penultino)/ultima linha
        if (i.Item1 == lines && i.Item2 != 1 && i.Item2 != columns)
        {

            if (left == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "L");


            if (up == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "U");


            if (right == 0 && !Found && checkpoint == (0,0))

                AddRoute(i, "R");

        }
        #endregion
        //if (countDeadEnd == 0)
        //{
        //    teste.Add((i, j));
        //}
        //countDeadEnd= 0;

    });
    //teste.ForEach(x =>
    //{
    //    (int, int) lastIndex1 = x;
    //    for (int q = listAllPositionSteps.Count - 1; q >= 0; q--)
    //    {
    //        for (int w = listAllPositionSteps[q].Count - 1; w >= 0; w--)
    //        {

    //            if (listAllPositionSteps[q][w].End == lastIndex1)
    //            {
    //                lastIndex1 = listAllPositionSteps[q][w].Start;
    //                listAllPositionSteps[q].RemoveAt(w);
    //                return;
    //            }
    //        }
    //    }
    //});
    //teste.Clear();
    DeadEnd = listPositionStepTmp?.Count == 0;
    listAllPositionSteps.Add(listPositionStepTmp.ToList());
    listPositionStepTmp.Clear();
    //Console.WriteLine(listAllPositionSteps[loopCounter].Last().End);
    loopCounter++;
    //Console.WriteLine(loopCounter);
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
void AddRoute((int, int) lastPosition, string route)
{
    var newPosition = lastPosition;
    switch (route)
    {
        case "D":
            newPosition.Item1 += 1;
            break;
        case "R":
            newPosition.Item2 += 1;
            break;
        case "L":
            newPosition.Item2 -= 1;
            break;
        case "U":
            newPosition.Item1 -= 1;
            break;
    }
    var tuple = new PositionStep { End = newPosition, Start = lastPosition, Step = route };
    //countDeadEnd++;
    listPositionStepTmp.Add(tuple);
    if (newPosition == (lines/4,columns/4) && midLoopCounter == 0) 
    {
        checkpoint = newPosition;
    }
    if (newPosition == (900, 900) && midLoopCounter == 1)
    {
        checkpoint = newPosition;
    }    
    if (newPosition == (1300, 1300) && midLoopCounter == 2)
    {
        checkpoint = newPosition;
    }

    Found = newPosition == Goal;
}

void ReadFileToMatrix()
{

    //using (FileStream fileStream = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "input.txt"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
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
        for (int i = 0; i < baseMatrice.Length; i++)
        {
            baseMatrice[i] = new uint[columns + 2];
        }

        // Read and parse lines
        for (int row = 1; row <= lines; row++)
        {
            string[] values = FileLines[row - 1].Split(' ');
            for (int col = 1; col <= columns; col++)
            {
                if (uint.TryParse(values[col - 1], NumberStyles.None, CultureInfo.InvariantCulture, out uint value))
                {
                    baseMatrice[row][col] = value;
                    if (value == 3) Start = (row, col);
                    if (value == 4) Goal = (row, col);
                }
            }
        }
    }
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
}






//PARTE COM A BORDA CRIADA

//using System.Diagnostics;
//using System.Globalization;
//using System.Text;

//var watch = new Stopwatch();
//watch.Start();
//#region Global Variables
//(int, int) Goal = (0, 0);
//(int, int) Start = (0, 0);
//bool DeadEnd = false;
//bool Found = false;
//int lastIndex = 0;
//int loopCounter = 0;
//int countDeadEnd = 0;
//string route = string.Empty;

//HashSet<PositionStep> listPositionStepTmp = new HashSet<PositionStep>(new TupleEqualityComparer());

//#endregion

//#region Setup Data Set

//int[][] baseMatrice;
//ReadFileToMatrix();
//List<List<PositionStep>> listAllPositionSteps = new List<List<PositionStep>>()
//{
//    new List<PositionStep>()
//    {
//        new PositionStep{End = Start,Start=Start, Step = string.Empty}
//    }
//};
//int lines;
//int columns;
//int[][] tempMatrice = new int[lines + 2][];

//#endregion

//while (!Found && !DeadEnd)
//{
//    //generate new temporary matrice
//    tempMatrice = new int[lines + 2][];
//    for (int i = 0; i < baseMatrice.Length; i++)
//    {
//        tempMatrice[i] = new int[columns + 2];
//    }
//    for (int j = 0; j <= columns + 1; j++)
//    {
//        tempMatrice[0][j] = 3; // top border
//        tempMatrice[lines + 1][j] = 3; // bottom border
//    }
//    for (int i = 1; i <= lines + 1; i++)
//    {
//        tempMatrice[i][0] = 3; // left border
//        tempMatrice[i][columns + 1] = 3; // right border
//    }
//    //end gen

//    //start and goal set to 0 to not mess with the stepexecute
//    baseMatrice[Start.Item1][Start.Item2] = 0;
//    baseMatrice[Goal.Item1][Goal.Item2] = 0;

//    //stepexecute begin
//    for (int i = 1; i <= lines; i++)
//    {
//        for (int j = 1; j <= columns; j++)
//        {
//            int countGreen = baseMatrice[i - 1][j - 1] + baseMatrice[i - 1][j] + baseMatrice[i - 1][j + 1] + baseMatrice[i][j - 1] + baseMatrice[i][j + 1] + baseMatrice[i + 1][j - 1] + baseMatrice[i + 1][j] + baseMatrice[i + 1][j + 1];
//            if (countGreen >= 15)
//            {
//                countGreen -= 15;
//            }
//            else if (countGreen > 8)
//            {
//                countGreen -= 9;
//            }
//            if (baseMatrice[i][j] == 0)
//            {
//                if (countGreen > 1 && countGreen < 5) tempMatrice[i][j] = 1;
//                else { tempMatrice[i][j] = 0; }
//            }
//            else
//            {
//                if (countGreen <= 3 || countGreen >= 6) tempMatrice[i][j] = 0;
//                else { tempMatrice[i][j] = 1; }
//            }
//        }
//    }
//    //stepexecute end

//    tempMatrice[Start.Item1][Start.Item2] = 0;
//    tempMatrice[Goal.Item1][Goal.Item2] = 0;
//    baseMatrice = tempMatrice;
//    TryPath();
//}
//if (DeadEnd) Console.WriteLine("No Paths Available!");
//else
//{
//    //getpath
//    for (int i = listAllPositionSteps.Count - 1; i >= 0; i--)
//    {
//        for (int j = listAllPositionSteps[i].Count - 1; j >= 0; j--)
//        {
//            if (listAllPositionSteps[i][j].End == Goal)
//            {
//                route += listAllPositionSteps[i][j].Step;
//                lastIndex = j;
//                break;
//            }
//            if (listAllPositionSteps[i + 1][lastIndex].Start == listAllPositionSteps[i][j].End)
//            {
//                route += " " + listAllPositionSteps[i][j].Step;
//                lastIndex = j;
//                break;
//            }
//        }
//    }
//    Console.WriteLine($"{loopCounter} Steps to found a solution\r\n");

//    char[] arr = route.ToString().ToCharArray();
//    Array.Reverse(arr);
//    Console.WriteLine("Steps:");
//    Console.WriteLine(arr);
//}
//watch.Stop();

//Console.WriteLine($"\r\nExecution Time: {watch.ElapsedMilliseconds} ms");


////Methods
////void StepExecute()
////{

////}

//void TryPath()
//{
//    //item1 eh posicao anterior, item2 eh posicao atual, item3 é o movimento
//    listAllPositionSteps[loopCounter].ForEach(t =>
//    {
//        if (baseMatrice[t.End.Item1][t.End.Item2 - 1] == 0 && !Found && checkpoint == (0,0)) AddRoute(t.End, "L");

//        if (baseMatrice[t.End.Item1 - 1][t.End.Item2] == 0 && !Found && checkpoint == (0,0)) AddRoute(t.End, "U");

//        if (baseMatrice[t.End.Item1][t.End.Item2 + 1] == 0 && !Found && checkpoint == (0,0)) AddRoute(t.End, "R");

//        if (baseMatrice[t.End.Item1 + 1][t.End.Item2] == 0 && !Found && checkpoint == (0,0)) AddRoute(t.End, "D");
//    });

//    DeadEnd = listPositionStepTmp?.Count == 0;
//    listAllPositionSteps.Add(listPositionStepTmp.ToList());
//    listPositionStepTmp.Clear();
//    Console.WriteLine(listAllPositionSteps[loopCounter].Last().End);
//    loopCounter++;
//    Console.WriteLine(loopCounter);
//}

///*void printMatrix(int[][] matrix, string name)
//{
//    Console.Write(name + "\n");

//    for (int i = 0; i < lines + 2; i++)
//    {
//        for (int j = 0; j < columns + 2; j++)
//        {

//            Console.Write(matrix[i][j].ToString() + " ");
//        }

//        Console.Write("\n");

//    }
//    Console.Write("\n");

//}*/
//void AddRoute((int, int) lastPosition, string route)
//{
//    //var lastPosition = j;
//    var newPosition = lastPosition;
//    switch (route)
//    {
//        case "D":
//            newPosition.Item1 += 1;
//            break;
//        case "R":
//            newPosition.Item2 += 1;
//            break;
//        case "L":
//            newPosition.Item2 -= 1;
//            break;
//        case "U":
//            newPosition.Item1 -= 1;
//            break;
//    }
//    var tuple = new PositionStep { End = newPosition, Start = lastPosition, Step = route };
//    //countDeadEnd++;
//    listPositionStepTmp.Add(tuple);
//    Found = newPosition == Goal;
//}

//void ReadFileToMatrix()
//{
//    //using (FileStream fileStream = new FileStream("C:\\Users\\felip\\OneDrive\\Área de Trabalho\\input.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
//    //using (FileStream fileStream = new FileStream("C:\\Users\\41140878859\\Desktop\\projetos_git\\stone-automata-maze-challenge\\input.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
//    using (FileStream fileStream = new FileStream("E:\\Git pessoal\\stone-automata-maze-challenge\\input.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
//    {
//        // Construct the input string
//        StringBuilder inputBuilder = new StringBuilder();
//        byte[] buffer = new byte[1024];
//        int bytesRead;
//        while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
//        {
//            string chunk = Encoding.ASCII.GetString(buffer, 0, bytesRead);
//            inputBuilder.Append(chunk);
//        }
//        string input = inputBuilder.ToString();

//        // Get matrix dimensions from input contents
//        string[] FileLines = input.Trim().Split('\n');
//        columns = FileLines[0].Split(' ').Length;
//        lines = FileLines.Length;

//        // Create new jagged array with border
//        baseMatrice = new int[lines + 2][];
//        for (int i = 0; i < baseMatrice.Length; i++)
//        {
//            baseMatrice[i] = new int[columns + 2];
//        }

//        // Read and parse lines
//        for (int row = 1; row <= lines; row++)
//        {
//            string[] values = FileLines[row - 1].Split(' ');
//            for (int col = 1; col <= columns; col++)
//            {
//                if (int.TryParse(values[col - 1], NumberStyles.None, CultureInfo.InvariantCulture, out int value))
//                {
//                    baseMatrice[row][col] = value;
//                    if (value == 3) Start = (row, col);
//                    if (value == 4) Goal = (row, col);
//                }
//            }
//        }
//        for (int j = 0; j <= columns + 1; j++)
//        {
//            baseMatrice[0][j] = 3; // top border
//            baseMatrice[lines + 1][j] = 3; // bottom border
//        }
//        for (int i = 1; i <= lines + 1; i++)
//        {
//            baseMatrice[i][0] = 3; // left border
//            baseMatrice[i][columns + 1] = 3; // right border
//        }
//    }
//}
//public class TupleEqualityComparer : IEqualityComparer<PositionStep>
//{
//    public bool Equals(PositionStep x, PositionStep y)
//    {
//        return x.End.Equals(y.End);
//    }

//    public int GetHashCode(PositionStep obj)
//    {
//        return obj.End.GetHashCode();
//    }
//}
//public struct PositionStep
//{
//    public (int, int) Start { get; set; }
//    public (int, int) End { get; set; }
//    public string Step { get; set; }
//}