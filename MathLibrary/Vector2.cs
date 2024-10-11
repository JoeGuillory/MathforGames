using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MathLibrary
{
    public class Vector2
    {
        float x, y;

        public Vector2()
        {
            x = 0;
            y = 0;
        }
        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        // Adds two vectors
        public static Vector2 operator +(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x + right.x, left.y + right.y);
        }
        //Substract two vectors
        public static Vector2 operator -(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x - right.x, left.y - right.y);
        }
        //Multiply two vectors
        public static Vector2 operator *(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x * right.x, left.y * right.y);
        }
        // Scale a vector
        public static Vector2 operator *(Vector2 left, float right)
        {
            return new Vector2(left.x * right, left.y * right);
        }
        //Divide two vectors
        public static Vector2 operator /(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x / right.x, left.y / right.y);
        }
        // implicit conversion from System.Numerics.Vector2 to Vector2
       // public static implicit operator Vector2(System.Numerics.Vector2 vector)
       // {
       //     return new Vector2(vector.X, vector.Y);
       // }
      //  // implicit conversion from Vector2 to System.Numerics.Vector2
      //  public static implicit operator System.Numerics.Vector2(Vector2 vector)
       // {
       //     return new System.Numerics.Vector2(vector.x, vector.y);
       // }

    }
    

}
