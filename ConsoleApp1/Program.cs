using System.Diagnostics;
using System.Text;

var watch = new Stopwatch();
watch.Start();
#region Global Variables
int countGreen = 0;
int[,] lastPosition = { { 0, 0 } };
int[,] currentPosition = { { 0, 0 } };
int loopCounter = 0;
List<List<(int[,], int[,], string, string)>> listAllPositionSteps = new List<List<(int[,], int[,], string, string)>>();
List<(int[,], int[,], string, string)> listPositionSteps = new List<(int[,], int[,], string, string)>
{
    (lastPosition,currentPosition,string.Empty,string.Empty)
};
var Reached = false;
#endregion

#region Setup Data Set
int lines;
int columns;
int[,] baseMatrice;

using (StreamReader reader = new StreamReader("C:\\Users\\felip\\OneDrive\\Área de Trabalho\\input.txt"))
{
    string line;
    List<int[]> rows = new List<int[]>();

    while ((line = reader.ReadLine()) != null)
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
        }
    }
    lines = numRows;
    columns = numCols;
}
int[,] tempMatrice = new int[lines, columns];
#endregion

while (Reached == false)
{
    StepExecute();
    baseMatrice = tempMatrice;
    baseMatrice.SetValue(0, 0, 0);
    baseMatrice.SetValue(0, lines - 1, columns - 1);
    //printMatrix(baseMatrice, "Matrix Temp");
    Reached = TryPath();
    baseMatrice[0, 0] = 3;
    baseMatrice[lines - 1, columns - 1] = 4;
    tempMatrice = new int[lines, columns];
}
watch.Stop();

Console.WriteLine($"\r\nExecution Time: {watch.ElapsedMilliseconds} ms");

