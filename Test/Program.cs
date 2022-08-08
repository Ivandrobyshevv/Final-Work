namespace GB
{
    class Program
    {
        static void Main(string[] args)
        {   string stop = null;
            while (true)
            {   Console.Clear();
                Console.WriteLine("Введите размерность массива:");
                int n = Convert.ToInt32(Console.ReadLine());
                string [] arrayText = new string [n];
                InitArray(arrayText);
                Console.WriteLine("\nПовторить операциб y|n :");
                stop = Console.ReadLine();
                if (stop == "n")
                {
                    break;
                }
                
            }
            
            
            
            
        }
        static void InitArray(string [] arrayText)
        {
            Console.WriteLine("Введите значения через запятую:");
            arrayText = Console.ReadLine().Split(',');
            PritArray(arrayText);
            PrintElem(arrayText);            
            
        }
        
        static void PrintElem(string[] arrayText)
        {
             for (int i = 0; i < arrayText.Length; i++)
            {
                int n = arrayText[i].Length;
                if (n < 3)
                {
                    Console.Write("{0}", arrayText[i] + ",");
                }
            }            
        }
        static void PritArray(string [] arrayText)
        {
            
            Console.Write("[{0}]", string.Join(",", arrayText));
            Console.Write(" -> ");           
        }
        
     
    }

}