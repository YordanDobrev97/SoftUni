<?php
$months = ["January", "February", "March", "April", "May", "June", "July", "August","September", "October", "November", "December"];

$number_month = intval(readline());

if($number_month > 12 || $number_month < 0){
    echo 'Invalid month!';
}else{
    echo $months[$number_month - 1];
}
?>

