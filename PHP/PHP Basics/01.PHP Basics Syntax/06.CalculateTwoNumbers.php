<?php

function processCommand($command, $firstNumber, $secondNumber) {
    switch ($command) {
        case 'sum':
            return $firstNumber + $secondNumber;
        case 'subtract':
            return $firstNumber - $secondNumber;
        case 'divide':
            if ($firstNumber == 0 || $secondNumber == 0) {
                return "Cannot divide by zero";
            }
            return $firstNumber / $secondNumber;
        case 'multiply':
            return $firstNumber * $secondNumber;
        default:
            return 'Wrong operation supplied';
    }
}

$firstNumber = (int)readline();
$secondNumber = (int)readline();
$command = readline();

$result = processCommand($command, $firstNumber, $secondNumber);
echo $result;
?>
