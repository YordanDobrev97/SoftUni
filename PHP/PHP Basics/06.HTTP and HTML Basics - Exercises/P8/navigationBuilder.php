<form>
    Categories: <input type="text" name="categories" required/> <br>
    Tags: <input type="text" name="tags" required/> <br>
    Months: <input type="text" name="months" required/> <br>
    <input type="submit" value="Generate"/>
</form>

<?php
    if (isset($_GET['categories']) && isset($_GET['tags']) && isset($_GET['months'])) {
        $categories = explode(', ', $_GET['categories']);
        $tags = explode(', ', $_GET['tags']);
        $months = explode(', ', $_GET['months']);

        generate_html('Categories', $categories);
        generate_html('Tags', $tags);
        generate_html('Months', $months);
    }

    function generate_html($title, $collection) {
        echo "<h2>{$title}</h2>";

        echo "<ul>";
        foreach ($collection as $value) {
            echo "<li>{$value}</li>";
        }
        echo "</ul>";
    }
?>