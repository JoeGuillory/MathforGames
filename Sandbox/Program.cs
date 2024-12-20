﻿using Engine;
using MathLibrary;
using Raylib_cs;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 480, "Hello World");
            Raylib.SetTargetFPS(60);
            float ScaleMultiplyer = 100;

            Actor a = new Actor();

            Transform2D t1 = new Transform2D(a);
            t1.LocalScale = new Vector2(1, 1);
            
            Vector2 offset = new Vector2((ScaleMultiplyer) / 2, (ScaleMultiplyer) / 2);
            t1.LocalPosition = new Vector2((Raylib.GetScreenWidth() * 0.33f) - offset.x, (Raylib.GetScreenHeight() * 0.33f) - offset.y);


         

            while (!Raylib.WindowShouldClose())
            {
                
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);

                Rectangle bob = new Rectangle(t1.GlobalPosition + offset,t1.GlobalScale * ScaleMultiplyer);
                
                t1.Translate(t1.Forward * 50 * Raylib.GetFrameTime());
                t1.Rotate(1f * Raylib.GetFrameTime());

                //Draw t1
                Raylib.DrawRectanglePro(bob, new Vector2(0,0) + offset, -t1.GlobalRotationAngle * (180/(float)Math.PI), Color.Blue);
                Raylib.DrawLineV(t1.GlobalPosition + offset, t1.GlobalPosition + offset + (t1.Forward * 100), Color.Red);

               
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();


        }
    }
}
