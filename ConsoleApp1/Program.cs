var watch = new System.Diagnostics.Stopwatch();

watch.Start();
int countGreen = 0;


#region Setup Data Set
#region Data Set Original

int[,] matrizPrincipal = new int[65, 85] {
{3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4} };
int colunas = 85;
int linhas = 65;
//int[,] matrizTemp = new int[linhas, colunas];

#endregion


//int linhas = 3;
//int colunas = 3;
//int[,] matrizPrincipal = new int[3, 3]
//{
//    { 3 , 0 , 0 },
//    { 0 , 1 , 0 },
//    { 0 , 0 , 0 }
//};

//int linhas = 4;
//int colunas = 4;
//int[,] matrizPrincipal = new int[4, 4]
//{
//    { 3 , 1 , 0 , 0 },
//    { 0 , 0 , 1 , 0 },
//    { 1 , 0 , 0 , 0 },
//    { 0 , 1 , 0 , 4 }
//};

int[,] matrizPrincipal1 = new int[linhas, colunas];
matrizPrincipal1 = (int[,])matrizPrincipal.Clone();
int[,] matrizTemp = new int[linhas, colunas];
#endregion

//1 é verde, 0 é branco

int stepCount = 1000;
int[] positionYellow = { 0, 0 };
int contador = 0;

string[] rota = {"Início"};
//List<(List<int[]>, List<string[]>)> listPositionYellow = new List<(List<int[]>, List<string[]>)>
List<(List<int[]>,List<int[]>, List<string>,string)> listPositionYellow = new List<(List<int[]>, List<int[]>, List<string>,string)>
{
    (new List<int[]>{positionYellow },new List<int[]>{positionYellow }, new List<string> {"Início"},"")
};
List<string> route = new();
int routeBestTry = 0;
//IList<Eligible> eligible = new List<Eligible>();
Random rnd = new Random();

//printMatrix(matrizPrincipal, "Matrix Inicial");

//for (int i = 0; i < stepCount; i++)
var Reached = false;
while (Reached == false)
{

    //eligible.Clear();
    StepExecute();
    matrizPrincipal = matrizTemp;
    matrizPrincipal[0, 0] = 0;
    matrizPrincipal[linhas-1,colunas-1] = 0;
    Reached = TryPath();
    matrizPrincipal[0, 0] = 3;
    matrizPrincipal[linhas - 1, colunas - 1] = 4;

    matrizTemp = new int[linhas, colunas];
}
watch.Stop();

Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
Console.ReadLine();

