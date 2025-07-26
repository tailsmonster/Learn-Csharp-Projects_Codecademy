using System;

public class GalacticTravelAgency { 
  public static void Main(string[] args) {
    // Your code goes here 
    string passengerName = "Zara";
    int passengerAge = 28;
    string ticketType = "First Class";
    string preferredPlanet = "Mars";

    passengerAge++;
    double passengerAgeDouble = (double) passengerAge; // explicit
    double passengerAgeDouble2 = passengerAge; // implicit
    string passengerAgeString = Convert.ToString(passengerAge); // method

    Console.WriteLine(passengerName);
    Console.WriteLine(passengerAge);
    Console.WriteLine(passengerAgeDouble);
    Console.WriteLine(passengerAgeDouble2);
    Console.WriteLine(passengerAgeString);
    Console.WriteLine(ticketType);
    Console.WriteLine(preferredPlanet);
  }
}