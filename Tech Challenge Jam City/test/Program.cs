using System;
using System.Collections.Generic;


//parte 1

class Program
{
    static void Main()
    {
        // Lista de listas para representar la cantidad de empleados por sector y seniority
        List<List<int>> employeesBySector = new List<List<int>>
        {
            new List<int> { 0, 0, 0 }, // HR: Junior, Semi Senior, Senior
            new List<int> { 0, 0, 0 }, // Engineering: Junior, Semi Senior, Senior
            new List<int> { 0, 0, 0 }, // Artist: Junior, Semi Senior, Senior
            new List<int> { 0, 0, 0 }, // Design: Junior, Semi Senior, Senior
            new List<int> { 0, 0, 0 }, // PM: Junior, Semi Senior, Senior
        };

        // Agregar empleados a la lista de listas
        employeesBySector[0] = new List<int> { 5, 3, 2 }; // HR
        employeesBySector[1] = new List<int> { 50, 68, 32 }; // Engineering
        employeesBySector[2] = new List<int> { 5, 20, 0 }; // Artist
        employeesBySector[3] = new List<int> { 10, 0, 15 }; // Design
        employeesBySector[4] = new List<int> { 10, 20, 0 }; // PM

        // Mostrar la cantidad de empleados por sector y seniority
        Console.WriteLine("Cantidad de empleados por sector, ordenados por seniority y antigüedad:");
        Console.WriteLine("Sector\t\tJunior\t\tSemi Senior\tSenior");
        Console.WriteLine("------------------------------------------------------");
        string[] sectors = { "II) 20 HR →", "III) 150 Eng →", "IV) 25 Art →", "V) 25 Design →", "VI) 30 PMs →" };
        Console.WriteLine("I) 1 CEO");
        for (int i = 0; i < employeesBySector.Count; i++)
        {
            Console.Write($"{sectors[i]}\t");
            foreach (int count in employeesBySector[i])
            {
                Console.Write($"{count}\t\t");
            }
            Console.WriteLine();
        }
    }
};
