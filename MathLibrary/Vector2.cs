﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary
{
    public class Vector2
    {
        private float _x;
        private float _y;

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }

        //Length of vector
        public float Magnitude
        {
            //math has to have float because normally its a int
            get { return (float)Math.Sqrt(X * X + Y * Y); }
        }

        public Vector2 Normalized
        {
            get { return Normalize(this); }
        }



        public Vector2()
        {
            _x = 0;
            _y = 0;
        }

        public Vector2(float x, float y)
        {
            _x = x;
            _y = y;
        }

        /// <summary>
        /// Returns the normalized version of a the vector passed in.
        /// </summary> 
        /// <param name="vector">The vector that will be normalized</param>
        /// <returns></returns>
        /// 
        public static Vector2 Normalize(Vector2 vector)
        {
            //less than zero? Not Great :(
            if (vector.Magnitude == 0)
                return new Vector2();
            //greater that zero? Great!
            return vector / vector.Magnitude;
        }

        /// <summary>
        /// Returns the dot product of the two vectors given.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public static float DotProduct(Vector2 lhs, Vector2 rhs)
        {
            // X^2 + Y^2 = Dot Product
            return (lhs.X * rhs.X) + (lhs.Y * rhs.Y);
        }

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.X += rhs.X, lhs.Y += rhs.Y);
        }

        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }

        //this helps with scaleing (is that how you spell it?
        public static Vector2 operator *(Vector2 lhs, float scalar)
        {
            return new Vector2(lhs.X * scalar, lhs.Y * scalar);
        }

        public static Vector2 operator /(Vector2 lhs, float scalar)
        {
            return new Vector2(lhs.X / scalar, lhs.Y / scalar);
        }

    }
}
