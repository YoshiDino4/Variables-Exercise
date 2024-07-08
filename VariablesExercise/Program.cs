// declare and initialize variables
string name = "Megatron";
int age = 38;
char teamInitial = 'D';
bool highschoolGrad = false;
decimal currentSalary = 500.50m;

string gradStatus;

if (highschoolGrad == false)
   gradStatus = "not";
else
{
   gradStatus = "indeed";
}


Console.WriteLine($"My name is {name}, leader of team {teamInitial} for Decepticon. I am {age} and am {gradStatus} a high school grad. I make ${currentSalary} an hour!");