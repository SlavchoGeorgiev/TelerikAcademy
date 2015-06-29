function solve(args) {
    var rows = args[0].split(' ')[0] | 0,
        cols = args[0].split(' ')[1] | 0,
        moves = [],
        gamepad = [],
        currentPosition = {
            row: rows - 1,
            col: cols - 1
        },
        newPosition,
        i, j, counter = 0,
        sum = 0;

    args.forEach(
        function (row, index) {
            if (index != 0) {
                moves.push(row.split('').map(
                    function (move) {
                        return move | 0;
                    }));
            }
        });

    gamepad.length = rows;
    for (i = 0; i < rows; i += 1) {
        gamepad[i] = [];
        for (j = 0; j < cols; j += 1) {
            gamepad[i].push(Math.pow(2, i) - j);
        }
    }

    function nextPosition(position, dir) {
        var newPosition = {
            row: position.row,
            col: position.col
        };
        switch (dir) {
            case 1 :
            {
                newPosition.row -= 2;
                newPosition.col += 1;
                return newPosition;
            }
            case 2 :
            {
                newPosition.row -= 1;
                newPosition.col += 2;
                return newPosition;
            }
            case 3 :
            {
                newPosition.row += 1;
                newPosition.col += 2;
                return newPosition;
            }
            case 4 :
            {
                newPosition.row += 2;
                newPosition.col += 1;
                return newPosition;
            }
            case 5 :
            {
                newPosition.row += 2;
                newPosition.col -= 1;
                return newPosition;
            }
            case 6 :
            {
                newPosition.row += 1;
                newPosition.col -= 2;
                return newPosition;
            }
            case 7 :
            {
                newPosition.row -= 1;
                newPosition.col -= 2;
                return newPosition;
            }
            case 8 :
            {
                newPosition.row -= 2;
                newPosition.col -= 1;
                return newPosition;
            }
        }
    }


    while (true){
        sum += gamepad[currentPosition.row][currentPosition.col];
        gamepad[currentPosition.row][currentPosition.col] = null;
        newPosition = nextPosition(currentPosition, moves[currentPosition.row][currentPosition.col]);
        counter += 1;
        if (newPosition.row < 0 || newPosition.col < 0 || newPosition.row >= rows || newPosition.col >= cols) {
            return 'Go go Horsy! Collected ' + sum + ' weeds';
        }
        if (gamepad[newPosition.row][newPosition.col] === null) {
            return 'Sadly the horse is doomed in ' + counter + ' jumps';
        }
        currentPosition = newPosition;
    }

}

//console.log(solve(['3 5', '54561', '43328', '52388']));
//console.log(solve(['3 5', '54361', '43326', '52188']));
