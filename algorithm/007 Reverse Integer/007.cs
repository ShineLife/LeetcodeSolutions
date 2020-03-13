public class Solution {
    public int Reverse(int x) {
         string num = x.ToString();
            if (x < 0)
                num = num.Substring(1);
            try
            {
                return (x < 0 ? -1 : 1) * int.Parse(String.Join("", num.Reverse()));
            }
            catch (Exception ex)
            {

                return 0;
            }
    }
}