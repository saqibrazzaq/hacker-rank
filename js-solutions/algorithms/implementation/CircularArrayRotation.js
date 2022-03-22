function circularArrayRotation(a, k, queries) {
    // Write your code here
    var size = a.length;
    for (var i = 1; i <= k; i++) {
        // save number from the last position
        //var last = a[size - 1];
        // Remove last item
        var last = a.pop();
        a.unshift(last);
        
        //a[0] = last;
    }

    // Save queries in array
    var result = new Array();
    for (var i = 0; i < queries.length; i++) {
        result[i] = a[queries[i]];
        console.log(result[i]);
    }
    return result;
}

var result = circularArrayRotation(
    new Array(3, 4, 5),
    2,
    new Array(1, 2)
);
console.log(result);
