public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int count = 0;
        for(int i = m;i<nums1.Length;i++)
            if(count < n)
            {
                nums1[i] = nums2[count];
                count += 1;
            }
        Quick_Sort(ref nums1, 0, nums1.Length - 1);
    }
    void Quick_Sort(ref int[] p, int left, int right)
    {
        if(left < right)
        {
            int i = left + 1;int j = right;int divided = left;
            while(true)
            {
                while (i <= right && p[i] <= p[divided])
                    i = i + 1;
                while (j > left && p[j] >= p[divided])
                    j = j - 1;
                if(i < j )
                {
                    int temp = p[i];
                    p[i] = p[j];
                    p[j] = temp;
                }
                else
                    break;
            }
            int te = p[divided];
            p[divided] = p[j];
            p[j] = te;
            Quick_Sort(ref p, left, j - 1);
            Quick_Sort(ref p, j + 1, right);
        }
    }
}