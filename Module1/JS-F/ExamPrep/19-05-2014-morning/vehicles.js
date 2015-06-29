function solve(params) {
    var s = params[0];
    var count = 0,
        x,
        y,
        z,
        myS = s | 0;
    // Your solution here
    for (x = 0; x <= 50; x += 1) {
        for (y = 0; y <= 20; y += 1) {
            for (z = 0; z <= 66; z += 1) {
                if (4 * x + 10 * y + 3 * z === myS){
                    count +=1;
                }
            }
        }
    }

    console.log(count);
}