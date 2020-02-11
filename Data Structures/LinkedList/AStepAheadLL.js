class CustomNode {
    constructor(value) {
        this.value = value;
        this.next = undefined;
    }
}

class CustomLinkedList {
    constructor() {
        this.head = undefined;
    }

    addNodeToEnd(value) {
        if (this.head === undefined) {
            this.head = new CustomNode(value);
            return;
        }

        this.head.next = new CustomNode(value);
        list.push(prevNode);
    }

    displayNode() {
        let 
    }
}