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
            MathLibrary.Vector2 deltaPosition = new MathLibrary.Vector2(0, 0);
            MathLibrary.Vector2 playerPosition = new MathLibrary.Vector2(0, 0);
            
            Raylib.InitWindow(Raylib.GetScreenWidth(), Raylib.GetScreenHeight(), "Hello World");
           
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                int speed = 250;
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Black);
                Raylib.DrawRectangle((int)playerPosition.x, (int)playerPosition.y, 50, 50, Color.Blue);
                Rectangle bullet = new Rectangle(0, 0, 10, 10);
                
                
                int up = Raylib.IsKeyDown(KeyboardKey.W);
                int down = Raylib.IsKeyDown(KeyboardKey.S);
                int left = Raylib.IsKeyDown(KeyboardKey.A);
                int right = Raylib.IsKeyDown(KeyboardKey.D);
                deltaPosition.y -= up;
                deltaPosition.y += down;
                deltaPosition.x -= left;
                deltaPosition.x += right;
             
                

                playerPosition.x = deltaPosition.x * Raylib.GetFrameTime() * speed;
                playerPosition.y = deltaPosition.y * Raylib.GetFrameTime() * speed;
              
                
              

                



                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
