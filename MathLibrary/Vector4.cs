using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public struct Vector4
    {
        public float x, y, z, w;


        public float Magnitude
        {
            get
            {
                return (float)Math.Abs(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2) + Math.Pow(w,2)));
            }
        }
        public Vector4 Normalized
        {
            get
            {
                return this / Magnitude;
            }
        }
        public override string ToString()
        {
            return "(" + x + ", " + y + ", " + z + "," + w +")";
        }
        public Vector4(float x = 0, float y = 0, float z = 0, float w = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
       public float GetMagnitude()
        {
            return Magnitude;
        }

        public Vector4 Normalize()
        {
            this = Normalized;
            return this;
        }
        /// <summary>
        /// Gets the Dot product of this Objects vector to another vector
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public float DotProduct(Vector4 other)
        {

            return (x * other.x) + (y * other.y) + (z * other.z) +(w * other.w);

        }
        /// <summary>
        /// Gets the Dot proctuct of two different Vectors
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static float DotProduct(Vector4 left, Vector4 right)
        {

            return (left.x * right.x) + (left.y * right.y) + (left.z * right.z) + (left.w * right.w);

        }
        //𝑎 × 𝑏 = 𝑎𝑦 𝑏𝑧 − 𝑎𝑧 𝑏𝑦 cross for x
        //  𝑎𝑧 𝑏𝑥 − 𝑎𝑥 𝑏𝑧 cross for y
        //  𝑎𝑥 𝑏𝑦 − 𝑎𝑦 bx cross for z
        public Vector4 CrossProduct(Vector4 other)
        {
            return new Vector4((y * other.z - z * other.y), (z * other.x - x * other.z), (x * other.y - y * other.x), w);
        }
        public static Vector4 CrossProduct(Vector4 left, Vector4 right)
        {
            return new Vector4((left.y * right.z - left.z * right.y), (left.z * right.x - left.x * right.z), (left.x * right.y - left.y * right.x),left.w = 0);

        }

        //Checks if the Vectors are Equal
        public static bool operator ==(Vector4 left, Vector4 right)
        {
            return (left.x == right.x) && (left.y == right.y) && (left.z == right.z) && (left.w == right.w);
        }
        // Checks if the Vectors are NOT Equel
        public static bool operator !=(Vector4 left, Vector4 right)
        {
            return !(left == right);
        }
        // Adds two vectors
        public static Vector4 operator +(Vector4 left, Vector4 right)
        {
            return new Vector4(left.x + right.x, left.y + right.y, left.z + right.z,left.w + right.w);
        }
        //Substract two vectors
        public static Vector4 operator -(Vector4 left, Vector4 right)
        {
            return new Vector4(left.x - right.x, left.y - right.y, left.z - right.z, left.w - right.w);
        }
        // Scale a vector up
        public static Vector4 operator *(Vector4 left, float scaler)
        {
            return new Vector4(left.x * scaler, left.y * scaler, left.z * scaler, left.w * scaler);
        }
        public static Vector4 operator *(float scaler, Vector4 left)
        {
            return new Vector4(left.x * scaler, left.y * scaler, left.z * scaler, left.w * scaler);
        }
        //Scale a vector down
        public static Vector4 operator /(Vector4 left, float scaler)
        {
            return new Vector4(left.x / scaler, left.y / scaler, left.z / scaler, left.w / scaler);
        }
        //implicit conversion from System.Numerics.Vector3 to Vector3
        public static implicit operator Vector4(System.Numerics.Vector4 vector)
        {
            return new Vector4(vector.X, vector.Y, vector.Z,vector.W);
        }
        // implicit conversion from Vector3 to System.Numerics.Vector3
        public static implicit operator System.Numerics.Vector4(Vector4 vector)
        {
            return new System.Numerics.Vector4(vector.x, vector.y, vector.z,vector.w);
        }
    }
}
