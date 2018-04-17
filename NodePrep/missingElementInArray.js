var testData = [2, 3, 5, 7];
var missingData = [];
var pushMissingData = function (start, end) {
    console.log("Missing numbers between " + start + " and " + end);
    while (start != end) {
        start = start + 1;
        if (start != end) {
            console.log(start);
            missingData.push(start)
        }
    }
};
console.log("Length of input :: " + testData.length);
for (var i = 0; i < testData.length - 1; i++) {
    if (testData[i] + 1 != testData[i + 1])
        pushMissingData(testData[i], testData[i + 1]);
}

console.log(missingData);