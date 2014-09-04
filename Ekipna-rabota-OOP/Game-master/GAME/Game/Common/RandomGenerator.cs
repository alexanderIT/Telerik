﻿namespace Game.Common
{
    using System;

    public class RandomGenerator
    {
        private static Random generator;

        private RandomGenerator()
        {
        }

        public static Random Generator
        {
            get
            {
                if (generator == null)
                {
                    generator = new Random();
                }
                return generator;
            }
        }
    }
}
