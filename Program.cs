
//UC3
int Present = 1;
int fulltime = 1;
int Emp_per_rate = 20;
int emphr = 0;
int empwage = 0;
Random random = new Random();
Random random1 = new Random();
int EmployeeStatus = random.Next(0, 2);
int EmployeeTime = random.Next(0, 2);
if (EmployeeStatus == Present) 
{
    if (EmployeeTime == fulltime)
    {
        Console.WriteLine("Employee is present");
        emphr = 8;
    }
    else
    {
        Console.WriteLine("Employee is Present");
        emphr = 4;
    }
}
 else
    { Console.WriteLine("Employee is absent");
        emphr = 0;
    }

    empwage = (Emp_per_rate * emphr);
    Console.WriteLine("Dailly wage " + empwage);
