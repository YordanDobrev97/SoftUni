<?php

$months = ["January", "February", "March", "April", "May", "June", "July", "August","September", "October", "November", "December"];

$numberMonth = 14;

if($numberMonth > 12 || $numberMonth < 0){
    echo 'Invalid month';
}else{
    echo $months[$numberMonth - 1];
}

?>

