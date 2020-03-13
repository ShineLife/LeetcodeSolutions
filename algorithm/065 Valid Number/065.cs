using System.Text.RegularExpressions;
public class Solution {
    public bool IsNumber(string s) {
        s = s.Trim();
        
        bool n1 = false, n2 = false, e = false, dot = false;
        char last = '\0';
        
        foreach (char c in s.ToCharArray()) {
            if (c == 'e') {
                if (e || !n1) {
                    return false;
                }
                
                e = true;
            } else if (c == '-' || c == '+') {
                if (last != 'e' && last != '\0') {
                    return false;
                }
            } else if(c == '.') {
                if (e || dot) {
                    return false;
                }
                
                dot = true;
            } else if (!(c >= '0' && c <= '9')) {
                return false;
            } else {
                n1 = true;
                
                if (e) {
                    n2 = true;
                }
            }
            
            last = c;
        }
        
        if (e && !n2) {
            return false;
        }
        
        if (!n1) {
            return false;
        }
        
        return true;
    }
}