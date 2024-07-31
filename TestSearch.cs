namespace List
{
    class TeseSearch
    {
        //二分查找法 => 只能用于有序数组
        public static int BinarySearch(int[] arr, int target)
        {
            int l =0;
            int r =arr.Length-1;

            while (l<=r)
            {
                int mid =(l+r)/2;

                if(target < arr[mid])
                {
                    r = mid-1;
                }
                else if(target > arr[mid])
                {
                    l = mid +1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}