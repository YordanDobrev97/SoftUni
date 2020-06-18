<?php

class Box
{
    private const MESSAGE_ERROR_LENGTH = 'Length cannot be zero or negative.';
    private const MESSAGE_ERROR_WIDTH = 'Width cannot be zero or negative.';
    private const MESSAGE_ERROR_Height = 'Height cannot be zero or negative.';

    private $length;
    private $width;
    private $height;

    public function __construct($length, $width, $height)
    {
        $this->setLength($length);
        $this->setWidth($width);
        $this->setHeight($height);
    }

    public function getLength()
    {
        return $this->length;
    }

    public function getWidth()
    {
        return $this->width;
    }

    public function getHeight()
    {
        return $this->height;
    }

    public function surfaceArea() {
        //formula: 2lw + 2lh + 2wh;
        return round(2 * $this->getLength() * $this->getWidth() + 2
            * $this->getLength() * $this->getHeight() + 2 * $this->getWidth()
            * $this->getHeight(), 2);
    }

    public function lateralSurfaceArea() {
        //formula: 2lh + 2wh
        return round(2 * $this->getLength() * $this->getHeight() + 2
            * $this->getWidth() * $this->getHeight() , 2);
    }

    public function volume() {
        //formula: lwh
        return round($this->getLength() * $this->getWidth() * $this->getHeight() , 2);
    }

    private function setLength($length)
    {
        if ($length <= 0) {
            throw new Exception(self::MESSAGE_ERROR_LENGTH);
        }

        $this->length = $length;
    }

    private function setWidth($width)
    {
        if ($width <= 0) {
            throw new Exception(self::MESSAGE_ERROR_WIDTH);
        }

        $this->width = $width;
    }

    private function setHeight($height)
    {
        if ($height <= 0) {
            throw new Exception(self::MESSAGE_ERROR_Height);
        }

        $this->height = $height;
    }

    public function __toString()
    {
       $builder = sprintf("Surface Area - %.2f\n", $this->surfaceArea());
       $builder .= sprintf("Lateral Surface Area - %.2f\n", $this->lateralSurfaceArea());
       $builder .= sprintf("Volume - %.2f\n" , $this->volume());

       return $builder;
    }
}

$length = readline();
$width = readline();
$height = readline();

try {
    $box = new Box($length, $width, $height);
    echo $box;
} catch (Exception $e) {
    echo $e->getMessage() . PHP_EOL;
}


