public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN:
        // 1. We need to return an array of doubles with exactly 'length' items in it.
        // 2. The first item in the array should be 1 x number, the second item should be
        //    2 x number, the third item should be 3 x number, and so on. In general, the
        //    item at index i (starting at i = 0) should be (i + 1) x number.
        // 3. Create a new array of doubles that is 'length' items long to hold our results.
        // 4. Loop through every index from 0 up to (but not including) 'length'.
        // 5. On each loop iteration, calculate the multiple for that position using the
        //    formula (index + 1) * number, and store it in the array at that index.
        // 6. Once the loop is finished, every position in the array will contain the
        //    correct multiple, so return the completed array.

        var multiples = new double[length];

        for (var i = 0; i < length; i++)
        {
            multiples[i] = (i + 1) * number;
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.


    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN:
        // 1. Rotating the list to the right by 'amount' means the last 'amount' items in the
        //    list need to move to the front, and everything else shifts down to make room,
        //    keeping its original relative order.
        //    Example: {1,2,3,4,5,6,7,8,9} rotated right by 3 becomes {7,8,9,1,2,3,4,5,6}.
        //    The last 3 items (7,8,9) become the new beginning, followed by the remaining
        //    first 6 items (1,2,3,4,5,6) in their original order.
        // 2. This means the list can be split into two pieces:
        //      - the "tail" piece: the last 'amount' items (these move to the front)
        //      - the "head" piece: everything before the tail piece (these stay in order,
        //        just shifted after the tail piece)
        // 3. Use List<int>'s GetRange(index, count) method to grab each of these two pieces
        //    into their own separate lists:
        //      - tailPart = data.GetRange(data.Count - amount, amount)
        //      - headPart = data.GetRange(0, data.Count - amount)
        // 4. Since the function must modify 'data' directly (rather than returning a new
        //    list), clear out the existing contents of 'data' with data.Clear().
        // 5. Add the tailPart back into data first (so it becomes the new front of the list),
        //    then add the headPart right after it, using AddRange() for both so the internal
        //    order of each piece is preserved.
        // 6. After both AddRange() calls, 'data' now holds all of the original items, but
        //    rotated to the right by exactly 'amount' positions.

        var tailPart = data.GetRange(data.Count - amount, amount);
        var headPart = data.GetRange(0, data.Count - amount);

        data.Clear();
        data.AddRange(tailPart);
        data.AddRange(headPart);
    }
}
