/*
Runtime: 136 ms, faster than 87.76% of JavaScript online submissions for Roman to Integer.
Memory Usage: 41.6 MB, less than 6.38% of JavaScript online submissions for Roman to Integer.
*/

/**
 * @param {string} s
 * @return {number}
 */
var customMap = [
    {
        key: 'I',
        value: 1 
    },
    {
        key: 'V',
        value: 5
    },
    {
        key: 'X',
        value: 10
    },
    {
        key: 'L',
        value: 50
    },
    {
        key: 'C',
        value: 100
    },
    {
        key: 'D',
        value: 500
    },
    {
        key: 'M',
        value: 1000
    }
]

var romanToInt = function(s) {
    if (!s && s !== undefined) return s;
    let finalValue = 0;
    let allValues = s.split('');
    allValues.map((a, i) => {
        let curValIndex = customMap.findIndex(keyVal => keyVal.key === a);
        let curVal = customMap[curValIndex].value;
        if (i > 0) {
            let prevValue = customMap.find(keyVal => keyVal.key === allValues[i - 1]).value;
            if (prevValue < curVal) {
                curVal -= prevValue;
                finalValue -= prevValue;
            }
        } 
        finalValue += curVal;
    });
    return finalValue; 
};

console.log('>> Number is: ', romanToInt('MCMXCIV'));