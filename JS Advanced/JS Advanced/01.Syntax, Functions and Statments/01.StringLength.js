function getTotalLength(firstArgument, secondArgument, thirdArgument) {
    let totalLength = firstArgument.length + secondArgument.length + thirdArgument.length;
    let averageLength = Math.floor(totalLength / 3);

    console.log(totalLength);
    console.log(averageLength);
}

getTotalLength('chocolate', 'ice cream', 'cake');
getTotalLength('pasta', '5', '22.3');