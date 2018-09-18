<?php

echo 'The Alphabet with for loop: ';

for($i = 97;  $i <= 122; $i++){
    echo chr($i)." ";
}
echo '<br><br>';

echo 'The Alphabet with foreach loop: ';
foreach (range('a', 'z') as $char) {
    echo $char . "\n";
}
?>