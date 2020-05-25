<?php
$searchString = readline();
$patternSearching = explode(' ', readline());
$symbol = strtolower($patternSearching[0]);
$maxOccurrencesTimes = intval($patternSearching[1]);

$currentOccurrencesTimes = 0;
$index = 0;
$found = false;
for ($i = 0; $i < strlen($searchString); $i++) {
    if (strtolower($searchString[$i]) == $symbol) {
        $index = $i;
        $currentOccurrencesTimes++;
    }

    if ($currentOccurrencesTimes == $maxOccurrencesTimes) {
        $found = true;
        break;
    }
}

if (!$found) {
    echo 'Find the letter yourself!'.PHP_EOL;
} else {
    echo $index;
}
?>
