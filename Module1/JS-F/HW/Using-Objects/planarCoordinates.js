//Write functions for working with shapes in standard Planar coordinate system.
//    Points are represented by coordinates P(X, Y)
//    Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
//Calculate the distance between two points.
//Check if three segment lines can form a triangle.

function Point(x, y) {
    this.x = x;
    this.y = y;
}

Point.prototype.toString = function (){
    return 'P(' + this.x + ', ' + this.y + ')';
};

function Line(p1, p2) {
    this.p1 = p1;
    this.p2 = p2;
}

Line.prototype.toString = function () {
    return 'L(' + this.p1.toString() + ', ' + this.p2.toString() + ')'
};

function calcDistance(p1, p2) {
    return Math.sqrt((p2.x - p1.x) * (p2.x - p1.x) + (p2.y - p1.y) * (p2.y - p1.y))
}

function calcLenght(line) {
    return calcDistance(line.p1, line.p2);
}

function canFormTriangle (l1, l2, l3) {
    var l1Lenght = calcLenght(l1),
        l2Lenght = calcLenght(l2),
        l3Lenght = calcLenght(l3);

    return (l1Lenght + l2Lenght > l3Lenght && l2Lenght + l3Lenght > l1Lenght && l1Lenght + l3Lenght > l2Lenght);
}



var point1 = new Point(1.5, 3),
    point2 = new Point(2.6, 2.5),
    point3 = new Point(3.1, 1.2),
    line1 = new Line(point1, point2),
    line2 = new Line(point2, point3),
    line3 = new Line(point3, point1);


console.log('Points: ' + point1.toString() + ', ' + point2.toString() + ', ' + point3.toString());
console.log('Lines: ' + line1.toString() + ', ' + line2.toString() + ', ' + line3.toString());
console.log('Distance form ' + point1.toString() + ' to ' + point2.toString() + ' is ' + calcLenght(line1));
console.log('Check if three segment lines can form a triangle: ' + canFormTriangle(line1, line2, line3));