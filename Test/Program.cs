namespace GB
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Введите размерность массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            string [] arrayText = new string [n];
            InitArray(arrayText);
            
            
            
        }
        static void InitArray(string [] arrayText)
        {
            Console.WriteLine("Введите значения через запятую");
            arrayText = Console.ReadLine().Split(',');
            PritArray(arrayText);
            PrintElem(arrayText);            
            
        }
        
        private static void PrintElem(string[] arrayText)
        {
             for (int i = 0; i < arrayText.Length; i++)
            {
                int n = arrayText[i].Length;
                if (n < 3)
                {
                    Console.Write($"[{arrayText[i]}]");
                }
            }            
        }
        private static void PritArray(string [] arrayText)
        {
             for (int i = 0; i < arrayText.Length; i++)
            {
                Console.Write(arrayText[i]+ " ");
            }
            Console.Write(" -> ");           
        }
        
     
    }

}