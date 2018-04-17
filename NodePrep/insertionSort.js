var a = [5, 2, 4, 3, 6, 3, 1, 7];
console.log(a);
console.log("Length of test data :: " + a.length);
var result = [];
var insertElement = function (valueToInsert) {
    console.log("Value to insert :: " + valueToInsert);
    if (result.length < 1) {
        console.log("Adding first element to new array");
        result.push(valueToInsert);
    }
    else {
        console.log("Iterating for the new array restructure");
        for(var j=0;j<result.length;j++){
            console.log(result);
            // if(result[j] > valueToInsert){
            //     var temp = result[j];
            //     result[j] = valueToInsert;
            //     result.push(temp); 
            // }
        }
    }
};

for (var i = 0; i < a.length; i++) {
    console.log(a[i]);
    insertElement(a[i]);
}

console.log(result);
