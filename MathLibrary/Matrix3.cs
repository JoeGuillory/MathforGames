﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public struct Matrix3
    {
        public float
            m00, m01, m02,
            m10, m11, m12,
            m20, m21, m22;
        
        public Matrix3(
            float m00, float m01, float m02,
            float m10, float m11, float m12,
            float m20, float m21, float m22)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m02 = m02;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
            this.m20 = m20;
            this.m21 = m21;
            this.m22 = m22;
        }

        public static Matrix3 Identity
        {
            get
            {
                return new Matrix3
                  (1, 0, 0,
 
                   0, 1, 0,
 
                   0, 0, 1);
                
            }
           
        }
        /// <summary>
        /// Converts a Matrix to a string output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string matrix = ("| " + m00 + "," + m01 + "," + m02 + "|") +
                ("\n| " + m10 + "," + m11 + "," + m12 + "|") +
                ("\n| " + m20 + "," + m21 + "," + m22 + "|");
                
            return matrix;
        }
        /// <summary>
        /// Creates a Translation Matrix
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Matrix3 CreateTranslation(float x, float y)
        {
            return new Matrix3(1, 0, x,
                               0, 1, y,
                               0, 0, 1);
        }
        /// <summary>
        /// Creates a Rotation Matrix
        /// </summary>
        /// <param name="radians"></param>
        /// <returns></returns>
        public static Matrix3 CreateRotation(float radians)
        {
            return new Matrix3(MathF.Cos(radians), -MathF.Sin(radians), 0,
                               MathF.Sin(radians), MathF.Cos(radians), 0,
                                 0, 0, 1);
        }

        /// <summary>
        /// Creates a Scale Matrix
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Matrix3 CreateScale(float x, float y)
        {
            return new Matrix3(x, 0, 0,
                               0, y, 0,
                               0, 0, 1);
        }
        /// <summary>
        /// Swaps the row and collums of a matrix
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static Matrix3 Transpose(Matrix3 mat)
        {
            return new Matrix3(mat.m00, mat.m10, mat.m20,
                               mat.m01, mat.m11, mat.m21,
                               mat.m02, mat.m12, mat.m22);

        }

        // adds two matricies
        public static Matrix3 operator +(Matrix3 a , Matrix3 b)
        {
            return new Matrix3(
            a.m00 + b.m00,
            a.m01 + b.m01,
            a.m02 + b.m02,
            a.m10 + b.m10,
            a.m11 + b.m11,
            a.m12 + b.m12,
            a.m20 + b.m20,
            a.m21 + b.m21,
            a.m22 + b.m22);
        }
        // subtracts two matricies
        public static Matrix3 operator -(Matrix3 a, Matrix3 b)
        {
           return new Matrix3(
           a.m00 - b.m00,
           a.m01 - b.m01,
           a.m02 - b.m02,
           a.m10 - b.m10,
           a.m11 - b.m11,
           a.m12 - b.m12,
           a.m20 - b.m20,
           a.m21 - b.m21,
           a.m22 - b.m22);
        }
        // Multiply a Matrix by a vector
        public static Vector3 operator *(Matrix3 a, Vector3 b)
        {
            return new Vector3(a.m00 * b.x + a.m01 * b.y + a.m02 * b.z,
                               a.m10 * b.x + a.m11 * b.y + a.m12 * b.z,
                               a.m20 * b.x + a.m21 * b.y + a.m22 * b.z);


        }
        // Multiply two Matricies
        // It multiply the rows of Matrix a to the Collums of matrix b
        public static Matrix3 operator *(Matrix3 a, Matrix3 b)
        {
            return new Matrix3(
                
                a.m00 * b.m00 + a.m01 * b.m10 + a.m02 * b.m20,
                a.m00 * b.m01 + a.m01 * b.m11 + a.m02 * b.m21,
                a.m00 * b.m02 + a.m01 * b.m12 + a.m02 * b.m22,
                a.m10 * b.m00 + a.m11 * b.m10 + a.m12 * b.m20,
                a.m10 * b.m01 + a.m11 * b.m11 + a.m12 * b.m21,
                a.m10 * b.m02 + a.m11 * b.m12 + a.m12 * b.m22,
                a.m20 * b.m00 + a.m21 * b.m10 + a.m22 * b.m20,
                a.m20 * b.m01 + a.m21 * b.m11 + a.m22 * b.m21,
                a.m20 * b.m02 + a.m21 * b.m12 + a.m22 * b.m22
                );

        }

    }


}
