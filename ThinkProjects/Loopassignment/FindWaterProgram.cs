﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment
{
    internal class FindWaterProgram
    {
        static float findWater(int i, int j,
                       float X)
        {
            // A row number i has maximum i
            // columns. So input column
            // number must be less than i
            if (j > i)
            {
                Console.WriteLine("Incorrect Input");
                Environment.Exit(0);
            }

            // There will be i*(i+1)/2 glasses
            // till ith row (including ith row)
            int ll = (int)Math.Round((double)(i * (i + 1)));
            float[] glass = new float[ll + 2];

            // Put all water in first glass
            int index = 0;
            glass[index] = X;

            // Now let the water flow to the
            // downward glasses till the row
            // number is less than or/ equal
            // to i (given row)
            // correction : X can be zero
            // for side glasses as they have
            // lower rate to fill
            for (int row = 1; row <= i; ++row)
            {
                // Fill glasses in a given row.
                // Number of columns in a row
                // is equal to row number
                for (int col = 1;
                        col <= row; ++col, ++index)
                {
                    // Get the water from current glass
                    X = glass[index];

                    // Keep the amount less than
                    // or equal to capacity in
                    // current glass
                    glass[index] = (X >= 1.0f) ?
                                          1.0f : X;

                    // Get the remaining amount
                    X = (X >= 1.0f) ? (X - 1) : 0.0f;

                    // Distribute the remaining amount
                    // to the down two glasses
                    glass[index + row] += X / 2;
                    glass[index + row + 1] += X / 2;
                }
            }

            // The index of jth glass in ith
            // row will be i*(i-1)/2 + j - 1
            return glass[(int)(i * (i - 1) /
                               2 + j - 1)];
        }

        // Driver Code
        static void Main()
        {
            int i = 2, j = 2;
            float X = 2.0f; // Total amount of water
            Console.WriteLine("Amount of water in jth " +
                                "glass of ith row is: " +
                                     findWater(i, j, X));
        }
    }
}
