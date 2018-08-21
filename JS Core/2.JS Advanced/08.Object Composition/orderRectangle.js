function orderRectangle(matrix){
    for(let i = 0; i<matrix.length;i++) {
        matrix[i] = {
            width: matrix[i][0],
            heigth: matrix[i][1],
            area: function(){
                return this.width * this.heigth;
            },
            compareTo(otherRectangle){
                let areaDiff = otherRectangle.area() - this.area();
                return areaDiff || otherRectangle.width - this.width;
                // if(areaDiff === 0){
                //     return otherRectangle.width - this.width;
                // }
                // return areaDiff;
            }
        }
    }
    return matrix.sort((a, b) => a.compareTo(b));
}
console.log(orderRectangle([[10,5],[5,12]]));