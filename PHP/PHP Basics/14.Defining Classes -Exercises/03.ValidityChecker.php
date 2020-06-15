<?php
$input = explode(', ', readline());
list($x1, $y1, $x2, $y2) = $input;

print_is_valid($x1, $y1, 0, 0);
print_is_valid($x2, $y2, 0, 0);
print_is_valid($x1, $y1, $x2, $y2);


function print_is_valid($x1, $y1, $x2, $y2) {
    if (is_valid_cordination($x1, $y1, $x2, $y2)) {
        echo "{{$x1}, {$y1}} to {{$x2}, {$y2}} is valid\n";
    } else {
        echo "{{$x1}, {$y1}} to {{$x2}, {$y2}} is invalid\n";
    }
}

function is_valid_cordination($x1, $y1, $x2, $y2) {
    $distance = sqrt(pow($x2 - $x1, 2) + pow($y2 - $y1, 2));

    if ($distance == intval($distance)) {
        return true;
    }
    return false;
}
?>