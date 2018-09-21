<?php

$firstValues = "5 4 3";
$firstArray = explode(" ", $firstValues);

$secondValues = "2 3 1 4";
$secondArray = explode(" ", $secondValues);

$lengthOfFirstArray = count($firstArray);
$lengthOfSecondArray = count($secondArray);

function fillingHoles($arr, $length){
    for($index = 0; $index <$length; $index++){
        $value = $arr[$index];
        array_push($arr, $value);
    }
    return $arr;
}

$length = 0;
if($lengthOfFirstArray < $lengthOfSecondArray){
    $length = $lengthOfSecondArray - $lengthOfFirstArray;
    $firstArray = fillingHoles($firstArray, $length);
    
}else{
    $length = $lengthOfFirstArray - $lengthOfSecondArray;
    $secondArray = fillingHoles($secondArray, $length);
}


$sumArray = [];

for($i = 0; $i < count($firstArray); $i++){
    $first = $firstArray[$i];
    $second = $secondArray[$i];
    
    $sum = $first + $second;
    array_push($sumArray, $sum);
}

printArray($sumArray);

function printArray($arr){
   foreach($arr as $element){
        echo $element." ";
    }   
}
echo "<br>";


?>

