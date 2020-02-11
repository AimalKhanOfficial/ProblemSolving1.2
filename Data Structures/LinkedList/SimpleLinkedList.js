let list = [];

let addNodeToEnd = (value) => {
    list.push(value);
}

let displayList = () => {
    list.map(item => {
        console.log(`${item} -> \t`);
    })
}

let searchNode = (value) => list.find(a => a === value) ? true : false;

let deleteNode = (value) => {
    let valIndex = list.indexOf(value);
    if (valIndex) list.splice(valIndex, 1);
} 

addNodeToEnd(1);
addNodeToEnd(15);
addNodeToEnd(2);
displayList();
console.log(searchNode(33));
deleteNode(15);
displayList();