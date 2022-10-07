using System;
using System.Text;
using genetic_algorithms;
using NUnit.Framework;

namespace test_genetic_algorithms
{
    [TestFixture]
    public class GeneticAlgorithmTest
    {
        private static Func<string, double> Fitness(string goal)
        {
            return new Func<string, double>(chromosome => {
                double total = 0;

                for (int i = 0; i < goal.Length; i++)
                {
                    if (goal[i] != chromosome[i])
                    {
                        total++;
                    }
                }

                return 1.0 / (total + 1);
            });
        }

        [Test]
        public void TestRandomCase()
        {
            int length = 10;
            var random = new Random();
            StringBuilder sb = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                sb.Append(Math.Floor(2 * random.NextDouble()).ToString());
            }

            var goal = sb.ToString();
            Func<string, double> f = Fitness(goal);
            Assert.AreEqual(goal, GeneticAlgorithm.FindBinaryGeneticString(f, length, 0.6, 0.002));
        }
    }
}