<?php
function isPalindrome(string $text) : bool
{
    for ($i = 0; $i < strlen($text) / 2; $i++)
        if ($text[$i] !== $text[strlen($text) - $i - 1])
            return false;
    return true;
}

$line = readline();
$result = isPalindrome($line);
echo $result ? "true" : "false";
?>