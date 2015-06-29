function solve(args) {
var result,
    //args = Array.prototype.slice.call(arguments),
    size = args[0].split(' ').map(function (item) {return item * 1}),
    directionMatrix = [],
    numbersMatrix = [],
    currPosition = {row: 0, col: 0},
    nextPosition,
    currDir,
    sum = 0;

    args.forEach(function(row, index) {
        if (index){
            directionMatrix.push(row.split(' '));
            numbersMatrix.push(row.split(' ').map(function(element, col) {
                return Math.pow(2, index - 1) + col;
            }));
        }
    });

    function newPosition (dir, row, col){
        if (dir === 'ul') {
            row -= 1;
            col -= 1
        }
        else if(dir === 'ur') {
            row -= 1;
            col +=1;
        }
        else if (dir === 'dl') {
            row += 1;
            col -=1;
        }
        else if (dir === 'dr') {
            row += 1;
            col +=1;
        }

        return {row: row, col: col}
    }

    while (true) {
        sum += numbersMatrix[currPosition.row][currPosition.col];
        numbersMatrix[currPosition.row][currPosition.col] = -1;
        currDir = directionMatrix[currPosition.row][currPosition.col];
        nextPosition = newPosition(currDir, currPosition.row, currPosition.col);
        if (nextPosition.row < 0 || nextPosition.col < 0 || nextPosition.row >= size[0] || nextPosition.col >= size[1] ){
            return 'successed with ' + sum;
        }
        else if (numbersMatrix[nextPosition.row][nextPosition.col] < 0) {
            return 'failed at (' + nextPosition.row + ', ' + nextPosition.col + ')';
        }

        currPosition = nextPosition;
    }
}

//console.log(solve('3 5', 'dr dl dr ur ul', 'dr dr ul ur ur', 'dl dr ur dl ur'));
/*
console.log(solve([
        '3 5',
        'dr dl dr ur ul',
        'dr dr ul ur ur',
        'dl dr ur dl ur'
    ]
));*/
