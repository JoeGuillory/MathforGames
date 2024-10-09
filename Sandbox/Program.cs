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
            Vector2 deltaPosition = new Vector2(0, 0);
            Vector2 position = new Vector2();
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                int speed = 1000;
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Black);
                Raylib.DrawRectangle((int)position.X, (int)position.Y, 80, 80, Color.SkyBlue);
                
                
                
                int up = Raylib.IsKeyDown(KeyboardKey.W);
                int down = Raylib.IsKeyDown(KeyboardKey.S);
                int left = Raylib.IsKeyDown(KeyboardKey.A);
                int right = Raylib.IsKeyDown(KeyboardKey.D);

                deltaPosition.Y -= up;
                deltaPosition.Y += down;
                deltaPosition.X -= left;
                deltaPosition.X += right;
               
                
                position.X = deltaPosition.X * Raylib.GetFrameTime() * speed;
              
                position.Y = deltaPosition.Y * Raylib.GetFrameTime() * speed;

                
              

                



                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
