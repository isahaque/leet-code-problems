namespace remove_duplicate
{
    public static class DuplicateRemover
    {
        /*
         Example 1:

            Input: nums = [1,1,2]
            Output: 2, nums = [1,2,_]
            Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
            It does not matter what you leave beyond the returned k (hence they are underscores).
            Example 2:

            Input: nums = [0,0,1,1,1,2,2,3,3,4]
            Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
            Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
            It does not matter what you leave beyond the returned k (hence they are underscores).
         */
        public static int Remove(int[] nums)
        {
            if(nums.Length==0)
                return 0;

            int k = 1;
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i-1])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }

        /*
         Example 1:

            Input: nums = [1,1,1,2,2,3]
            Output: 5, nums = [1,1,2,2,3,_]
            Explanation: Your function should return k = 5, with the first five elements of nums being 1, 1, 2, 2 and 3 respectively.
            It does not matter what you leave beyond the returned k (hence they are underscores).
            Example 2:

            Input: nums = [0,0,1,1,1,1,2,3,3]
            Output: 7, nums = [0,0,1,1,2,3,3,_,_]
            Explanation: Your function should return k = 7, with the first seven elements of nums being 0, 0, 1, 1, 2, 3 and 3 respectively.
            It does not matter what you leave beyond the returned k (hence they are underscores).
         */
        public static int RemoveIfAppearAtmostTwice(int[] nums)
        {
            int k = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if(k<2 || nums[i] > nums[k - 2])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}
