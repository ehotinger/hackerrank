function processData(input) {
    var minDiff, diffPairs = {};

    input.split('\n')[1].trim().split(' ') // pull out the numbers
    .map(function(number) { return parseInt(number, 10); }) // parse integers
    .sort(function(a, b) { return a - b; }) // sort ascending
    .forEach(function(number, i, arr) {
        var nextNumber = arr[i + 1];
        if (!nextNumber) return;
        var diff = Math.abs(number - nextNumber);

        if (typeof minDiff === 'undefined' || diff < minDiff) minDiff = diff;
        if (typeof diffPairs[diff] === 'undefined') diffPairs[diff] = [];

        diffPairs[diff].push([number, nextNumber]);
    });

    console.log(diffPairs[minDiff].reduce(function(prev, curr) {
        return prev.concat(curr);
    }).join(' '));
}

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});
