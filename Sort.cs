namespace List
{
    class Sort
    {
        //冒泡排序
        public void BubbleSort(int[] arr)
        {
            bool swapped;
            for (int j = 0; j < arr.Length; j++)
            {
                swapped = false;
                for (int i = 0; i < arr.Length - j; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        (arr[i + 1], arr[i]) = (arr[i], arr[i + 1]);
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        //选择排序
        public void ChooseSort(int[] arr)
        {
            //外层for循环用于交换
            for (int i = 0; i < arr.Length; i++)
            {
                //最小元素的索引
                int min = 1;
                //内层for循环用于比较
                for (int  j = 0; j < arr.Length-i; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                    //当完成循环后，arr[min]存储的就是当前最小元素
                    (arr[min], arr[i]) = (arr[i], arr[min]);
                }
            }
        }
    }
}
