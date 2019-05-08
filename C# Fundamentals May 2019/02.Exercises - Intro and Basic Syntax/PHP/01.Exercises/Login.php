<?php
$username = readline();
$password =strrev($username);

$times = 1;

while (true) {
    $input = readline();
    if ($times >= 4) {
        echo "User $username blocked!".PHP_EOL;
        break;
    }

    if ($input === $password) {
        echo "User $username logged in.".PHP_EOL;
        break;
    }

    echo "Incorrect password. Try again.".PHP_EOL;
    $times++;
}

?>