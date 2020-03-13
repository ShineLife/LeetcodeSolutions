public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        string[] array1 = s.Split();
        int len1 = array1.Length ;
        char[] car = array1[len1 - 1].ToCharArray();
        return car.Length;
    }
}