<?php
$words = explode(" ", readline());

foreach ($words as $word) {
    $lengthWord = strlen($word);

    echo str_repeat($word, $lengthWord);
}
?>
