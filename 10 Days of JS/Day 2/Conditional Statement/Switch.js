'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(string => {
        return string.trim();
    });
    
    main();    
});

function readLine() {
    return inputString[currentLine++];
}

function getLetter(s) {
    let letter;
    let firstCh = s.charAt(0);
    // Write your code here
    switch (true) {
        case "aeiou".includes(firstCh):
            letter = "A";
            break;
        case "bcdfg".includes(firstCh):
            letter = "B";
            break;
        case "hjklm".includes(firstCh):
            letter = "C";
            break;
        default:
            letter = "D";
    }

    return letter;
}

function main() {
    const s = readLine();
    
    console.log(getLetter(s));
}