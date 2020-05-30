<form>
    <input type="text" name="name"/> <br>
    <input type="text" name="age"/> <br>
    <input type="radio" name="gender" value="male" placeholder="Male"/>Male</br>
    <input type="radio" name="gender" value="female" placeholder="Female"/>Female</br>
    <input type="submit" value="Sumbit"/>
</form>

<?php
    if (isset($_GET['name']) && isset($_GET['age']) && isset($_GET['gender'])) {
        $name = htmlspecialchars($_GET['name']);
        $age = htmlspecialchars($_GET['age']);
        $gender = htmlspecialchars($_GET['gender']);

        echo "My name is $name.I am $age years old.I am $gender.";
    }
?>