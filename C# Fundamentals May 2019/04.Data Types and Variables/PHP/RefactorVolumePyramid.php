<?php
$length = 0;
$width = 0;
$height = 0;

echo "Length: ";
$length = floatval(readline());
echo "Width: ";
$width = floatval(readline());
echo "Height: ";
$height = floatval(readline());
$result = ($length * $width * $height) / 3;
echo sprintf("Pyramid Volume: %.2f", $result) . PHP_EOL;


?>
