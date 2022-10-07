using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace genetic_algorithms
{

    public class GeneticAlgorithm
    {
        public string FindBinaryGeneticString(Func<string, double> fitness,
                                              int length, double probCrossover,
                                              double probMutation)
        {
            int numIndividuos = 10;

            int[][] population = new int[numIndividuos][];

            initPopulation(population,numIndividuos, length);

            evaluatePopulation();

            int generation = 1;

            while (isTerminationCondition()==1)
            {
                var fittest = getFittest(population);

                // Crossover population
                population = crossoverPopulation(population);
                // Mutate population
                population = mutatePopulation(population);
                // Evaluate population
                evalPopulation(population);

            }
            return "";
        }

        private void evalPopulation(int[][] population)
        {
            throw new NotImplementedException();
        }

        private int[][] mutatePopulation(int[][] population)
        {
            throw new NotImplementedException();
        }

        private int[][] crossoverPopulation(int[][] population)
        {
            throw new NotImplementedException();
        }

        private object getFittest(int[][] population)
        {
            throw new NotImplementedException();
        }
       
        private static int isTerminationCondition()
        {
            throw new NotImplementedException();
        }

        private static void evaluatePopulation()
        {
            throw new NotImplementedException();
        }

        public static void initPopulation(int[][] population,int numIndividuos, int numCromosomas)
        {
            for (int i = 0; i < numIndividuos; i++)
            {
                for (int j = 0; j < numCromosomas; j++)
                {
                    Random rd = new Random();

                    double aleatorio = rd.NextDouble();
                    if (aleatorio < 0.5)
                        population[i][j] = 0;
                    else
                        population[i][j] = 1;
                }
            }
        }

    
}
}