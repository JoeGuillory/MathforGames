using MathLibrary;
using Raylib_cs;
using System.Numerics;
using System.Runtime.CompilerServices;
namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(Raylib.GetScreenWidth(), Raylib.GetScreenHeight(), "Hello World");
           
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                int speed = 1000;
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Black);
              
                Rectangle bullet = new Rectangle(0, 0, 10, 10);
                
                
                int up = Raylib.IsKeyDown(KeyboardKey.W);
                int down = Raylib.IsKeyDown(KeyboardKey.S);
                int left = Raylib.IsKeyDown(KeyboardKey.A);
                int right = Raylib.IsKeyDown(KeyboardKey.D);

                

             
                if (Raylib.IsKeyPressed(KeyboardKey.Space))
                {
                    


                }
              
                
              

                



                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
