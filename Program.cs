class Program
{
    static void Main(string[] args)
    {
        long maxMemory = 1000000;
        List<long> list = new List<long>();
        long i = 0;

        while (true)
        {
            GetMessage();
            list.Add(i);
            i++;
        }

        void GetMessage()
        {
            long memory = GetCurrentMemory();
            if (memory > maxMemory)
            {
                Console.WriteLine("Внимание потребление ресурсов вышло за приделы - " + memory + " байт");
            }
            else
            {
                Console.WriteLine("Текущее потребление ресурсов - " + memory + " байт");
            }
        }
        long GetCurrentMemory()
        {
            return GC.GetTotalMemory(true);
        }
    }
}
