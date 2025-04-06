

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 2, 3, 6, 4, 4, 4, 9, 5, 9, 2 };
        int[] list = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    count++;
                    if (numero(array[i]))
                    {
                        list[i] = array[i];
                    }

                }
            }

            if (list[i] != 0)
            {
                Console.WriteLine(list[i] + "se repite: " + count);
            }
    
        }

        bool numero(int num)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == num)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
