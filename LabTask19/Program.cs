using System.Reflection.Emit;

namespace LabTask19
{
    internal class Program
    {
        static void Main(string[] args)
        {
        label:
            int input = int.Parse(Console.ReadLine());

            if (input < 999)
            {
                Console.WriteLine("need 4+ digs");
                goto label;
            }


            int firstDig = input;
            int count = 0;

            
            while (firstDig > 0)
            {
                firstDig /= 10;
                count++;
            }


            int[] digs = new int[count];

            firstDig = input;
            int lastDig = 0;
            for (int i = 0; i < digs.Length; i++)
            {
                lastDig = firstDig % 10;
                digs[i] = lastDig;
                firstDig /= 10;
            }

            for (int i = 0; i < digs.Length; i++)
            {
                Console.WriteLine(digs[i]);
            }
        }
    }
}
