<?php


class DecimalNumber
{
    private $number;

    public function __construct($number)
    {
        $this->number = $number;
    }

    private function reverse_number($number) : string {
        return strrev($number);
    }

    public function __toString()
    {
        return $this->reverse_number($this->number);
    }
}

$input = readline();
$number = new DecimalNumber($input);
echo $number;