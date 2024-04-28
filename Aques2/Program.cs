// See https://aka.ms/new-console-template for more information
namespace Aques2 {

    class Program
    {
        static void Main(string[] args)
        {
            int[] sprint = new int[] { 3, 2 };
            int k = 3;
            Aquestion item = new Aquestion();

            Console.WriteLine(item.GetMaximumPoints(sprint, k));
        }
    }


    public class Aquestion
    {

        public int GetMaximumPoints(int[] days, int k)
        {
            List<int> daysExpanded = new List<int>();

            foreach (int item in days)
            {
                for (int x = 1; x <= item; x++)
                    daysExpanded.Add(x);
            }

            int maxPoints = 0;

            for (int x = 0; x < daysExpanded.Count; x++)
            {
                int current = 0;
                int valueDay = 0;
                int edge = 0;

                for (int y = 0; y < k; y++)
                {
                    if ((x + y) > (daysExpanded.Count - 1))
                    {
                        valueDay = daysExpanded[edge];
                        edge++;
                    }
                    else
                    {
                        valueDay = daysExpanded[x + y];
                    }
                    current += valueDay;
                }

                if (current > maxPoints)
                    maxPoints = current;
            }

            return maxPoints;
        }

    }
}