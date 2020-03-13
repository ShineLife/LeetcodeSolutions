using System.Drawing;
public class Solution {
    Point[] data = new Point[]
    {
        new Point(1, 0),
        new Point(0, 1),
        new Point(-1, 0),
        new Point(0, -1),
    };
    int mod = 0;
    public int[][] GenerateMatrix(int n) {
        int[][] ans = new int[n][];
        for(int i = 0;i < n;i ++)
        {
            ans[i] = new int[n];
            for(int j = 0; j < n; j ++)
            {
                ans[i][j] = 0; 
            }
        }
        int num = 1;
        Point now = new Point(0, 0);
        ans[0][0] = num;
        while (num < n * n)
            {
                
                Point new_point = new Point(now.X + data[mod].X, now.Y + data[mod].Y);
                if (new_point.X >= 0 && new_point.X < n && new_point.Y >= 0 && new_point.Y < n && ans[new_point.Y][new_point.X] == 0)
                {
                    num += 1;
                    ans[new_point.Y][new_point.X] = num;
                    now = new_point;
                    
                }
                else
                {
                    mod = mod + 1 == 4 ? 0 : mod + 1;
                }
            }
            return ans;
    }
}