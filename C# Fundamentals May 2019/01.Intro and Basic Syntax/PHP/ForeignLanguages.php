<?php
$country = readline();

switch ($country) {
    case "USA":
    case "England":
        echo "English";
        break;
    case "Spain":
    case "Argentina":
    case "Mexico":
        echo "Spanish";
        break;
    default:
        echo "unknown";
        break;
}
?>
