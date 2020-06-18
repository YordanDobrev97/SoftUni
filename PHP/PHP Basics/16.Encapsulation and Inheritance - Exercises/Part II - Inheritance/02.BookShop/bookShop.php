<?php
class Book
{
    private const MESSAGE_ERROR_TITLE = 'Title not valid!';
    private const MESSAGE_ERROR_AUTHOR = 'Author not valid!';
    private const MESSAGE_ERROR_PRICE = 'Price not valid!';

    private $title;
    private $author;
    private $price;

    public function __construct($title, $author, $price)
    {
        $this->setTitle($title);
        $this->setAuthor($author);
        $this->setPrice($price);
    }

    public function getTitle()
    {
        return $this->title;
    }

    public function getAuthor()
    {
        return $this->author;
    }

    public function getPrice()
    {
        return $this->price;
    }

    private function setTitle($title): void
    {
        if (strlen($title) < 3) {
            throw new Exception(self::MESSAGE_ERROR_TITLE);
        }
        $this->title = $title;
    }

    public function setAuthor($author): void
    {
        $parts = explode(' ', $author);
        $last_name = $parts[1];

        if (is_numeric($last_name[0])) {
            throw new Exception(self::MESSAGE_ERROR_AUTHOR);
        }
        $this->author = $author;
    }

    private function setPrice($price): void
    {
        if ($price < 0) {
            throw new Exception(self::MESSAGE_ERROR_PRICE);
        }
        $this->price = $price;
    }

    public function __toString()
    {
       return $this->getPrice() . '';
    }
}

class GoldenEditionBook extends Book
{
    public function __construct($title, $author, $price)
    {
        parent::__construct($title, $author, ($price + ($price * 0.30)));
    }
}

$author = readline();
$title = readline();
$price = readline();
$type_book = readline();

try {
    if ($type_book == 'GOLD') {
        $golden_book = new GoldenEditionBook($title, $author, $price);
        echo "OK" . PHP_EOL;
        echo $golden_book;
    } else if ($type_book == 'STANDARD') {
        $book = new Book($title, $author, $price);
        echo "OK" . PHP_EOL;
        echo $book;
    }else {
        throw new Exception("Type is not valid!");
    }

} catch (Exception $e) {
    echo $e->getMessage() . PHP_EOL;
}
?>