<?php

$first = intval(readline());
$count = intval(readline());

if ($count > 10) {
    $result = $first * $count;
    echo "$first X $count = $result\n";
} else {
    for($i = $count; $i <=10; $i++) {
        $result = $first * $i;
        echo "$first X $i = $result\n";
    }
}
?>
