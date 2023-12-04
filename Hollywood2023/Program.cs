namespace Hollywood2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawFace(5, 5,true);

            

            Console.SetCursorPosition(1, Console.WindowHeight - 1);
            
            
            DrawFace(20, 5,false);
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
            DrawRectangle(x + 1, y + 6, '-', 4, 1);
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
    }
}
