using MathLibrary;
using Raylib_cs;

using System.Runtime.CompilerServices;
namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Matrix4 matrixone = new Matrix4(9,3,4,1,9,3,4,1,9,3,4,1,9,3,4,1);
            Matrix4 matrixtwo = new Matrix4(1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16);
            matrixone = matrixone * matrixtwo;
            Console.WriteLine(matrixone.ToString());
             
            Raylib.InitWindow(800, 400, "Hello World");
            Vector2 ScreenDimension = new Vector2 (Raylib.GetScreenWidth(), Raylib.GetScreenHeight());

            //Player
            Vector2 playerPosition = new Vector2(ScreenDimension.x * 0.5f, ScreenDimension.y * 0.75f);
            float playerRadius = 10;
            Vector2 playerForward = new Vector2(0, 1).Normalized;

            float playerViewAngle = 90;
            float playerViewDistance = 200;
            float playerSpeed = 50;

            //Enemy
            Vector2 enemyPosition = new Vector2(ScreenDimension.x * 0.5f, ScreenDimension.y * 0.50f);
            float enemyRadius = 10;
            Color enemyColor = Color.Red;
           
            Vector2 lol = new Vector2(3, 1);

           
            while (!Raylib.WindowShouldClose())
            {
                //Update
                //Movement


                Vector2 movementInput = new Vector2();
                movementInput.y -= Raylib.IsKeyDown(KeyboardKey.W);
                movementInput.y += Raylib.IsKeyDown(KeyboardKey.S);
                movementInput.x -= Raylib.IsKeyDown(KeyboardKey.A);
                movementInput.x += Raylib.IsKeyDown(KeyboardKey.D);

                playerPosition += movementInput * playerSpeed * Raylib.GetFrameTime();
                // Calculate LOS
                Vector2 playerToEnemyDirection = (playerPosition - enemyPosition).Normalized;
                float distance = enemyPosition.Distance(playerPosition);
                float angleToEnemy = (float)Math.Abs(playerToEnemyDirection.Angle(playerForward));
                

                // If enemy is in sight
                if (angleToEnemy < (playerViewAngle / 2) * (Math.PI / 180) && distance < playerViewDistance) 
                {

                    enemyColor = Color.Purple;

                }
                else
                {
                    enemyColor = Color.Red;
                }






                //Draw 
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);
                //Draw Enemy
                Raylib.DrawCircleV(enemyPosition, enemyRadius, enemyColor);

                //Draw Player
                Raylib.DrawCircleV(playerPosition, playerRadius, Color.Blue);

                //Draw player forward
                Raylib.DrawLineEx(playerPosition, playerPosition - (playerForward * 100),3, Color.Green);
                //Draw View Cone
                Raylib.DrawCircleSectorLines(playerPosition, playerViewDistance, (-90 - (playerViewAngle /2)), -90 + (playerViewAngle / 2), 10, Color.Blue);
                
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
