/**
 * @param {number[]} nums
 * @return {number}
 */
var maxSubArray = function(nums) {
    let maximum = -2147483647, cursum = 0;
    nums.forEach(x => {
        cursum = Math.max(cursum + x, x);
        maximum = Math.max(maximum, cursum);
    });
    return maximum;
};