﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public struct Matrix4
    {
        public float m00, m01, m02, m03,
              m10, m11, m12, m13,
              m20, m21, m22, m23,
              m30, m31, m32, m33;


        public Matrix4(
            float m00, float m01, float m02, float m03,
            float m10, float m11, float m12, float m13,
            float m20, float m21, float m22, float m23,
            float m30, float m31, float m32, float m33)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m02 = m02;
            this.m03 = m03;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m20 = m20;
            this.m21 = m21;
            this.m22 = m22;
            this.m23 = m23;
            this.m30 = m30;
            this.m31 = m31;
            this.m32 = m32;
            this.m33 = m33;

        }

        public static Matrix4 Identity
        {
            get
            {
                return new Matrix4(
                1, 0, 0, 0,
                0, 1, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1);
            }
        }

        /// <summary>
        ///  Converts matrix to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string matrix = ("| " + m00 + "," + m01 + "," + m02 + "," + m03 + "|") +
                            ("\n| " + m10 + "," + m11 + "," + m12 + ", "+ m13 + "|") +
                            ("\n| " + m20 + "," + m21 + "," + m22 + ", "+ m23 + "|") +
                            ("\n| " + m30 + "," + m31 + "," + m32 + ", "+ m33 + "|");

            return matrix;
        }

        public static Matrix4 Transpose(Matrix4 mat)
        {
            return new Matrix4(mat.m00, mat.m10, mat.m20, mat.m30,
                               mat.m01, mat.m11, mat.m21, mat.m31,
                               mat.m02, mat.m12, mat.m22, mat.m32,
                               mat.m03, mat.m13, mat.m23, mat.m33);


        }

        /// <summary>
        /// Create a X rotation matrix 
        /// </summary>
        /// <param name="radian"></param>
        /// <returns></returns>
        public static Matrix4 CreateRotationX(float radian)
        {
            return new Matrix4(1,0,0,0,
                              0,MathF.Cos(radian), -MathF.Sin(radian),0, 
                              0,MathF.Sin(radian), MathF.Cos(radian),0,
                              0,0,0,1);
        }

        /// <summary>
        /// Creates a Y rotation Matrix
        /// </summary>
        /// <param name="radian"></param>
        /// <returns></returns>
        public static Matrix4 CreateRotationY(float radian)
        {
            return new Matrix4(MathF.Cos(radian), 0, MathF.Sin(radian), 0,
                               0, 1, 0, 0, 
                               -MathF.Sin(radian), 0, MathF.Cos(radian), 0,
                               0, 0, 0, 1);
                              
        }
        /// <summary>
        /// Creates a Z rotation Matrix
        /// </summary>
        /// <param name="radian"></param>
        /// <returns></returns>
        public static Matrix4 CreateRotationZ(float radian)
        {
            return new Matrix4(MathF.Cos(radian), -MathF.Sin(radian), 0, 0,
                              MathF.Sin(radian), MathF.Cos(radian), 0, 0,
                              0, 0, 1, 0, 0, 0, 0, 1);
        }

        // add two matricies 
        public static Matrix4 operator +(Matrix4 a, Matrix4 b)
        {
            return new Matrix4(
              a.m00 + b.m00,
              a.m01 + b.m01,
              a.m02 + b.m02,
              a.m03 + b.m03,
              a.m10 + b.m10,
              a.m11 + b.m11,
              a.m12 + b.m12,
              a.m13 + b.m13,
              a.m20 + b.m20,
              a.m21 + b.m21,
              a.m22 + b.m22,
              a.m23 + b.m23,
              a.m30 + b.m30,
              a.m31 + b.m31,
              a.m32 + b.m32,
              a.m33 + b.m33);
        }
        // subtract two matricies
        public static Matrix4 operator -(Matrix4 a, Matrix4 b
            )
        {
            return new Matrix4(
              a.m00 - b.m00,
              a.m01 - b.m01,
              a.m02 - b.m02,
              a.m03 - b.m03,
              a.m10 - b.m10,
              a.m11 - b.m11,
              a.m12 - b.m12,
              a.m13 - b.m13,
              a.m20 - b.m20,
              a.m21 - b.m21,
              a.m22 - b.m22,
              a.m23 - b.m23,
              a.m30 - b.m30,
              a.m31 - b.m31,
              a.m32 - b.m32,
              a.m33 - b.m33);
        }
        // multiply  a matrix by a vector
        public static Vector4 operator *(Matrix4 a, Vector4 b)
        {
            return new Vector4(a.m00 * b.x + a.m01 * b.y + a.m02 * b.z + a.m03 * b.w,
                               a.m10 * b.x + a.m11 * b.y + a.m12 * b.z + a.m13 * b.w,
                               a.m20 * b.x + a.m21 * b.y + a.m22 * b.z + a.m23 * b.w,
                               a.m30 * b.x + a.m31 * b.y + a.m32 * b.z + a.m33 * b.w);


        }
        // multiply two matricies
        //It multiply the rows of Matrix a to the Collums of matrix b
        public static Matrix4 operator *(Matrix4 a, Matrix4 b)
        {

            return new Matrix4(
                a.m00 * b.m00 + a.m01 * b.m10 + a.m02 * b.m20 + a.m03 * b.m30,
                a.m00 * b.m01 + a.m01 * b.m11 + a.m02 * b.m21 + a.m03 * b.m31,
                a.m00 * b.m02 + a.m01 * b.m12 + a.m02 * b.m22 + a.m03 * b.m32,
                a.m00 * b.m03 + a.m01 * b.m13 + a.m02 * b.m23 + a.m03 * b.m33,
                a.m10 * b.m00 + a.m11 * b.m10 + a.m12 * b.m20 + a.m13 * b.m30,
                a.m10 * b.m01 + a.m11 * b.m11 + a.m12 * b.m21 + a.m13 * b.m31,
                a.m10 * b.m02 + a.m11 * b.m12 + a.m12 * b.m22 + a.m13 * b.m32,
                a.m10 * b.m03 + a.m11 * b.m13 + a.m12 * b.m23 + a.m13 * b.m33,
                a.m20 * b.m00 + a.m21 * b.m10 + a.m22 * b.m20 + a.m23 * b.m30,
                a.m20 * b.m01 + a.m21 * b.m11 + a.m22 * b.m21 + a.m23 * b.m31,
                a.m20 * b.m02 + a.m21 * b.m12 + a.m22 * b.m22 + a.m23 * b.m32,
                a.m20 * b.m03 + a.m21 * b.m13 + a.m22 * b.m23 + a.m23 * b.m33,
                a.m30 * b.m00 + a.m31 * b.m10 + a.m32 * b.m20 + a.m33 * b.m30,
                a.m30 * b.m01 + a.m31 * b.m11 + a.m32 * b.m21 + a.m33 * b.m31,
                a.m30 * b.m02 + a.m31 * b.m12 + a.m32 * b.m22 + a.m33 * b.m32,
                a.m30 * b.m03 + a.m31 * b.m13 + a.m32 * b.m23 + a.m33 * b.m33
                );

        }


    }
}
