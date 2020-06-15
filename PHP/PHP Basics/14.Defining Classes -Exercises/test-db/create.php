<?php
function register_user($username, $password) {
    $query = "INSERT INTO users 
              (username, password) 
              VALUES (:username, :password)";

    $db = new PDO('mysql:host=localhost;dbname=demo', 'root', '');

    $statement = $db->prepare($query);
    $statement->bindParam(':username', $username);
    $statement->bindParam(':password', $password);

    $result = $statement->execute();
    if ($result) {
        echo "Successfully registered";
    } else {
        echo "No, have problem! Sorry";
    }
}
?>