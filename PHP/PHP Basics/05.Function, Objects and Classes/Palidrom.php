<?php

function palidrome($input){
    function is_palidrome($front, $behid){
        return $front == $behid;
    }
    
    $length = strlen($input) / 2;
    $length_last = strlen($input) - 1;
    
    for($i = 0; $i < $length; $i++){
        $front = $input[$i];
        $behind = $input[$length_last];
        
        if(!is_palidrome($front, $behind)){
            return 'Not palidrome';
        }
        $length_last--;
    }
    
    return 'Yes, this is palidrome';
}

echo palidrome("abcccba");
?>

