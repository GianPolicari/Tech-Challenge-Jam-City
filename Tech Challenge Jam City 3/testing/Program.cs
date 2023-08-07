using System;
using System.Collections.Generic;

//Parte 3

class Program
{
    static void Main()
    {                             
        List<List<int>> employeesBySector = new List<List<int>>
        {
            new List<int> { 0, 0, 0 }, // HR: ($1500 Seniors, $1000 Semi Seniors and $500 Juniors)
            new List<int> { 0, 0, 0 }, // Engineering → ($5000 Seniors, $3000 Semi Seniors and $1500 Juniors)
            new List<int> { 0, 0, 0 }, // Artist → ($2000 Seniors and $1200 Semi Seniors)
            new List<int> { 0, 0, 0 }, // Design → ($2000 Seniors and $800 Juniors)
            new List<int> { 0, 0, 0 }, // PMs → ($4000 Seniors and $2400 Semi Seniors)
        };

        employeesBySector[0] = new List<int> { 1500, 1000, 500 }; // HR
        employeesBySector[1] = new List<int> { 5000, 3000, 1500 }; // Engineering
        employeesBySector[2] = new List<int> { 2000, 1200, 0 }; // Artist
        employeesBySector[3] = new List<int> { 2000, 0, 800 }; // Design
        employeesBySector[4] = new List<int> { 4000, 2400, 0 }; // PM

        Console.WriteLine("Sistema de salario estandarizado");
        Console.WriteLine("Sector\t\t\tSenior\t\tSemi Senior\tJuniors");
        Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
        string[] sectors = { "II) HR →", "III) Eng →", "IV) Art →", "V) Design →", "VI) PMs →" };
        Console.WriteLine("I) CEO → $20000 ");
        
        // Incremento de salario por sector y seniority
        double[,] salaryIncrements = {
            { 0.05, 0.02, 0.005 },  // HR
            { 0.1, 0.07, 0.05 },    // Engineering
            { 0.05, 0.025, 0 },     // Artist
            { 0.07, 0, 0.04 },      // Design
            { 0.1, 0.05, 0 }        // PMs
        };
        
        for (int i = 0; i < employeesBySector.Count; i++)
        {
            Console.Write($"{sectors[i]}\t\t");
            for (int j = 0; j < employeesBySector[i].Count; j++)
            {
                double increment = employeesBySector[i][j] * salaryIncrements[i, j];
                employeesBySector[i][j] += (int)increment;
                Console.Write($"${employeesBySector[i][j]}\t\t");
            }
            Console.WriteLine();
        }
    }
}


