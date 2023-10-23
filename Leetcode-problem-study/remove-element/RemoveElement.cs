namespace remove_element
{
    public static class RemoveElement
    {
        public static int GetRemoveableIndex(int[] nums,int val)
        {
            int index = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }

            return index;
        }
    }
}
