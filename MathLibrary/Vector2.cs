﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public struct Vector2
    {
        public float x, y;

        //Calculates the magnitude
        public float Magnitude
        {
            get
            {
                return (float)Math.Abs(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
            }
        }
        // Gets the vector to a length of 1
        public Vector2 Normalized
        {
            get
            {
                if (Magnitude == 0)
                    return new Vector2();
                return this / Magnitude;
            }
        }

        /// <summary>
        /// Out puts a string of the vector
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
        public Vector2(float x = 0, float y = 0)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// Normalizes a vector
        /// </summary>
        /// <returns></returns>
        public Vector2 Normalize()
        {
            this = Normalized;
            return this;
        }

        /// <summary>
        /// Gets the Dot product of this Objects vector to another vector
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public float DotProduct(Vector2 other)
        {
            return (x * other.x) + (y * other.y);
        }
        /// <summary>
        /// Gets the Dot Product of two different Vectors
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public float DotProduct(Vector2 left, Vector2 right)
        {
            return (left.x * right.x) + (left.y * right.y);
        }
        /// <summary>
        /// Swaps the x and y of a vector
        /// </summary>
        /// <returns></returns>
        public Vector2 CrossProduct()
        {
            return new Vector2(y, x);
        }
        /// <summary>
        /// Gets the angle of this object to another object
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public float Angle(Vector2 other)
        {
            return (float)Math.Acos(other.DotProduct(this));
        }
        /// <summary>
        /// Gets the distance from this objecto to another object
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public  float Distance(Vector2 other)
        {
            return (other - this).Magnitude;
        }
        /// <summary>
        /// Gets the distance of two different objects
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static float Distance(Vector2 left, Vector2 right)
        {
            return (left - right).Magnitude;
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
        // Scale a vector up
        public static Vector2 operator *(Vector2 left, float scaler)
        {
            return new Vector2(left.x * scaler, left.y * scaler);
        }
        // Scale a vector but the input method is swapped
        public static Vector2 operator *(float scaler, Vector2 left)
        {
            return new Vector2(left.x * scaler, left.y * scaler);
        }
        //Scale a vector down
        public static Vector2 operator /(Vector2 left, float scaler)
        {
            return new Vector2(left.x / scaler, left.y / scaler);
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
