#!/usr/bin/env node

var singleNumbers = {} // use an object to hold numbers we've seen before
, rl = require('readline').createInterface({
	input: process.stdin,
	output: process.stdout,
	terminal: false
});

rl.on('line', function(line) {
	line.split(' ').forEach(function(number) {
		// If we've seen this number before, remove it from the object
		if (singleNumbers[number]) delete singleNumbers[number];
		else singleNumbers[number] = true;
	});
});

rl.on('close', function() {
	// print out all the non-pairs
	for (var number in singleNumbers) { console.log(number); }
});