//Methods
void StepExecute()
{
    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < colunas; j++)
        {
            //get yellow position
            if (matrizPrincipal[i, j].Equals(3))
            {
                positionYellow[0] = i;
                positionYellow[1] = j;
            }
            #region primeira linha
            //verificação primeiro elemento/primeira linha
            //if (i == 0 && j == 0)
            //{
            //    if (matrizPrincipal[i + 1, j] == 1) countGreen++;

            //    if (matrizPrincipal[i + 1, j + 1] == 1) countGreen++;

            //    if (matrizPrincipal[i, j + 1] == 1) countGreen++;

            //    CheckChangeAndResetCount(i, j);
            //}

            //verificação segundo elemento(ateh penultino)/primeira linha
            if (i == 0 && j != 0 && j != colunas - 1)
            {
                if (matrizPrincipal[i, j - 1] == 1) countGreen++;

                if (matrizPrincipal[i + 1, j - 1] == 1) countGreen++;

                if (matrizPrincipal[i + 1, j] == 1) countGreen++;

                if (matrizPrincipal[i + 1, j + 1] == 1) countGreen++;

                if (matrizPrincipal[i, j + 1] == 1) countGreen++;

                CheckChangeAndResetCount(i, j);
            }

            //verificação ultimo elemento/primeira linha
            if (i == 0 && j == colunas - 1)
            {
                if (matrizPrincipal[i, j - 1] == 1) countGreen++;

                if (matrizPrincipal[i + 1, j - 1] == 1) countGreen++;

                if (matrizPrincipal[i + 1, j] == 1) countGreen++;

                CheckChangeAndResetCount(i, j);
            }
            #endregion

            #region linhas do meio
            //verificação primeiro elemento/linhas internas
            if (i != 0 && i != linhas - 1 && j == 0)
            {
                if (matrizPrincipal[i - 1, j] == 1) countGreen++;

                if (matrizPrincipal[i - 1, j + 1] == 1) countGreen++;

                if (matrizPrincipal[i, j + 1] == 1) countGreen++;

                if (matrizPrincipal[i + 1, j + 1] == 1) countGreen++;

                if (matrizPrincipal[i + 1, j] == 1) countGreen++;

                CheckChangeAndResetCount(i, j);
            }

            //verificação segundo elemento(ateh penultino)/linhas internas
            if (i != 0 && i != linhas - 1 && j != 0 && j != colunas - 1)
            {
                if (matrizPrincipal[i - 1, j - 1] == 1) countGreen++;

                if (matrizPrincipal[i - 1, j] == 1) countGreen++;

                if (matrizPrincipal[i - 1, j + 1] == 1) countGreen++;

                if (matrizPrincipal[i, j - 1] == 1) countGreen++;

                if (matrizPrincipal[i, j + 1] == 1) countGreen++;

                if (matrizPrincipal[i + 1, j - 1] == 1) countGreen++;

                if (matrizPrincipal[i + 1, j] == 1) countGreen++;

                if (matrizPrincipal[i + 1, j + 1] == 1) countGreen++;

                CheckChangeAndResetCount(i, j);
            }

            //verificação ultimo elemento/linhas internas
            if (i != 0 && i != linhas - 1 && j == colunas - 1)
            {
                if (matrizPrincipal[i - 1, j] == 1) countGreen++;

                if (matrizPrincipal[i - 1, j - 1] == 1) countGreen++;

                if (matrizPrincipal[i, j - 1] == 1) countGreen++;

                if (matrizPrincipal[i + 1, j - 1] == 1) countGreen++;

                if (matrizPrincipal[i + 1, j] == 1) countGreen++;

                CheckChangeAndResetCount(i, j);
            }
            #endregion

            #region ultima linha
            //verificação primeiro elemento/ultima linha
            if (i == linhas - 1 && j == 0)
            {
                if (matrizPrincipal[i - 1, j] == 1) countGreen++;

                if (matrizPrincipal[i - 1, j + 1] == 1) countGreen++;

                if (matrizPrincipal[i, j + 1] == 1) countGreen++;

                CheckChangeAndResetCount(i, j);
            }

            //verificação segundo elemento(ateh penultino)/ultima linha
            if (i == linhas - 1 && j != 0 && j != colunas - 1)
            {
                if (matrizPrincipal[i, j - 1] == 1) countGreen++;

                if (matrizPrincipal[i - 1, j - 1] == 1) countGreen++;

                if (matrizPrincipal[i - 1, j] == 1) countGreen++;

                if (matrizPrincipal[i - 1, j + 1] == 1) countGreen++;

                if (matrizPrincipal[i, j + 1] == 1) countGreen++;

                CheckChangeAndResetCount(i, j);
            }

            //verificação ultimo elemento/ultima linha
            //if (i == linhas - 1 && j == colunas - 1)
            //{
            //    if (matrizPrincipal[i, j - 1] == 1) countGreen++;

            //    if (matrizPrincipal[i - 1, j - 1] == 1) countGreen++;

            //    if (matrizPrincipal[i - 1, j] == 1) countGreen++;

            //    CheckChangeAndResetCount(i, j);

            //}
            #endregion
        }

    }

}
bool TryPath()
{
    //item1 eh posicao anterior, item2 eh posicao atual, item3 é o movimento e item4 eh o item2 em tostring
    var listaPositionYellowTmp = new List<(List<int[]>, List<int[]>, List<string>,string)>();
    foreach (var t in listPositionYellow)
    {

        int i = t.Item2[0][0];
        int j = t.Item2[0][1];
        int[] posicaoAntiga = { i, j };

        #region primeira linha
        //verificação primeiro elemento/primeira linha
        if (i == 0 && j == 0)
        {

            if (matrizPrincipal[i + 1, j] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i + 1;
                posicaoNova[1] = j;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Baixo" },positionCheck));
            }

            if (matrizPrincipal[i, j + 1] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i;
                posicaoNova[1] = j+1;
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Direita" }, positionCheck));

            }
        }

        //verificação segundo elemento(ateh penultino)/primeira linha
        if (i == 0 && j != 0 && j != colunas - 1)
        {

            if (matrizPrincipal[i + 1, j] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i + 1;
                posicaoNova[1] = j;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Baixo" },positionCheck));

                //positionYellow[0] = i + 1;
                //positionYellow[1] = j;
                //route.Add("Baixo");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }

            if (matrizPrincipal[i, j + 1] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i;
                posicaoNova[1] = j+1;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Direita" },positionCheck));

                //positionYellow[0] = i;
                //positionYellow[1] = j + 1;
                //route.Add("Direita");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }

            if (matrizPrincipal[i, j - 1] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i;
                posicaoNova[1] = j-1;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Esquerda" },positionCheck));

                //positionYellow[0] = i;
                //positionYellow[1] = j - 1;
                //route.Add("Esquerda");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }
        }

        //verificação ultimo elemento/primeira linha
        if (i == 0 && j == colunas - 1)
        {

            if (matrizPrincipal[i + 1, j] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i+1;
                posicaoNova[1] = j;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Baixo" },positionCheck));

                //positionYellow[0] = i + 1;
                //positionYellow[1] = j;
                //route.Add("Baixo");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }

            if (matrizPrincipal[i, j - 1] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i;
                posicaoNova[1] = j - 1;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Esquerda" },positionCheck));

                //positionYellow[0] = i;
                //positionYellow[1] = j - 1;
                //route.Add("Esquerda");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }
        }
        #endregion

        #region linhas do meio
        //verificação primeiro elemento/linhas internas
        if (i != 0 && i != linhas - 1 && j == 0)
        {

            if (matrizPrincipal[i + 1, j] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i+1;
                posicaoNova[1] = j;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Baixo" },positionCheck));

                //positionYellow[0] = i + 1;
                //positionYellow[1] = j;
                //route.Add("Baixo");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }

            if (matrizPrincipal[i - 1, j] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i-1;
                posicaoNova[1] = j;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Cima" },positionCheck));

                //positionYellow[0] = i - 1;
                //positionYellow[1] = j;
                //route.Add("Cima");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }


            if (matrizPrincipal[i, j + 1] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i;
                posicaoNova[1] = j + 1;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Direita" },positionCheck));

                //positionYellow[0] = i;
                //positionYellow[1] = j + 1;
                //route.Add("Direita");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }
        }

        //verificação segundo elemento(ateh penultino)/linhas internas
        if (i != 0 && i != linhas - 1 && j != 0 && j != colunas - 1)
        {

            if (matrizPrincipal[i - 1, j] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i-1;
                posicaoNova[1] = j;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Cima" },positionCheck));

                //positionYellow[0] = i - 1;
                //positionYellow[1] = j;
                //route.Add("Cima");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }

            if (matrizPrincipal[i, j + 1] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i;
                posicaoNova[1] = j + 1;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Direita" },positionCheck));

                //positionYellow[0] = i;
                //positionYellow[1] = j + 1;
                //route.Add("Direita");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }

            if (matrizPrincipal[i + 1, j] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i+1;
                posicaoNova[1] = j;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Baixo" },positionCheck));
                
                //positionYellow[0] = i + 1;
                //positionYellow[1] = j;
                //route.Add("Baixo");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }

            if (matrizPrincipal[i, j - 1] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i;
                posicaoNova[1] = j - 1;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Esquerda" },positionCheck));

                //positionYellow[0] = i;
                //positionYellow[1] = j - 1;
                //route.Add("Esquerda");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }
        }

        //verificação ultimo elemento/linhas internas
        if (i != 0 && i != linhas - 1 && j == colunas - 1)
        {

            if (matrizPrincipal[i - 1, j] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i-1;
                posicaoNova[1] = j;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Cima" },positionCheck));

                //positionYellow[0] = i - 1;
                //positionYellow[1] = j;
                //route.Add("Cima");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }

            if (matrizPrincipal[i, j - 1] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i;
                posicaoNova[1] = j - 1;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Esquerda" },positionCheck));

                //positionYellow[0] = i;
                //positionYellow[1] = j - 1;
                //route.Add("Esquerda");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }

            if (matrizPrincipal[i + 1, j] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i+1;
                posicaoNova[1] = j;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Baixo" }, positionCheck));

                //positionYellow[0] = i + 1;
                //positionYellow[1] = j;
                //route.Add("Baixo");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }
        }
        #endregion

        #region ultima linha
        //verificação primeiro elemento/ultima linha
        if (i == linhas - 1 && j == 0)
        {

            if (matrizPrincipal[i - 1, j] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i-1;
                posicaoNova[1] = j;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Cima" },positionCheck));

                //positionYellow[0] = i - 1;
                //positionYellow[1] = j;
                //route.Add("Cima");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }

            if (matrizPrincipal[i, j + 1] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i;
                posicaoNova[1] = j + 1;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Direita" },positionCheck));

                //positionYellow[0] = i;
                //positionYellow[1] = j + 1;
                //route.Add("Direita");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }
        }

        //verificação segundo elemento(ateh penultino)/ultima linha
        if (i == linhas - 1 && j != 0 && j != colunas - 1)
        {

            if (matrizPrincipal[i, j - 1] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i;
                posicaoNova[1] = j - 1;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Esquerda" },positionCheck));

                //positionYellow[0] = i;
                //positionYellow[1] = j - 1;
                //route.Add("Esquerda");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }

             if (matrizPrincipal[i - 1, j] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i-1;
                posicaoNova[1] = j;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Cima" },positionCheck));
                

                //positionYellow[0] = i - 1;
                //positionYellow[1] = j;
                //route.Add("Cima");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }

            if (matrizPrincipal[i, j + 1] == 0)
            {
                int[] posicaoNova = { i, j };
                posicaoNova[0] = i;
                posicaoNova[1] = j + 1;
                posicaoAntiga.Append(0);
                var positionCheck = posicaoNova[0].ToString() + " , " + posicaoNova[1];
                listaPositionYellowTmp.Add((new List<int[]> { posicaoAntiga }, new List<int[]> { posicaoNova }, new List<string> { "Direita" },positionCheck));

                //positionYellow[0] = i;
                //positionYellow[1] = j + 1;
                //route.Add("Direita");
                //matrizTemp[positionYellow[0], positionYellow[1]] = 3;
                //return;
            }
        }

        #endregion

        if (t.Item2[0][0] == linhas-1 && t.Item2[0][1] == colunas - 1)
        {
            Console.WriteLine("CHEGOU");
            return true;
        }
    }
    //listaPositionYellowTmp.RemoveAll(x => x.Item1[0][0] == x.Item2[0][0] && x.Item1[0][1] == x.Item2[0][1]);
    //listaPositionYellowTmp.RemoveAll(x => x.Item1[0][0] >= x.Item2[0][0]);
    //List<(List<int[]>, List<int[]>, List<string>)> distinctList = listaPositionYellowTmp.Distinct(new TupleEqualityComparer()).ToList();
    List<(List<int[]>, List<int[]>, List<string>, string)> distinctList = listaPositionYellowTmp.Distinct(new TupleEqualityComparer()).ToList();
    //var a = listaPositionYellowTmp[0].Item2.SequenceEqual(listaPositionYellowTmp[1].Item2);
    listPositionYellow = distinctList;
    //listPositionYellow = distinctList;
    
    contador++;
    return false;
}
void CheckChangeAndResetCount(int i, int j)
{
    if (matrizPrincipal[i, j] == 0 && countGreen > 1 && countGreen < 5) matrizTemp[i, j] = 1;
    if (matrizPrincipal[i, j] == 1 && countGreen <= 3 && countGreen >= 6) matrizTemp[i, j] = 0;
    countGreen = 0;
}
void printMatrix(int[,] matrix, string name)
{
    Console.Write(name + "\n");

    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < colunas; j++)
        {

            Console.Write(matrix[i, j].ToString() + " ");
        }

        Console.Write("\n");

    }
    Console.Write("\n");

}

/*
#region First Element First Line Methods
Action TryPathFirstLineFirstCol1(int i, int j)
{
    positionYellow[0] = i + 1;
    positionYellow[1] = j;
    route.Add("Baixo");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}

Action TryPathFirstLineFirstCol2(int i, int j)
{
    positionYellow[0] = i;
    positionYellow[1] = j + 1;
    route.Add("Direita");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
#endregion

#region Mid Elements First Line Methods
Action TryPathFirstLineMidCol1(int i, int j)
{
    positionYellow[0] = i + 1;
    positionYellow[1] = j;
    route.Add("Baixo");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
Action TryPathFirstLineMidCol2(int i, int j)
{
    positionYellow[0] = i;
    positionYellow[1] = j + 1;
    route.Add("Direita");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
Action TryPathFirstLineMidCol3(int i, int j)
{
    positionYellow[0] = i;
    positionYellow[1] = j - 1;
    route.Add("Esquerda");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
#endregion

#region Last Element First Line Methods
Action TryPathFirstLineLastCol1(int i, int j)
{
    positionYellow[0] = i + 1;
    positionYellow[1] = j;
    route.Add("Baixo");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
Action TryPathFirstLineLastCol2(int i, int j)
{
    positionYellow[0] = i;
    positionYellow[1] = j - 1;
    route.Add("Esquerda");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
#endregion

#region First Element Mid Lines Methods
Action TryPathMidLinesFirstCol1(int i, int j)
{
    positionYellow[0] = i + 1;
    positionYellow[1] = j;
    route.Add("Baixo");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}

Action TryPathMidLinesFirstCol2(int i, int j)
{
    positionYellow[0] = i - 1;
    positionYellow[1] = j;
    route.Add("Cima");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
Action TryPathMidLinesFirstCol3(int i, int j)
{
    positionYellow[0] = i;
    positionYellow[1] = j + 1;
    route.Add("Direita");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
#endregion

#region Mid Elements Mid Lines Methods
Action TryPathMidLinesMidCols1(int i, int j)
{
    positionYellow[0] = i - 1;
    positionYellow[1] = j;
    route.Add("Cima");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
Action TryPathMidLinesMidCols2(int i, int j)
{
    positionYellow[0] = i;
    positionYellow[1] = j + 1;
    route.Add("Direita");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
Action TryPathMidLinesMidCols3(int i, int j)
{
    positionYellow[0] = i + 1;
    positionYellow[1] = j;
    route.Add("Baixo");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
Action TryPathMidLinesMidCols4(int i, int j)
{
    positionYellow[0] = i;
    positionYellow[1] = j - 1;
    route.Add("Esquerda");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
#endregion

#region Last Element Mid Lines Methods
Action TryPathMidLinesLastCol1(int i, int j)
{
    positionYellow[0] = i - 1;
    positionYellow[1] = j;
    route.Add("Cima");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
Action TryPathMidLinesLastCol2(int i, int j)
{
    positionYellow[0] = i;
    positionYellow[1] = j - 1;
    route.Add("Esquerda");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
Action TryPathMidLinesLastCol3(int i, int j)
{
    positionYellow[0] = i + 1;
    positionYellow[1] = j;
    route.Add("Baixo");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
#endregion

#region First Element Last Line Methods
Action TryPathLastLineFirstCol1(int i, int j)
{
    positionYellow[0] = i - 1;
    positionYellow[1] = j;
    route.Add("Cima");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}

Action TryPathLastLineFirstCol2(int i, int j)
{
    positionYellow[0] = i;
    positionYellow[1] = j + 1;
    route.Add("Direita");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
#endregion

#region Mid Elements Last Line Methods
Action TryPathLastLineMidCols1(int i, int j)
{
    positionYellow[0] = i;
    positionYellow[1] = j - 1;
    route.Add("Esquerda");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
Action TryPathLastLineMidCols2(int i, int j)
{
    positionYellow[0] = i - 1;
    positionYellow[1] = j;
    route.Add("Cima");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
Action TryPathLastLineMidCols3(int i, int j)
{
    positionYellow[0] = i;
    positionYellow[1] = j + 1;
    route.Add("Direita");
    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
    return null;
}
#endregion*/

public class TupleEqualityComparer : IEqualityComparer<(List<int[]>, List<int[]>, List<string>,string)>
{
    public bool Equals((List<int[]>, List<int[]>, List<string>,string) x, (List<int[]>, List<int[]>, List<string>,string) y)
    {
        return x.Item4.SequenceEqual(y.Item4);
    }

    public int GetHashCode((List<int[]>, List<int[]>, List<string>,string) obj)
    {
        return obj.Item4.GetHashCode();
    }
}
