<?php

$matrix = [
    [11,2,4],
    [4,5,6],
    [10,8,-12]
];
        
$leftSum = 0;
$length = count($matrix);

for($row = 0; $row < $length; $row++){
    $element = $matrix[$row][$row];
    $leftSum +=$element;
}
$rightSum = 0;

$row = 0;
for($i = $length - 1; $i >= 0; $i--){
    $element = $matrix[$row][$i];
    $rightSum +=$element;
    $row++;
}
$difference = abs($leftSum - $rightSum);
echo "Difference: $difference";

?>

