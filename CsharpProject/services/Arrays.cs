namespace Services
{
static class ArraysContainer
    {
        public static void PrintArray(int[] arr)
        {
            Console.Write("{");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.Write(arr[arr.Length - 1] + "} ");
        }
        
        public static void ReverseArray(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            PrintArray(arr);
        }
    }
}