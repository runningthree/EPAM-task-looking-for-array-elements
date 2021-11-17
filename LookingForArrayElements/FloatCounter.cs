using System;

namespace LookingForArrayElements
{
    public static class FloatCounter
    {
        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (rangeStart is null)
            {
                throw new ArgumentNullException(nameof(rangeStart));
            }

            if (rangeEnd is null)
            {
                throw new ArgumentNullException(nameof(rangeEnd));
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException("Invalid range");
            }

            for (int k = 0; k < rangeStart.Length; k++)
            {
                if (rangeStart[k] > rangeEnd[k])
                {
                    throw new ArgumentException("The range start value is greater than the range end value.");
                }
            }

            int result = 0;
            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                for (int k = 0; k < rangeStart.Length; k++)
                {
                    if (arrayToSearch[i] >= rangeStart[k] && arrayToSearch[i] <= rangeEnd[k])
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd, int startIndex, int count)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (rangeStart is null)
            {
                throw new ArgumentNullException(nameof(rangeStart));
            }

            if (rangeEnd is null)
            {
                throw new ArgumentNullException(nameof(rangeEnd));
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException("Invalid range");
            }

            for (int k = 0; k < rangeStart.Length; k++)
            {
                if (rangeStart[k] > rangeEnd[k])
                {
                    throw new ArgumentException("The range start value is greater than the range end value.");
                }
            }

            if (startIndex < 0 || startIndex >= arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (count < 0 || arrayToSearch.Length - startIndex < count)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            int result = 0;
            do
            {
                int currentIndexInArrayToSearch = startIndex + count - 1;
                int lengthOfRange = rangeStart.Length - 1;
                if (lengthOfRange < 0)
                {
                    break;
                }

                do
                {
                    if (arrayToSearch[currentIndexInArrayToSearch] >= rangeStart[lengthOfRange] && arrayToSearch[currentIndexInArrayToSearch] <= rangeEnd[lengthOfRange])
                    {
                        result++;
                    }
                }
                while (lengthOfRange-- > 0);
            }
            while (--count > 0);
            return result;
        }
    }
}