//Methods
void StepExecute()
{
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {

            #region first line

            //verificação segundo elemento(ateh penultino)/primeira linha
            if (i.Equals(0) && j != 0 && j != columns - 1)
            {
                if (baseMatrice[i, j - 1].Equals(1)) countGreen++;

                if (baseMatrice[i + 1, j - 1].Equals(1)) countGreen++;

                if (baseMatrice[i + 1, j].Equals(1)) countGreen++;

                if (baseMatrice[i + 1, j + 1].Equals(1)) countGreen++;

                if (baseMatrice[i, j + 1].Equals(1)) countGreen++;

                CheckChangeAndResetCount(i, j);
            }

            //verificação ultimo elemento/primeira linha
            if (i.Equals(0) && j == columns - 1)
            {
                if (baseMatrice[i, j - 1].Equals(1)) countGreen++;

                if (baseMatrice[i + 1, j - 1].Equals(1)) countGreen++;

                if (baseMatrice[i + 1, j].Equals(1)) countGreen++;

                CheckChangeAndResetCount(i, j);
            }
            #endregion

            #region mid lines
            //verificação primeiro elemento/lines internas
            if (i != 0 && i != lines - 1 && j.Equals(0))
            {
                if (baseMatrice[i - 1, j].Equals(1)) countGreen++;

                if (baseMatrice[i - 1, j + 1].Equals(1)) countGreen++;

                if (baseMatrice[i, j + 1].Equals(1)) countGreen++;

                if (baseMatrice[i + 1, j + 1].Equals(1)) countGreen++;

                if (baseMatrice[i + 1, j].Equals(1)) countGreen++;

                CheckChangeAndResetCount(i, j);
            }

            //verificação segundo elemento(ateh penultino)/lines internas
            if (i != 0 && i != lines - 1 && j != 0 && j != columns - 1)
            {
                if (baseMatrice[i - 1, j - 1].Equals(1)) countGreen++;

                if (baseMatrice[i - 1, j].Equals(1)) countGreen++;

                if (baseMatrice[i - 1, j + 1].Equals(1)) countGreen++;

                if (baseMatrice[i, j - 1].Equals(1)) countGreen++;

                if (baseMatrice[i, j + 1].Equals(1)) countGreen++;

                if (baseMatrice[i + 1, j - 1].Equals(1)) countGreen++;

                if (baseMatrice[i + 1, j].Equals(1)) countGreen++;

                if (baseMatrice[i + 1, j + 1].Equals(1)) countGreen++;

                CheckChangeAndResetCount(i, j);
            }

            //verificação ultimo elemento/lines internas
            if (i != 0 && i != lines - 1 && j == columns - 1)
            {
                if (baseMatrice[i - 1, j].Equals(1)) countGreen++;

                if (baseMatrice[i - 1, j - 1].Equals(1)) countGreen++;

                if (baseMatrice[i, j - 1].Equals(1)) countGreen++;

                if (baseMatrice[i + 1, j - 1].Equals(1)) countGreen++;

                if (baseMatrice[i + 1, j].Equals(1)) countGreen++;

                CheckChangeAndResetCount(i, j);
            }
            #endregion

            #region last line
            //verificação primeiro elemento/ultima linha
            if (i == lines - 1 && j.Equals(0))
            {
                if (baseMatrice[i - 1, j].Equals(1)) countGreen++;

                if (baseMatrice[i - 1, j + 1].Equals(1)) countGreen++;

                if (baseMatrice[i, j + 1].Equals(1)) countGreen++;

                CheckChangeAndResetCount(i, j);
            }

            //verificação segundo elemento(ateh penultino)/ultima linha
            if (i == lines - 1 && j != 0 && j != columns - 1)
            {
                if (baseMatrice[i, j - 1].Equals(1)) countGreen++;

                if (baseMatrice[i - 1, j - 1].Equals(1)) countGreen++;

                if (baseMatrice[i - 1, j].Equals(1)) countGreen++;

                if (baseMatrice[i - 1, j + 1].Equals(1)) countGreen++;

                if (baseMatrice[i, j + 1].Equals(1)) countGreen++;

                CheckChangeAndResetCount(i, j);
            }

            //verificação ultimo elemento/ultima linha
            //if (i == lines - 1 && j == columns - 1)
            //{
            //    if (baseMatrice[i, j - 1].Equals(1)) countGreen++;

            //    if (baseMatrice[i - 1, j - 1].Equals(1)) countGreen++;

            //    if (baseMatrice[i - 1, j].Equals(1)) countGreen++;

            //    CheckChangeAndResetCount(i, j);

            //}
            #endregion
        }

    }

}
bool TryPath()
{
    //item1 eh posicao anterior, item2 eh posicao atual, item3 é o movimento e item4 eh o item2 em tostring
    var listPositionStepTmp = new List<(int[,], int[,], string,string)>();
    foreach (var t in listPositionSteps)
    {

        int i = t.Item2[0,0];
        int j = t.Item2[0,1];
        int[,] lastPosition = { { i, j } };

        #region primeira linha
        //verificação primeiro elemento/primeira linha
        if (i.Equals(0) && j.Equals(0))
        {

            if (baseMatrice[i + 1, j].Equals(0))
            {
                AddRoute(i, j, "D", listPositionStepTmp);
            }

            if (baseMatrice[i, j + 1].Equals(0))
            {
                AddRoute(i, j, "R", listPositionStepTmp);
            }
        }

        //verificação segundo elemento(ateh penultino)/primeira linha
        if (i.Equals(0) && j != 0 && j != columns - 1)
        {
            int[,] posicaoNova = {{ i, j }};

            if (baseMatrice[i + 1, j].Equals(0))
            {
                AddRoute(i, j, "D", listPositionStepTmp);
            }

            if (baseMatrice[i, j + 1].Equals(0))
            {
                AddRoute(i, j, "R", listPositionStepTmp);
            }

            if (baseMatrice[i, j - 1].Equals(0))
            {
                AddRoute(i, j, "L", listPositionStepTmp);
            }
        }

        //verificação ultimo elemento/primeira linha
        if (i.Equals(0) && j == columns - 1)
        {
            int[,] posicaoNova = {{ i, j }};

            if (baseMatrice[i + 1, j].Equals(0))
            {
                AddRoute(i, j, "D", listPositionStepTmp);
            }

            if (baseMatrice[i, j - 1].Equals(0))
            {
                AddRoute(i, j, "L", listPositionStepTmp);
            }
        }
        #endregion

        #region lines do meio
        //verificação primeiro elemento/lines internas
        if (i != 0 && i != lines - 1 && j.Equals(0))
        {
            int[,] posicaoNova = {{ i, j }};

            if (baseMatrice[i + 1, j].Equals(0))
            {
                AddRoute(i, j, "D", listPositionStepTmp);
            }

            if (baseMatrice[i - 1, j].Equals(0))
            {
                AddRoute(i, j, "U", listPositionStepTmp);
            }


            if (baseMatrice[i, j + 1].Equals(0))
            {
                AddRoute(i, j, "R", listPositionStepTmp);
            }
        }

        //verificação segundo elemento(ateh penultino)/lines internas
        if (i != 0 && i != lines - 1 && j != 0 && j != columns - 1)
        {

            if (baseMatrice[i - 1, j].Equals(0))
            {
                int[,] posicaoNova = {{ i, j }};
                posicaoNova[0,0] = i - 1;
                posicaoNova[0,1] = j;
                var positionCheck = posicaoNova[0,0] + "," + posicaoNova[0,1];
                listPositionStepTmp.Add((lastPosition, posicaoNova, "U", positionCheck));
            }

            if (baseMatrice[i, j + 1].Equals(0))
            {
                int[,] posicaoNova = {{ i, j }};
                posicaoNova[0,0] = i;
                posicaoNova[0,1] = j + 1;
                var positionCheck = posicaoNova[0,0] + "," + posicaoNova[0,1];
                listPositionStepTmp.Add((lastPosition, posicaoNova, "R", positionCheck));
            }

            if (baseMatrice[i + 1, j].Equals(0))
            {
                int[,] posicaoNova = {{ i, j }};
                posicaoNova[0,0] = i + 1;
                posicaoNova[0,1] = j;
                //lastPosition.Append(0);
                var positionCheck = posicaoNova[0,0] + "," + posicaoNova[0,1];
                listPositionStepTmp.Add((lastPosition, posicaoNova, "D", positionCheck));
            }

            if (baseMatrice[i, j - 1].Equals(0))
            {
                int[,] posicaoNova = {{ i, j }};
                posicaoNova[0,0] = i;
                posicaoNova[0,1] = j - 1;
                //lastPosition.Append(0);
                var positionCheck = posicaoNova[0,0] + "," + posicaoNova[0,1];
                listPositionStepTmp.Add((lastPosition, posicaoNova, "L", positionCheck));
            }

        }

        //verificação ultimo elemento/lines internas
        if (i != 0 && i != lines - 1 && j == columns - 1)
        {
            int[,] posicaoNova = {{ i, j }};
            if (baseMatrice[i - 1, j].Equals(0))
            {
                AddRoute(i, j, "U", listPositionStepTmp);
            }

            if (baseMatrice[i, j - 1].Equals(0))
            {
                AddRoute(i, j, "L", listPositionStepTmp);
            }

            if (baseMatrice[i + 1, j].Equals(0))
            {
                AddRoute(i, j, "D", listPositionStepTmp);
            }
        }
        #endregion

        #region ultima linha
        //verificação primeiro elemento/ultima linha
        if (i == lines - 1 && j.Equals(0))
        {
            int[,] posicaoNova = {{ i, j }};
            if (baseMatrice[i - 1, j].Equals(0))
            {
                AddRoute(i, j, "U", listPositionStepTmp);
            }

            if (baseMatrice[i, j + 1].Equals(0))
            {
                AddRoute(i, j, "R", listPositionStepTmp);
            }
        }

        //verificação segundo elemento(ateh penultino)/ultima linha
        if (i == lines - 1 && j != 0 && j != columns - 1)
        {

            int[,] posicaoNova = {{ i, j }};
            if (baseMatrice[i, j - 1].Equals(0))
            {
                AddRoute(i, j, "L", listPositionStepTmp);
            }

            if (baseMatrice[i - 1, j].Equals(0))
            {
                posicaoNova[0,0] = i - 1;
                posicaoNova[0,1] = j;
                var positionCheck = posicaoNova[0,0] + "," + posicaoNova[0,1];
                listPositionStepTmp.Add((lastPosition, posicaoNova, "U", positionCheck));
            }

            if (baseMatrice[i, j + 1].Equals(0))
            {
                posicaoNova[0,0] = i;
                posicaoNova[0,1] = j + 1;
                var positionCheck = posicaoNova[0,0] + "," + posicaoNova[0,1];
                listPositionStepTmp.Add((lastPosition, posicaoNova, "R", positionCheck));
            }
        }

        #endregion
    }
    HashSet<(int[,], int[,],string, string)> distinctSet = new HashSet<(int[,], int[,],string, string)>(new TupleEqualityComparer());

    foreach (var position in listPositionStepTmp)
    {
        distinctSet.Add(position);
    }

    List<(int[,], int[,],string, string)> distinctList = distinctSet.ToList(); 

    listPositionSteps = distinctList;
    listAllPositionSteps.Add(listPositionSteps);
    foreach (var SuccessTestLoop in listAllPositionSteps.Last())
    {
        if (SuccessTestLoop.Item4 == $"{lines - 1},{columns - 1}")
       {
            StringBuilder route = new StringBuilder();
            int lastIndex = 0;
            for (int i = listAllPositionSteps.Count - 1; i >= 0; i--)
            {
                for(int j = listAllPositionSteps[i].Count - 1; j>=0; j--)
                {
                    if (listAllPositionSteps[i][j].Item4 == $"{lines - 1},{columns - 1}")
                    {
                        route.Append(listAllPositionSteps[i][j].Item3);
                        lastIndex = j;
                        break;
                    }
                    if (listAllPositionSteps[i + 1][lastIndex].Item1[0,0] == (listAllPositionSteps[i][j].Item2[0,0]) && 
                        listAllPositionSteps[i + 1][lastIndex].Item1[0, 1] == listAllPositionSteps[i][j].Item2[0, 1])
                    {
                        route.Append(" "+listAllPositionSteps[i][j].Item3);
                        lastIndex = j;
                        break;
                    }
                }
            }
            Console.WriteLine($"{loopCounter + 1} Steps to found a solution\r\n");
           
            char[] arr = route.ToString().ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine("Steps:");
            Console.WriteLine(arr);
            return true;
        }
    }
    loopCounter++;
    return false;
}
void CheckChangeAndResetCount(int i, int j)
{
    if (baseMatrice[i, j] == 0 && countGreen > 1 && countGreen < 5) tempMatrice.SetValue(1, i, j);
    if (baseMatrice[i, j] == 0 && countGreen <= 1 && countGreen >= 5) tempMatrice.SetValue(0,i, j);
    if (baseMatrice[i, j] == 1 && countGreen <= 3 && countGreen >= 6) tempMatrice.SetValue(0, i, j);
    if (baseMatrice[i, j] == 1 && countGreen > 3 && countGreen < 6) tempMatrice.SetValue(1, i, j);
    countGreen = 0;
}
void printMatrix(int[,] matrix, string name)
{
    Console.Write(name + "\n");

    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {

            Console.Write(matrix[i, j].ToString() + " ");
        }

        Console.Write("\n");

    }
    Console.Write("\n");

}
void AddRoute(int i, int j, string route, List<(int[,], int[,], string,string)> listaPosition)
{
    int[,] lastPosition = { { i, j } };

    if (baseMatrice[i, j].Equals(0))
    {
        int[,] newPosition = { { i, j } };
        newPosition[0, 0] += (route == "D") ? 1 : (route== "R" || route == "L") ? 0 : -1;
        newPosition[0, 1] += (route == "R") ? 1 : (route == "U" || route == "D") ? 0 : -1;
        StringBuilder positionCheck = new StringBuilder();
        positionCheck.Append(newPosition[0, 0]).Append(",").Append(newPosition[0, 1]);
        var tuple = (lastPosition, newPosition, route, positionCheck.ToString());
        listaPosition.Add(tuple);        
    }
}
public class TupleEqualityComparer : IEqualityComparer<(int[,], int[,], string,string)>
{
    public bool Equals((int[,], int[,], string,string) x, (int[,], int[,], string,string) y)
    {
        return x.Item4.Equals(y.Item4);
    }

    public int GetHashCode((int[,], int[,], string,string) obj)
    {
        return obj.Item4.GetHashCode();
    }
}