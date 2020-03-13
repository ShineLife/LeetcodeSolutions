public class Solution {
    public bool IsPalindrome(int x) {
        return (new string(x.ToString().ToCharArray().Reverse().ToArray())) == x.ToString();
    }
}