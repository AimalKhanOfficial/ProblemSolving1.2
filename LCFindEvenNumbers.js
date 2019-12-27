/*
Runtime: 68 ms, faster than 12.87% of JavaScript online submissions for Find Numbers with Even Number of Digits.
Memory Usage: 35.7 MB, less than 100.00% of JavaScript online submissions for Find Numbers with Even Number of Digits.
*/

var findNumbers = function(nums) {
    if (!nums) return nums;
    let response = 0;
    nums.map(a => {
        if (a.toString().length % 2 == 0) {
            response++;
        }
    }); 
    return response
};

console.log(findNumbers([555,901,482,1771]));