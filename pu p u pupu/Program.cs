using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace pu_p_u_pupu
{
    internal class Program
    {
       
        
        static void Main(string[] args)
        {
            snake snake = new snake();
            
            while (true)
            {
                snake.WriteBoard();
                snake.Input();
                snake.Logic();
            }
        }
    }
}