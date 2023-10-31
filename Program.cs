namespace consoleException
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    //System.IndexOutOfRangeException
                    Console.WriteLine(arr[i]);
                }
            } 
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Source);
                Console.WriteLine(e.Message);
                Console.WriteLine("Índice não encontrado");
            }
            catch (Exception e)
            {
                Console.WriteLine("Souce: " + e.Source);
                Console.WriteLine("Type: " + e.GetType());
                Console.WriteLine("Message: " + e.Message);
                Console.WriteLine("StackTrace: " + e.StackTrace);
            }
        }
    }
}
