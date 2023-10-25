namespace majority_element
{

    /*
     Example 1:

    Input: nums = [3,2,3]
    Output: 3
    Example 2:

    Input: nums = [2,2,1,1,1,2,2]
    Output: 2
     */
    public static class MajorityElementFinder
    {

        public static int Find(int[] nums)
        {
            int major = nums[0];
            int count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if(count==0)
                {
                    major = nums[i];
                    count = 1;
                }
                else if (major == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            return major;
        }
    }
}
