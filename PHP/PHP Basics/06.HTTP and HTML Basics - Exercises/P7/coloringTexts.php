<form>
    <textarea rows="5" cols="50" name="input"></textarea><br>
    <input type="submit" value="Color text"/>
</form>

<?php
    if (isset($_GET['input'])) {
        $text = $_GET['input'];
        $parts = explode(' ', $text);

        foreach ($parts as $word) {
            for ($i = 0; $i < strlen($word); $i++) {
                $value = ord($word[$i]);

                if ($value % 2 == 1) {
                    echo "<span style='color: blue'>$word[$i] </span>";
                } else {
                    echo "<span style='color: red'>$word[$i] </span>";
                }
            }
        }
    }
?>