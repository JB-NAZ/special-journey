﻿using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal andrewScore;
decimal emmaScore;
decimal loganScore;


// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

foreach (string name in studentNames)
{
    Console.WriteLine($"{name}");
    int sophiaSum = 0;
    decimal sophiaScore;


    foreach (int score in sophiaScores)
    {
        sophiaSum = sophiaSum + score;
    }


    sophiaScore = (decimal)sophiaSum / currentAssignments;
    // andrewScore = (decimal)andrewSum / currentAssignments;
    // emmaScore = (decimal)emmaSum / currentAssignments;
    // loganScore = (decimal)loganSum / currentAssignments;

    Console.WriteLine("Student\t\tGrade\n");
    Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
    // Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
    // Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
    // Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
