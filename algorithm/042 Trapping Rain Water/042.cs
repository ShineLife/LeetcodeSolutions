public class Solution {
    public int Trap(int[] height) {
        int ans = 0;
            int current = 0;
            Stack<int> stack = new Stack<int>();
            while(current < height.Length)
            {
                while(stack.Count != 0 && height[current] > height[stack.Peek()])
                {
                    int top = stack.Pop();
                    if (stack.Count == 0)
                        break;
                    int distance = current - stack.Peek() - 1;
                    int limit_height = Math.Min(height[current], height[stack.Peek()]) - height[top];
                    ans += distance * limit_height;
                }
                stack.Push(current++);
            }
            return ans;
    }
}