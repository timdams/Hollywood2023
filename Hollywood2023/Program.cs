using System.Diagnostics;

namespace Hollywood2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int frameCounter = 0;
            while(true)
            {
                frameCounter++;
                System.Threading.Thread.Sleep(500);
                Console.Clear();

               if(frameCounter <20)
                {
                    CarDrivingScene(frameCounter);
                }
               else if(frameCounter<30)
                {
                    DrawFace(5, 3, false);
                    if (frameCounter % 2 == 0)
                        DrawFace(5, 3, true);
                }
               else if(frameCounter <50)
                {
                    CarDrivingScene(frameCounter - 30, 5);
                }


            }
        }

        static void CarDrivingScene(int frameNumber, int carAmount = 1)
        {
            for (int i = 0; i < carAmount; i++)
            {
                DrawCar(frameNumber+i, 15+3*i);
            }
            
        }

        static void DrawFace(int x, int y, bool knipoogt)
        {
            DrawRectangle(x, y, '.', 7, 8);
            DrawCharacter(x + 2, y + 2, 'O');
            if(knipoogt)
                DrawCharacter(x + 4, y + 2, '-');
            else
                DrawCharacter(x + 4, y + 2, 'O');
            DrawCharacter(x + 3, y + 4, 'L');
            Console.ForegroundColor = ConsoleColor.Red;
            DrawRectangle(x + 1, y + 6, '-', 4, 2);
            Console.ResetColor();
        }
        static void DrawRectangle(int x,int y, char character,int length, int height)
        {
            for (int i = x; i < x+length; i++)
            {
                for (int j = y; j < y+height; j++)
                {
                    DrawCharacter(i, j, character);
                }
            }
        }

        static void DrawCharacter(int x, int y, char character)
        {
            if (x >= 0 && x < Console.WindowWidth)
            {
                if (y >= 0 && y < Console.WindowHeight)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(character);
                }
            }
        }

        static void DrawCar(int x, int y)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            DrawRectangle( x, y + 6, ' ',20, 4);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            DrawRectangle(x + 17, y, '|', 1, 6);
            Console.ResetColor();
            DrawCharacter(x + 3, y + 10, 'O');
            DrawCharacter(x + 15, y + 10, 'O');
        }

    }
}
