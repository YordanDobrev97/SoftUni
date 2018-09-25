<?php
$nums = [1,2,3,4];

$indx = 0;
$condensed = [];
$length_arr = count($nums);

if($length_arr <= 1){
    echo "Too few elements in the array";
}else{
while($length_arr > 1){
    for($i = 0; $i < count($nums) - 1; $i++){
        $current_element = $nums[$i];
        $next_element = $nums[$i + 1];
        echo " $current_element  -> $next_element "."<br>";
        $sum = $current_element + $next_element;
        
        echo "Sum: $sum"."<br>";
        $condensed[$indx] = $sum;
        $indx++;
    }
    $last = $nums[count($nums) - 1];
    echo "Last $last "."<br>";
    unset($nums[count($nums) - 1]);
    $length_arr--;
    $indx = 0;
    $nums = $condensed;
}
    echo "Result: $condensed[0]";
}
?>

