/*
Runtime: 52 ms, faster than 83.87% of JavaScript online submissions for Convert Binary Number in a Linked List to Integer.
Memory Usage: 33.8 MB, less than 100.00% of JavaScript online submissions for Convert Binary Number in a Linked List to Integer.
*/

//Definition for singly-linked list.
function ListNode(val) {
    this.val = val;
    this.next = null;
}

/**
 * @param {ListNode} head
 * @return {number}
 */
var getDecimalValue = function(head) {
    let toReturn = '';
    while (head && head != undefined) {
        toReturn += head.val;
        head = head.next;
    }
    return parseInt(toReturn, 2)
};

let head = new ListNode(1);
head.next = new ListNode(0);
head.next.next = new ListNode(0);

head.next.next.next = new ListNode(1);
head.next.next.next.next = new ListNode(0);
head.next.next.next.next.next = new ListNode(0);
head.next.next.next.next.next.next = new ListNode(1);
head.next.next.next.next.next.next.next = new ListNode(1);
head.next.next.next.next.next.next.next.next = new ListNode(1);

head.next.next.next.next.next.next.next.next.next = new ListNode(0);
head.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
head.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
head.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
head.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
head.next.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
console.log(getDecimalValue(head));