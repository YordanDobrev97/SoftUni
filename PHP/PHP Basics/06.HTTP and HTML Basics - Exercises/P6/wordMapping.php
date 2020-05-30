<form>
    <textarea rows="5" cols="50" name="input"></textarea><br>
    <input type="submit" value="Count words"/>
</form>

<?php

/**
 * @param $dict
 * @return string
 */
function generate_table($dict): string
{
    $output = "<table border='2'>";
    foreach ($dict as $key => $val) {
        $output .= "<tr><td>{$key}</td><td>{$val}</td></tr>";
    }
    $output .= "</table>";
    return $output;
}

/**
 * @param string $text
 * @return array
 */
function count_words(string $text): array
{
    $pattern = '/[a-zA-Z]+/';
    preg_match_all($pattern, $text, $words);
    $words = array_map('strtolower', $words[0]);
    $dict = [];
    foreach ($words as $word) {
        if (!key_exists($word, $dict)) {
            $dict[$word] = 0;
        }
        $dict[$word]++;
    }
    return $dict;
}

if (isset($_GET['input'])) {
    $text = $_GET['input'];
    $dict = count_words($text);
    $table = generate_table($dict);
    echo $table;
}
?>