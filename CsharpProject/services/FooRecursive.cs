

namespace Services
{
	static class FooRecursiveContainer
	{
		public static void FooRecursive(int x)
		{
            Console.WriteLine(x);
            if (x < 9)
            {
                FooRecursive(x + 1);
                Console.WriteLine("Returning: " + (x+1));
                
            }
            Console.WriteLine(x);
            
		}
	}
}