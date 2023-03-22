using ConsoleApp1;
//Global Counter
int countGreen = 0;
//end global counter


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
//    { 3 , 0 , 0 , 0 },
//    { 0 , 1 , 1 , 1 },
//    { 0 , 0 , 0 , 0 },
//    { 0 , 1 , 0 , 1 }
//};

int[,] matrizPrincipal1 = new int[linhas, colunas];
matrizPrincipal1 = (int[,])matrizPrincipal.Clone();
int[,] matrizTemp = new int[linhas, colunas];
#endregion

//1 é verde, 0 é branco

int stepCount = 1000;
int[] positionYellow = { -1, -1 };
List<string> route = new();
int routeBestTry = 0;
IList<Eligible> eligible = new List<Eligible>();
Random rnd = new Random();

//printMatrix(matrizPrincipal, "Matrix Inicial");

//for (int i = 0; i < stepCount; i++)
while (matrizPrincipal[linhas - 1, colunas - 1] != 3 || matrizPrincipal[64,83] != 3 || matrizPrincipal[63,83] != 3 || matrizPrincipal[63, 84] != 3)
{
    eligible.Clear();
    StepExecute();
    matrizPrincipal = matrizTemp;
    TryPath();
    if (route.Count != 0 && route.Last() == "No Route")
    {
        if(routeBestTry == 0)
        {
            routeBestTry = route.Count;
        }else if (route.Count > routeBestTry)
        {
            routeBestTry = route.Count;
        }
        route.Clear();
        matrizTemp = new int[linhas, colunas];
        matrizPrincipal = matrizPrincipal1;
        continue;
    }
    eligible[rnd.Next(0, eligible.Count())].Method.Invoke();
    //printMatrix(matrizPrincipal, "principal");
    //printMatrix(matrizTemp, "temporaria");
    //(matrizTemp, "Matrix Temporária");
    matrizTemp = new int[linhas, colunas];
}
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
            if (i == 0 && j == 0)
            {
                if (matrizPrincipal[i + 1, j] == 1) countGreen++;

                if (matrizPrincipal[i + 1, j + 1] == 1) countGreen++;

                if (matrizPrincipal[i, j + 1] == 1) countGreen++;

                CheckChangeAndResetCount(i, j);
            }

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
            if (i == linhas - 1 && j == colunas - 1)
            {
                if (matrizPrincipal[i, j - 1] == 1) countGreen++;

                if (matrizPrincipal[i - 1, j - 1] == 1) countGreen++;

                if (matrizPrincipal[i - 1, j] == 1) countGreen++;

                CheckChangeAndResetCount(i, j);

            }
            #endregion
        }

    }

}
void TryPath()
{
    int i = positionYellow[0];
    int j = positionYellow[1];
    #region primeira linha
    //verificação primeiro elemento/primeira linha
    if (i == 0 && j == 0)
    {
        if (matrizPrincipal[i + 1, j] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathFirstLineFirstCol1(i, j)
        });

        //if (matrizPrincipal[i + 1, j] == 0)
        //{
        //    positionYellow[0] = i + 1;
        //    positionYellow[1] = j;
        //    route.Add("Baixo");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (matrizPrincipal[i, j + 1] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathFirstLineFirstCol2(i, j)
        });
        //else if (matrizPrincipal[i, j + 1] == 0)
        //{
        //    positionYellow[0] = i;
        //    positionYellow[1] = j + 1;
        //    route.Add("Direita");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}

        if(eligible.Count== 0)
        {
            route.Add("No Route");
        }
    }

    //verificação segundo elemento(ateh penultino)/primeira linha
    if (i == 0 && j != 0 && j != colunas - 1)
    {
        if (matrizPrincipal[i + 1, j] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathFirstLineMidCol1(i, j)
        });
        //if (matrizPrincipal[i + 1, j] == 0)
        //{
        //    positionYellow[0] = i + 1;
        //    positionYellow[1] = j;
        //    route.Add("Baixo");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (matrizPrincipal[i, j + 1] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathFirstLineMidCol2(i, j)
        });
        //else if (matrizPrincipal[i, j + 1] == 0)
        //{
        //    positionYellow[0] = i;
        //    positionYellow[1] = j + 1;
        //    route.Add("Direita");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (matrizPrincipal[i, j - 1] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathFirstLineMidCol3(i, j)
        });
        //else if (matrizPrincipal[i, j - 1] == 0)
        //{
        //    positionYellow[0] = i;
        //    positionYellow[1] = j - 1;
        //    route.Add("Esquerda");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (eligible.Count == 0)
        {
            route.Add("No Route");
        }
    }

    //verificação ultimo elemento/primeira linha
    if (i == 0 && j == colunas - 1)
    {
        if (matrizPrincipal[i + 1, j] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathFirstLineLastCol1(i, j)
        });
        //if (matrizPrincipal[i + 1, j] == 0)
        //{
        //    positionYellow[0] = i + 1;
        //    positionYellow[1] = j;
        //    route.Add("Baixo");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (matrizPrincipal[i, j - 1] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathFirstLineLastCol2(i, j)
        });
        //else if (matrizPrincipal[i, j - 1] == 0)
        //{
        //    positionYellow[0] = i;
        //    positionYellow[1] = j - 1;
        //    route.Add("Esquerda");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (eligible.Count == 0)
        {
            route.Add("No Route");
        }
    }
    #endregion

    #region linhas do meio
    //verificação primeiro elemento/linhas internas
    if (i != 0 && i != linhas - 1 && j == 0)
    {
        if (matrizPrincipal[i + 1, j] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathMidLinesFirstCol1(i, j)
        });
        //if (matrizPrincipal[i + 1, j] == 0)
        //{
        //    positionYellow[0] = i + 1;
        //    positionYellow[1] = j;
        //    route.Add("Baixo");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (matrizPrincipal[i - 1, j] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathMidLinesFirstCol2(i, j)
        });
        //else if (matrizPrincipal[i - 1, j] == 0)
        //{
        //    positionYellow[0] = i - 1;
        //    positionYellow[1] = j;
        //    route.Add("Cima");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}

        if (matrizPrincipal[i, j + 1] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathMidLinesFirstCol3(i, j)
        });
        //else if (matrizPrincipal[i, j + 1] == 0)
        //{
        //    positionYellow[0] = i;
        //    positionYellow[1] = j + 1;
        //    route.Add("Direita");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}

        if (eligible.Count == 0)
        {
            route.Add("No Route");
        }
    }

    //verificação segundo elemento(ateh penultino)/linhas internas
    if (i != 0 && i != linhas - 1 && j != 0 && j != colunas - 1)
    {
        if (matrizPrincipal[i - 1, j] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathMidLinesMidCols1(i, j)
        });
        //if (matrizPrincipal[i - 1, j] == 0)
        //{
        //    positionYellow[0] = i - 1;
        //    positionYellow[1] = j;
        //    route.Add("Cima");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (matrizPrincipal[i, j + 1] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathMidLinesMidCols2(i, j)
        });
        //else if (matrizPrincipal[i, j + 1] == 0)
        //{
        //    positionYellow[0] = i;
        //    positionYellow[1] = j + 1;
        //    route.Add("Direita");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (matrizPrincipal[i + 1, j] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathMidLinesMidCols3(i, j)
        });
        //else if (matrizPrincipal[i + 1, j] == 0)
        //{
        //    positionYellow[0] = i + 1;
        //    positionYellow[1] = j;
        //    route.Add("Baixo");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (matrizPrincipal[i, j - 1] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathMidLinesMidCols4(i, j)
        });
        //else if (matrizPrincipal[i, j - 1] == 0)
        //{
        //    positionYellow[0] = i;
        //    positionYellow[1] = j - 1;
        //    route.Add("Esquerda");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (eligible.Count == 0)
        {
            route.Add("No Route");
        }
    }

    //verificação ultimo elemento/linhas internas
    if (i != 0 && i != linhas - 1 && j == colunas - 1)
    {
        if (matrizPrincipal[i - 1, j] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathMidLinesLastCol1(i, j)
        });
        //if (matrizPrincipal[i - 1, j] == 0)
        //{
        //    positionYellow[0] = i - 1;
        //    positionYellow[1] = j;
        //    route.Add("Cima");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (matrizPrincipal[i, j - 1] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathMidLinesLastCol2(i, j)
        });
        //else if (matrizPrincipal[i, j - 1] == 0)
        //{
        //    positionYellow[0] = i;
        //    positionYellow[1] = j - 1;
        //    route.Add("Esquerda");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (matrizPrincipal[i + 1, j] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathMidLinesLastCol3(i, j)
        });
        //else if (matrizPrincipal[i + 1, j] == 0)
        //{
        //    positionYellow[0] = i + 1;
        //    positionYellow[1] = j;
        //    route.Add("Baixo");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (eligible.Count == 0)
        {
            route.Add("No Route");
        }
    }
    #endregion

    #region ultima linha
    //verificação primeiro elemento/ultima linha
    if (i == linhas - 1 && j == 0)
    {
        if (matrizPrincipal[i - 1, j] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathLastLineFirstCol1(i, j)
        });
        //if (matrizPrincipal[i - 1, j] == 0)
        //{
        //    positionYellow[0] = i - 1;
        //    positionYellow[1] = j;
        //    route.Add("Cima");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (matrizPrincipal[i, j + 1] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathLastLineFirstCol2(i, j)
        });
        //else if (matrizPrincipal[i, j + 1] == 0)
        //{
        //    positionYellow[0] = i;
        //    positionYellow[1] = j + 1;
        //    route.Add("Direita");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (eligible.Count == 0)
        {
            route.Add("No Route");
        }
    }

    //verificação segundo elemento(ateh penultino)/ultima linha
    if (i == linhas - 1 && j != 0 && j != colunas - 1)
    {
        if (matrizPrincipal[i, j - 1] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathLastLineMidCols1(i, j)
        });
        //if (matrizPrincipal[i, j - 1] == 0)
        //{
        //    positionYellow[0] = i;
        //    positionYellow[1] = j - 1;
        //    route.Add("Esquerda");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (matrizPrincipal[i - 1, j] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathLastLineMidCols2(i, j)
        });
        //else if (matrizPrincipal[i - 1, j] == 0)
        //{
        //    positionYellow[0] = i - 1;
        //    positionYellow[1] = j;
        //    route.Add("Cima");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (matrizPrincipal[i, j + 1] == 0) eligible.Add(new Eligible()
        {
            isEligible = true,
            Method = () => TryPathLastLineMidCols3(i, j)
        });
        //else if (matrizPrincipal[i, j + 1] == 0)
        //{
        //    positionYellow[0] = i;
        //    positionYellow[1] = j + 1;
        //    route.Add("Direita");
        //    matrizTemp[positionYellow[0], positionYellow[1]] = 3;
        //    return;
        //}
        if (eligible.Count == 0)
        {
            route.Add("No Route");
        }
    }

    #endregion
    if (matrizTemp[linhas - 1, colunas - 1] == 3)
    {
        Console.WriteLine("CHEGOU");
        return;
    }
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
#endregion