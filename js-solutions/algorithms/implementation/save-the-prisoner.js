function saveThePrisoner(n, m, s) {
    // Write your code here
    // Reduce m, if it is greater number
    // start at s
    var warn = s;
    // start from s. Number of times = m candies
    //for (var i = s; i <= m; i++) {
        // Warn
        warn = (s + m - 1) % n;
    //}
    return warn % n == 0 ? n : warn;
}

var result = saveThePrisoner(5, 2, 2);
console.log(result);