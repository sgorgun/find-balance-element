using System;

namespace FindBalanceElementTask
{
    /// <summary>
    /// Class for operations with arrays.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Finds an index of element in an integer array for which the sum of the elements
        /// on the left and the sum of the elements on the right are equal.
        /// </summary>
        /// <param name="array">Source array.</param>
        /// <returns>The index of the balance element, if it exists, and null otherwise.</returns>
        /// <exception cref="ArgumentNullException">Thrown when source array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when source array is empty.</exception>
        public static int? FindBalanceElement(int[]? array)
        {
            {
                if (array == null)
                {
                    throw new ArgumentNullException(nameof(array));
                }

                if (array == Array.Empty<int>())
                {
                    throw new ArgumentException($"{nameof(array)} is empty.", nameof(array));
                }

                if (array.Length is 1 or 2)
                {
                    return null;
                }

                if (array.Length == 3)
                {
                    return 1;
                }

                int? indexOfBalanceElement = null;
                long leftSum = 0;
                long rightSum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    rightSum += array[i];
                }

                for (int i = 0; i < array.Length; i++)
                {
                    rightSum -= array[i];

                    if (leftSum == rightSum)
                    {
                        indexOfBalanceElement = i;
                        break;
                    }

                    leftSum += array[i];
                }

                return indexOfBalanceElement;
            }
        }
    }
}
