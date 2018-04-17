var a = [5, 2, 4, 3, 6, 3, 1, 7];
console.log(a);
console.log("Length of test data :: " + a.length);

for (var i = 0; i < a.length; i++) {
    for (var j = i + 1; j < a.length; j++) {
        if(a[i] <= a[j]){
            var temp = a[j];
            a[j]=a[i];
            a[i]=temp;
        }
        console.log(a);
    }
}
console.log(a);