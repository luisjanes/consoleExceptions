using System.Security.Cryptography.X509Certificates;

namespace consoleExceptions
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
                    //system.indexoutofrangeexception
                    //Console.WriteLine(arr[i]);
                }
                Cadastrar("");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Source);
                Console.WriteLine(e.Message);
                Console.WriteLine("Índice não encontrado");
            }
            catch(MyException e)
            {
                Console.WriteLine(e.Source);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.WhenHappn);
                Console.WriteLine("MyException");
            }
            catch (Exception e)
            {
                Console.WriteLine("Souce: " + e.Source);
                Console.WriteLine("Type: " + e.GetType());
                Console.WriteLine("Message: " + e.Message);
                Console.WriteLine("StackTrace: " + e.StackTrace);
            }
            //Sempre passará pelo finally
            finally 
            { 
                Console.WriteLine("Fechar aplicação"); 
            }

            static void Cadastrar(string texto)
            {
                if (string.IsNullOrEmpty(texto))
                {
                    //throw new ArgumentNullException("Não pode ser nulo ou vazio");
                    throw new MyException(DateTime.Now);
                }
            }
        }
    }
    public class MyException : Exception
    {
        public MyException(DateTime date) 
        { 
            WhenHappn = date;
        }
        public DateTime WhenHappn { get; set; }
    }
}
