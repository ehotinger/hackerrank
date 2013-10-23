function processData(input) {
    var singleNumbers = {}
    input.split('\n')[1].split(' ').forEach(function(number) {
        // If we've seen this number before, remove it from the object
        if (singleNumbers[number]) delete singleNumbers[number];
        else singleNumbers[number] = true;
    });
    for (var number in singleNumbers) { console.log(number); }
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