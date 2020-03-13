public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        List<int> x = new List<int>();
             foreach(int i in nums1)
                 x.Add(i);
             foreach(int i in nums2)
                 x.Add(i);
             x.Sort();
         if ((nums1.Length+nums2.Length) % 2 == 0){
            double xv = (double)(x[(nums1.Length + nums2.Length) / 2] + x[(nums1.Length + nums2.Length) / 2 - 1]) / 2;
              return xv;
         } 
         else
             return x[ (nums1.Length+nums2.Length)/2 ];
    }
}