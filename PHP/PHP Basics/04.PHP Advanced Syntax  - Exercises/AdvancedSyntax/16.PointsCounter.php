<?php
$dict = [];

while (true) {
    $line = readline();
    if ($line == 'Result') {
        break;
    }

    $parts = explode('|', $line);
    $type = $parts[0];
    $type = removeProhibitedSymbols($type);

    if (ctype_upper($type)) {
        $team = $type;
        $player = removeProhibitedSymbols($parts[1]);
        $score = intval($parts[2]);
    } else {
        $player = $type;
        $team = removeProhibitedSymbols($parts[1]);
        $score = intval($parts[2]);
    }

    if (!key_exists($team, $dict)) {
        $dict[$team] = [];
    }
    if (!key_exists($player, $dict[$team])) {
        $dict[$team][$player] = 0;
    }
    $dict[$team][$player] = $score;
}

$temp = [];
foreach ($dict as $key => $value) {
    $total = 0;
    foreach ($dict[$key] as $item) {
        $total += $item;
    }
    $temp[$key] = $total;
}

arsort($temp);

foreach ($temp as $result => $key) {
    echo $result. ' => ' . $key.PHP_EOL;
    $max = 0;
    $player = '';
    foreach ($dict[$result] as $item => $value) {
        if ($value > $max) {
            $max = $value;
            $player  = $item;
        }
    }
    echo "Most points scored by $player".PHP_EOL;
}

function removeProhibitedSymbols($argument) {
    $pattern = '/[@%&$*]/';
    return preg_replace($pattern, '', $argument);
}
?>