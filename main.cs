using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
     int counter=0;
    int total = 0;
    
    Console.WriteLine("How many cars are there?");
    int numberOfCars = Convert.ToInt32(Console.ReadLine());

    while(counter < numberOfCars)
    {
      Console.WriteLine("Enter speed of cars");
      int speed = Convert.ToInt32(Console.ReadLine());
      total = total + speed;
      counter++;

       Console.WriteLine("Enter time taken by cars");
      int time = Convert.ToInt32(Console.ReadLine());
      total = total + time;
      counter++;
    }
    
    double average = total / numberOfCars;
    
    Console.WriteLine("Average speed of cars "+numberOfCars+" cars = " + average);
  }
}
  