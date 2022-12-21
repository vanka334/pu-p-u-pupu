using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace pu_p_u_pupu
{
    public class snake
    {
        public static int[] X = new int [50] ;
        public static int[] Y = new int [50];
        public ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        int Width = 30 ;
        public int Height = 20;
        public static int fruitX;
        public static int fruitY;
        public static char key = 'w';
        Random rnd = new Random();
        public static int parts = 3;
        
        public snake()
        {

            X[0] = 5;
            Y[0] = 5;
            Console.CursorVisible = false;
            fruitX = rnd.Next(2, (Width - 2));
            fruitY = rnd.Next(2, (Height - 2));
        }
        public void WriteBoard()
        {
            Console.Clear();
            for (int i = 1; i <= (Width + 2); i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("-");
            }
            for (int i = 1; i <= (Width + 2); i++)
            {
                Console.SetCursorPosition(i, (Height + 2));
                Console.Write("-");
            }
            for (int i = 1; i <= (Height + 1); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("|");
            }
            for (int i = 1; i <= (Height + 1); i++)
            {
                Console.SetCursorPosition((Width + 2), i);
                Console.Write("|");
            }
        }
        public void Input()
        {
            Thread thread = new(_=>{
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            });
            thread.Start();
            
        }
        public void WritePoint(int x, int y)
        {
            if (x > 50 | x<0 | y>50 | y < 0)
            {

                    Environment.Exit(0);
            }
            Console.SetCursorPosition(x, y);
            Console.Write("0");
        }
        public void Logic()
        {
            if (X[0] == fruitX)
            {
                if (Y[0] == fruitY)
                {
                    parts++;
                    fruitX = rnd.Next(2, (Width - 2));
                    fruitY = rnd.Next(2, (Height - 2));
                }
            }
            for (int i = parts; i > 1; i--)
            {
                X[i - 1] = X[i - 2];
                Y[i - 1] = Y[i - 2];
            }
            if (key.ToString() == popoir.w.ToString())
            {
  
                Y[0]--;
            }
            else if (key.ToString() == popoir.s.ToString())
            {
                Y[0]++; 
            }
            else if (key.ToString() == popoir.d.ToString())
            {
                X[0]++;

            
            }
            else if (key.ToString() == popoir.a.ToString())
            {
                X[0]--;
              
            }
            for (int i = 0; i <= (parts - 1); i++)
            {
                WritePoint(X[i], Y[i]);
                WritePoint(fruitX, fruitY);

            }
            Thread.Sleep(100);  
        }
    }
}
