/*
 * Create the function factorial here
 */

function factorial(n) {
    let output = n;
    while(n >= 2) {
        output = output * (n - 1);
        n--;
    }
    return output;
}