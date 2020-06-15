<h1>Hello</h1>

<form method="post">
    Username: <input  type="text" name="username" /> <br>
    Password: <input type="password" name="password"/> <br>
    <input type="submit" value="Register"/>
</form>

<?php
    if (isset($_POST['username']) && isset($_POST['password'])) {
        $username = $_POST['username'];
        $password = $_POST['password'];

        include './create.php';

        register_user($username, $password);
    }
?>