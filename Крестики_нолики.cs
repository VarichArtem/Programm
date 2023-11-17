using System;

namespace КрестикиНолики
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            // рисует поле
            for(int y = 0; y<= 30; y+=10)
            {
                for (int x = 0; x < 30; x++) 
                {
                    Console.SetCursorPosition (x, y);
                    Console.WriteLine("█");
                }
            }
            for(int x = 0; x <= 30; x+=10)
            {
                for( int y = 0; y < 33; y++) {
                Console.SetCursorPosition (x, y);
                Console.WriteLine("█");
                }
            }
            // правила
            int number = 0;
            int x0;
            int y0;
            int vib = -1; // -1 - крестик, 1 - нолик

            for (int step = 0; step < 9; step++)
            {
                // спрашиваем номер клетки
                Console.SetCursorPosition(0, 35);
                number = int.Parse(Console.ReadLine());

                //получаем верхний левый угол клетки
                x0 = ((number - 1) % 3) * 10 + 1;
                y0 = ((number - 1) / 3) * 10 + 1;

                if (vib == 1)
                {

                    //отрисовка 0
                    for (int x = x0; x < x0 + 8; x++)
                    {
                        for (int y = y0; y < y0 + 8; y++)
                        {
                            if (x == x0 || x == x0 + 7 || y == y0 || y == y0 + 7)
                            {
                                Console.SetCursorPosition(x, y);
                                Console.WriteLine("█");
                            }
                        }
                    }
                }

                if (vib == -1)
                { 
                    for (int x = x0; x < x0 + 8; x++)
                    {
                        for (int y = y0; y < y0 + 8; y++)
                        {
                            if (x - y == x0 - y0 || x + y == y0 + x0 + 7)
                            {
                                Console.SetCursorPosition(x, y);
                                Console.WriteLine("█");
                            }
                        }
                    }
                }
                vib = vib * -1;
            }
            Console.WriteLine();
        }
    }
}