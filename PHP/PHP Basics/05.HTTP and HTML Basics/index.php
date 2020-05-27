<form method="get">
    <select name="operator">
        <option>Sum</option>
        <option>Subtract</option>
    </select>
    <br>
    Number 1:
    <label>
        <input type="number" name="first"/>
    </label> <br>
    Number 2:
    <label>
        <input type="number" name="second"/>
    </label> <br>
    <input type="submit" name="calculate" value="Calculate">
</form>

<?php
if (isset($_GET['calculate'])) {
    $user_operator = $_GET['operator'];
    $first_value = intval($_GET['first']);
    $second_value = intval($_GET['second']);

    $result = '';
    $operator = '';

    if ($user_operator == 'Sum') {
        $result = $first_value + $second_value;
        $operator = '+';
    } else {
        $result = $first_value - $second_value;
        $operator = '-';
    }

    echo "$first_value $operator $second_value = $result";
}
?>