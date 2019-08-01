public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int l1, l2;
        l1 = nums1.Length / 2;
        l2 = nums2.Length / 2;
        double m1 = 0, m2 = 0;
        if ( nums1.Length > 0)
        {
            if (nums1.Length % 2 == 0)
            {
                m1 = (double)(nums1[l1] + nums1[l1-1]) / 2;
            }
            else{
                m1 = nums1[l1];
            }
        }
        
        if (nums2.Length > 0) 
        {
            if (nums2.Length % 2 == 0)
            {
                m2 = (double)(nums2[l2] + nums2[l2-1]) / 2;
            }
            else{
            m2 = nums2[l2];
            }
        }
        
        return  (nums1.Length > 0 && nums2.Length > 0)?  (m1 + m2) /2 : m1+m2;
    }
}