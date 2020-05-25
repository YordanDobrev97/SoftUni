<?php
$login_system = [];

while (true) {
    $line = readline();

    if ($line == 'login') {
        break;
    } else {
        $parts = explode(' -> ', $line);
        $username = $parts[0];
        $password = $parts[1];

        $login_system[$username] = $password;
    }
}

$failed_count = 0;
while (true) {
    $line = readline();

    if ($line == 'end') {
        break;
    }

    $parts = explode(' -> ', $line);
    $username = $parts[0];
    $password = $parts[1];

    $user_password = $login_system[$username];
    if ($user_password && $user_password == $password) {
        echo "$username: logged in successfully".PHP_EOL;
    } else {
        echo "$username: login failed".PHP_EOL;
        $failed_count++;
    }
}

echo "unsuccessful login attempts: $failed_count";
?>