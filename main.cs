using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter Worker 1");
    Worker w1 = new Worker();
    w1.FirstName = "Adam";
    w1.LastName = "Jones";
    w1.ID = "Adam Jones";
    w1.Title = "Service Associate 1";
    w1.DateOfEnployment = Convert.ToDateTime("01/01/2019");
    w1.Employer = "National Interstate";
    w1.YearlySalary = Convert.ToDecimal("12000");
    w1.Tenure();
    w1.SetWorkStatus();
    Console.WriteLine(w1.SetWorkStatus);

    }
}