<?php
class Song
{
    private const MESSAGE_ERROR_SONG_LENGTH = 'Song name should be between 3 and 30 symbols.';
    private const MESSAGE_ERROR_SONG_MINUTES_SONG = 'Song minutes should be between 0 and 14.';
    private const MESSAGE_ERROR_SONG_SECONDS_SONG = 'Song seconds should be between 0 and 59.';
    private const MESSAGE_ERROR_ARTIST_LENGTH = 'Artist name should be between 3 and 20 symbols';

    private $artistName;
    private $name;
    private $length;

    public function __construct(string $artistName, string $name, array $length)
    {
        $this->setArtistName($artistName);
        $this->setName($name);
        $this->setLength($length);
    }

    public function getArtistName()
    {
        return $this->artistName;
    }

    public function getName()
    {
        return $this->name;
    }

    public function getLength()
    {
        return $this->length;
    }

    private function setArtistName($artistName): void
    {
        if (strlen($artistName) < 3 || strlen($artistName) > 20) {
            throw new Exception(self::MESSAGE_ERROR_ARTIST_LENGTH);
        }

        $this->artistName = $artistName;
    }

    private function setName(string $name): void
    {
        if (strlen($name) < 3 || strlen($name) > 30) {
            throw new Exception(self::MESSAGE_ERROR_SONG_LENGTH);
        }

        $this->name = $name;
    }

    private function setLength(array $length): void
    {
        $minutes = $length[0];
        $seconds = $length[1];

        if ($minutes < 0 || $minutes > 14) {
            throw new Exception(self::MESSAGE_ERROR_SONG_MINUTES_SONG);
        }

        if ($seconds < 0 || $seconds > 59) {
            throw new Exception(self::MESSAGE_ERROR_SONG_SECONDS_SONG);
        }

        $this->length = [
            'minutes' => $minutes,
            'seconds' => $seconds
        ];
    }
}

$number_songs = intval(readline());
$playlist = [];

for ($i = 0; $i < $number_songs; $i++) {
    $song_data = explode(';', readline());
    list($artist, $song, $length) = $song_data;
    list($minutes, $seconds) = explode(':', $length);

    try {
        $song = new Song($artist, $song, [$minutes, $seconds]);
        echo 'Song added.' . PHP_EOL;
        $playlist[] = $song;
    } catch (Exception $e) {
        echo $e->getMessage() . PHP_EOL;
    }
}

echo 'Songs added: ' . count($playlist) . PHP_EOL;

$min = 0;
$sec = 0;

foreach ($playlist as $song) {
    foreach ($song->getLength() as $key => $value) {
        if ($key == 'minutes') {
            $min += $value;
        } else if ($key == 'seconds') {
            $sec += $value;
        }
    }
}

$hour = intval($min / 60  + $sec / 60 / 60);
$min = $min - intval($min / 60) * 60 + intval($sec / 60) - intval($sec / 60 / 60) * 60 == 60
    ? 0 : $min - intval($min / 60) * 60 + intval($sec / 60) - intval($sec / 60 / 60) * 60;
$sec = $sec % 60;
$min = str_pad($min, 2, "0", STR_PAD_LEFT);
$sec = str_pad($sec, 2 , '0', STR_PAD_LEFT);

echo 'Playlist length: ' . $hour . 'h ' . $min . 'm ' . $sec . 's' . PHP_EOL;
?>