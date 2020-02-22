const a = [17, 28, 30];
const b = [99, 16, 8];

let result = [];
let aliceResult = 0;
let bobResult = 0;

for (let j = 0; j < a.length; j++) {
  if (a[j] > b[j]) {
    aliceResult++;
  } else if (a[j] < b[j]) {
    bobResult++;
  }
}
console.log([aliceResult, bobResult]);
