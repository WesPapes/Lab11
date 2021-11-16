using System;

class Person
{
  public string ID{get; set;}
  public string Title{get; set;}
  public virtual DateTime DateOfEmployment{get; set;}
  public string Employer{get; set;}
  public double YearlySalary{get; set;}
  public bool Tenure{get; set;}

  public Person(string fname, string lname)
  {
    FirstName = fname;
    LastName = lname;
    Console.WriteLine("Person constructor");
  }

  public void Tenure()
  {
    if ((DateTime.Today.Month == DateOfEmployment.Month)&&(DateTime.Today.Day == DateOfEmployment.Day))
    Console.WriteLine("You have been granted tenure");
    else
    Console.WriteLine("You have not been granted tenure");
  }
}
