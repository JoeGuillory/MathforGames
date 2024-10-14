using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public struct Vector2
    {
        float x, y;

        public Vector2(float x = 0, float y = 0)
        {
            this.x = x;
            this.y = y;
        }

        //Checks if the Vectors are Equal
        public static bool operator ==(Vector2 left, Vector2 right)
        {
            return (left.x == right.x) && (left.y == right.y);
        }
        // Checks if the Vectors are NOT Equel
        public static bool operator !=(Vector2 left, Vector2 right)
        {
            return !(left == right);
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
        //implicit conversion from System.Numerics.Vector2 to Vector2
        public static implicit operator Vector2(System.Numerics.Vector2 vector)
        {
            return new Vector2(vector.X, vector.Y);
        }
        // implicit conversion from Vector2 to System.Numerics.Vector2
        public static implicit operator System.Numerics.Vector2(Vector2 vector)
        {
            return new System.Numerics.Vector2(vector.x, vector.y);
        }

    }

}
