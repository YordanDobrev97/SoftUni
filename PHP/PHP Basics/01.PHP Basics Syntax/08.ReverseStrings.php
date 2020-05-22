<?php

while (true) {
    $line = readline();
    if ($line == 'end') {
        break;
    }

    $reversed = strrev($line);

    echo $line." = ".$reversed.PHP_EOL;
}

?>
