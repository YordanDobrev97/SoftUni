<form>
    <textarea rows="10" name="text"></textarea><br>
    <input type="submit" value="Extract">
</form>

<?php
if (isset($_GET['text'])) {
    $text = $_GET['text'];
    preg_match_all("/\w+/",$text, $words);
    $words = $words[0];

    $result = array_filter($words, function ($word) {
        return is_capital_case($word);
    });

    echo join(', ', $result);
}

function is_capital_case($word)
{
   return strtoupper($word) == $word;
}
?>