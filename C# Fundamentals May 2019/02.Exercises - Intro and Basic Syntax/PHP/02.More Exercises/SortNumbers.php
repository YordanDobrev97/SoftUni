<?php
//solving only if statements
$firstNumber = floatval(readline());
$secondNumber = floatval(readline());
$thirdNumber = floatval(readline());

$biggestNumber = $firstNumber;

if ($secondNumber > $biggestNumber) {
    $biggestNumber = $secondNumber;
}

if ($thirdNumber > $biggestNumber) {
    $biggestNumber = $thirdNumber;
}

$smallestNumber = $firstNumber;

if ($secondNumber < $smallestNumber) {
    $smallestNumber = $secondNumber;
}

if ($thirdNumber < $smallestNumber) {
    $smallestNumber = $thirdNumber;
}

$middleNumber = $firstNumber;

for ($i = 0; $i < 3; $i++) {
    if (!($middleNumber !== $biggestNumber && $middleNumber !== $smallestNumber)) {
        if ($i === 0) {
            $middleNumber = $secondNumber;
        } else {
            $middleNumber = $thirdNumber;
        }
    } else {
        break;
    }
}

echo "$biggestNumber".PHP_EOL;
echo "$middleNumber".PHP_EOL;
echo "$smallestNumber".PHP_EOL;

?>
