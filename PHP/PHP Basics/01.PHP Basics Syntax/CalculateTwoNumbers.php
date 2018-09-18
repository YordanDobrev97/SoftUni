<?php
$firstNumber = 10;
$secondNumber = 2;
$command = "multiply";

switch ($command){
    case "sum":
        $sum = $firstNumber + $secondNumber;
        echo 'Sum: '.$sum;
        break;
    case "subtract":
        $subtract = $firstNumber - $secondNumber;
        echo 'Subtract: '.$subtract;
        break;
    case "divide":
        $divide = $firstNumber / $secondNumber;
        echo 'Divide: '.$divide;
        break;;
    case "multiply":
        $multiply = $firstNumber * $secondNumber;
        echo 'Multiply: '.$multiply;
        break;
}
?>

