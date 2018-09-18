<?php

$text = "PHP";
$lengthMax = 20;
$currentLengthOfText = strlen($text);
for($i = 0; $i < $currentLengthOfText; $i++){
    echo $text[$i];
}

if($currentLengthOfText < $lengthMax){
    $needLength = $lengthMax - $currentLengthOfText;
    for($i = 0; $i < $needLength; $i++){
        echo '*';
    }
}

?>

