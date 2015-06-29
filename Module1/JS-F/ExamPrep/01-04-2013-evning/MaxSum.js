function solve(params) {
    var maxSum = params[1] * 1;

    for (var i = 1; i < (params[0] | 0); i += 1) {
        var curSum = params[i] * 1;
        maxSum = Math.max(curSum, maxSum);
        for (var j = i + 1; j < (params[0] | 0); j += 1) {
            curSum += (params[j] * 1);
            maxSum = Math.max(curSum, maxSum);
        }
    }

    return maxSum;
}


console.log(solve(['8','1','6','-9','4','4','-2','10','-1']));