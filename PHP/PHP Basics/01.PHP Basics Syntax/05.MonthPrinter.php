<?php
$month = (int)readline();

$months = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];

if ($month > 12 || $month < 1) {
    echo "Error!";
} else {
    echo $months[$month - 1];
}
?>
