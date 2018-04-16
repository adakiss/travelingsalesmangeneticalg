using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingSalesmanGenetinAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelingSalesmanProblem problem = new TravelingSalesmanProblem();
            TravelingSalesmanSolver solver = new TravelingSalesmanSolver(problem, "towns.txt");
            solver.SolveTravelingSalesmanProblem();
            Console.ReadLine();
        }
    }
}
