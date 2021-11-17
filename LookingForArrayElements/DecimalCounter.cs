using System;

#pragma warning disable S2368

namespace LookingForArrayElements
{
    public static class DecimalCounter
    {
        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[] arrayToSearch, decimal[][] ranges)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (ranges is null)
            {
                throw new ArgumentNullException(nameof(ranges));
            }

            RangesCheck(ranges);
            void RangesCheck(decimal[][] ranges)
            {
                for (int i = 0; i < ranges.Length; i++)
                {
                    if (ranges[i] is null)
                    {
                        throw new ArgumentNullException(nameof(ranges));
                    }

                    int oneOfTheRangesIsEmpty_ReturnValidResult_Test = ranges[i].Length;
                    if (oneOfTheRangesIsEmpty_ReturnValidResult_Test == 0)
                    {
                        continue;
                    }

                    if (ranges[i].Length != 2)
                    {
                        throw new ArgumentException("The length of one of the ranges is less or greater than 2.");
                    }
                }
            }

            int result = 0;
            int indexOfCurrentElement = 0;
            bool currentElementInRange = false;
            do
            {
                int indexOfCurrentRangeArray = 0;
                do
                {
                    if (ranges.Length == 0 || arrayToSearch.Length == 0)
                    {
                        break;
                    }

                    if (ranges[indexOfCurrentRangeArray].Length == 0)
                    {
                        break;
                    }

                    if (arrayToSearch[indexOfCurrentElement] >= ranges[indexOfCurrentRangeArray][0] && arrayToSearch[indexOfCurrentElement] <= ranges[indexOfCurrentRangeArray][1])
                    {
                        result++;
                        currentElementInRange = true;
                    }

                    indexOfCurrentRangeArray++;
                }
                while (indexOfCurrentRangeArray < ranges.Length && !currentElementInRange);
                currentElementInRange = false;
                indexOfCurrentElement++;
            }
            while (indexOfCurrentElement < arrayToSearch.Length);
            return result;
        }

        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[] arrayToSearch, decimal[][] ranges, int startIndex, int count)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (ranges is null)
            {
                throw new ArgumentNullException(nameof(ranges));
            }

            RangesCheck(ranges);
            void RangesCheck(decimal[][] ranges)
            {
                for (int i = 0; i < ranges.Length; i++)
                {
                    if (ranges[i] is null)
                    {
                        throw new ArgumentNullException(nameof(ranges));
                    }

                    int oneOfTheRangesIsEmpty_ReturnValidResult_Test = ranges[i].Length;
                    if (oneOfTheRangesIsEmpty_ReturnValidResult_Test == 0)
                    {
                        continue;
                    }

                    if (ranges[i].Length != 2)
                    {
                        throw new ArgumentException("The length of one of the ranges is less or greater than 2.");
                    }
                }
            }

            if (startIndex < 0 || startIndex >= arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (count < 0 || count > arrayToSearch.Length - startIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            int result = 0;
            int length = startIndex + count;
            bool currentElementInRange = false;
            for (int i = startIndex; i < length; i++, currentElementInRange = false)
            {
                for (int k = 0; k < ranges.Length; k++)
                {
                    if (currentElementInRange)
                    {
                        break;
                    }

                    if (ranges[k].Length == 0)
                    {
                        continue;
                    }

                    if (arrayToSearch[i] >= ranges[k][0] && arrayToSearch[i] <= ranges[k][1])
                    {
                        result++;
                        currentElementInRange = true;
                    }
                }
            }

            return result;
        }
    }
}
