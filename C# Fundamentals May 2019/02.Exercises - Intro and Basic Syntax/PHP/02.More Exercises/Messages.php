<?php
$count = intval(readline());
$result = "";

for ($i = 0; $i < $count; $i++) {
    $message = readline();
    $firstDigit = $message[0];
    $lengthMessage = strlen($message);
    switch ($firstDigit) {
        case '0':
            $result = $result." ";
            break;
        case '2':
            if ($lengthMessage === 1) {
                $result = $result."a";
            } else if ($lengthMessage === 2) {
                $result = $result."b";
            } else if ($lengthMessage === 3) {
                $result = $result."c";
            }
            break;
        case '3':
            if ($lengthMessage === 1) {
                $result = $result."d";
            } else if ($lengthMessage === 2) {
                $result = $result."e";
            } else if ($lengthMessage === 3) {
                $result = $result."f";
            }
            break;
        case '4':
            if ($lengthMessage === 1) {
                $result = $result."g";
            } else if ($lengthMessage === 2) {
                $result = $result."h";
            } else if ($lengthMessage === 3) {
                $result = $result."i";
            }
            break;
        case '5':
            if ($lengthMessage === 1) {
                $result = $result."j";
            } else if ($lengthMessage === 2) {
                $result = $result."k";
            } else if ($lengthMessage === 3) {
                $result = $result."l";
            }
            break;
        case '6':
            if ($lengthMessage === 1) {
                $result = $result."m";
            } else if ($lengthMessage === 2) {
                $result = $result."n";
            } else if ($lengthMessage === 3) {
                $result = $result."o";
            }
            break;
        case '7':
            if ($lengthMessage === 1) {
                $result = $result."p";
            } else if ($lengthMessage === 2) {
                $result = $result."q";
            } else if ($lengthMessage === 3) {
                $result = $result."r";
            } else if ($lengthMessage === 4) {
                $result = $result."s";
            }
            break;
        case '8':
            if ($lengthMessage === 1) {
                $result = $result."t";
            } else if ($lengthMessage === 2) {
                $result = $result."u";
            } else if ($lengthMessage === 3) {
                $result = $result."v";
            }
            break;
        case 9:
            if ($lengthMessage === 1) {
                $result = $result."w";
            } else if ($lengthMessage === 2) {
                $result = $result."x";
            } else if ($lengthMessage === 3) {
                $result = $result."y";
            } else if ($lengthMessage === 4) {
                $result = $result."z";
            }
            break;
    }
}
echo $result;
?>