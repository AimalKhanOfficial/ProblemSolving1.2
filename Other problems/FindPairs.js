//Brute force solution

const isFirstPointerValLess = (a, b) => a < b;
const findDistinchPairs = (arr=[]) => {
    let hashMap = new Map();
    for (let i = 0; i < arr.length; i++) {
        for (let j = i + 1; j < arr.length; j++) {
            if (arr[i] === arr[j]) continue;
            if (Math.abs(arr[i]-arr[j])===2) {
                isFirstPointerValLess(arr[i], arr[j]) ? hashMap.set(arr[i], arr[j]) : hashMap.set(arr[j], arr[i]);
            }
        }
    }
    return hashMap;
}

//Sort and apply binary search 
const findDistPairsNext = (arr=[]) => {
    //Coming soon
    return [];
}

const res = findDistinchPairs([1, 7, 5, 9, 2, 12, 3]);
console.log(res);


