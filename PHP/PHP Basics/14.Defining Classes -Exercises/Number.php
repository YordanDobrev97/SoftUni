<?php


class Number
{
    private $number;

    public function __construct($number)
    {
        $this->number = $number;
    }

    public function get_last_digit($n) : string {
        $last_digit = substr($n, -1);

        switch ($last_digit) {
            case 1: $result = 'one'; break;
            case 2: $result = 'two'; break;
            case 3: $result = 'three'; break;
            case 4: $result = 'four'; break;
            case 5: $result = 'five'; break;
            case 6: $result = 'six'; break;
            case 7: $result = 'seven'; break;
            case 8: $result = 'eight'; break;
            case 9: $result = 'nine'; break;
            case 0: $result = 'zero'; break;
        }
        return $result;
    }

    public function __toString()
    {
        return $this->get_last_digit($this->number);
    }
}

$number = readline();
$num = new Number($number);

echo $num;