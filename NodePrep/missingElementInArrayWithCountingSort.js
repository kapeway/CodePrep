var testData = [1,3,4,5,6,100,250];
var missingCountData = [];
var missingData = [];
var totalMissingNumbers = 0;
var k = 25;
var kthMissingTerm = k;
var indexWhereTheKthElementLies = 0;
var totalMissedNumbersTillIndex = 0; 

for (var i = 0; i < testData.length - 1; i++) {
    var missingNumbersBetweenItem = testData[i + 1] - testData[i] - 1;
    missingCountData.push(missingNumbersBetweenItem);
    totalMissingNumbers = totalMissingNumbers + missingNumbersBetweenItem;
}
console.log(missingCountData);
console.log(totalMissingNumbers);

if (kthMissingTerm <= totalMissingNumbers) {
    for (var j = 0; j < missingCountData.length; j++) {
        console.log("Inside missing element index check");
        kthMissingTerm = kthMissingTerm - missingCountData[j];
        totalMissedNumbersTillIndex = totalMissedNumbersTillIndex + missingCountData[j];
        console.log(kthMissingTerm);
        if (kthMissingTerm <= 0) {
            totalMissedNumbersTillIndex = totalMissedNumbersTillIndex - missingCountData[j];
            indexWhereTheKthElementLies = j;
            break;
        }
    }
} else {
    console.log("k is more than the number of missing elements");
}

console.log("kth missing element lies between index :: " + indexWhereTheKthElementLies);
console.log("missing numbers befor index :: " + totalMissedNumbersTillIndex);

//testData
console.log("~~~~~~~~~~~~~~~~~~~~~~~~~~");
console.log(testData[indexWhereTheKthElementLies]);
console.log(totalMissedNumbersTillIndex);
console.log(k);

var kthMissingData=testData[indexWhereTheKthElementLies]+(k-totalMissedNumbersTillIndex);
console.log("kth missing element is :: " + kthMissingData);

// var pushMissingData = function (start, end) {
//     console.log("Missing numbers between " + start + " and " + end);
//     while (start != end) {
//         start = start + 1;
//         if (start != end) {
//             console.log(start);
//             missingData.push(start)
//         }
//     }
// };
// console.log("Length of input :: " + testData.length);
// for (var i = 0; i < testData.length - 1; i++) {
//     if (testData[i] + 1 != testData[i + 1])
//         pushMissingData(testData[i], testData[i + 1]);
// }

// console.log(missingData);