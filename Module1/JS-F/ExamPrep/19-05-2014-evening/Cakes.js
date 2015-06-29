function solve(params) {
    var s = params[0], c1 = params[1], c2 = params[2], c3 = params[3];
    var answer = 0;
    var i, j, k, iMax, jMax, kMax, sum;
    iMax = (s / c1) * 1;
    jMax = (s / c2) * 1;
    kMax = (s / c3) * 1;

    for (i = 0; i <= iMax; i += 1) {
        for (j = 0; j <= jMax; j += 1) {
            for (k = 0; k <= kMax; k += 1) {
                sum = i * c1 + j * c2 + k * c3;
                if (sum <= s && sum > answer) {
                    answer = sum;
                }
            }
        }
    }


    console.log(answer);
}


//console.log(solve([110, 13, 15, 17]));