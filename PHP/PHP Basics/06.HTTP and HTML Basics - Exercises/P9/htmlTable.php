<form>
    Name: <input type="text" name="name"/> <br>
    Phone number: <input type="text" name="phone"/> <br>
    Age: <input type="number" name="age"/> <br>
    Address: <input type="text" name="address"> <br>

    <input type="submit" value="Submit"/>
</form>

<?php
if (isset($_GET['name']) && isset($_GET['phone']) && isset($_GET['age']) && isset($_GET['address'])) {
    $name = htmlspecialchars($_GET['name']);
    $phone_number = htmlspecialchars($_GET['phone']);
    $age  = htmlspecialchars($_GET['age']);
    $address = htmlspecialchars($_GET['address']);

    $table = create_html_table($name, $phone_number, $age, $address);
    echo $table;
}

function create_html_table($name, $phone_number, $age, $address) {
    $table = "<table border='2'>";

    $table .= "<tr><td style='background-color: orange'>Name</td><td>$name</td></tr>";
    $table .= "<tr><td style='background-color: orange'>Phone number</td><td>$phone_number</td></tr>";
    $table .= "<tr><td style='background-color: orange'>Age</td><td>$age</td></tr>";
    $table .= "<tr><td style='background-color: orange'>Address</td><td>$address</td></tr>";
    $table .= "</table>";
    return $table;
}
?>