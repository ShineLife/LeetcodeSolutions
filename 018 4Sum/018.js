/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[][]}
 */
var fourSum = function(A, target, seen = new Set(), ans = []) {
    let N = A.length;
    A.sort((a, b) => a - b);
    for (let i = 0; i + 3 < N; ++i) {
        for (let j = i + 3; j < N; ++j) {
            let u = i + 1,
                v = j - 1;
            while (u < v) {
                let sum = A[i] + A[u] + A[v] + A[j];
                if (sum == target) {
                    let key = `${A[i]},${A[u]},${A[v]},${A[j]}`;
                    if (!seen.has(key))
                        ans.push([A[i], A[u], A[v], A[j]]);
                    seen.add(key);
                    ++u;
                    --v;
                }
                else if (sum < target)
                    ++u;
                else
                    --v;
            }
        }
    }
    return ans;
};