<?php
$names = ['Joe', 'Jack', 'Léa', 'Zoé', 'Néo' ];
/**
 * Function wich allows to rturn the first element of array given by user.
 *
 * @param array $myArray
 * @return string
 */
function firstItem(array $myArray):string{
    if($myArray[0]==null){
        return null;
    }
    else{
        return $myArray[0];
    }
}

/**
 * Function wich allows to rturn the last element of array given by user.
 *
 * @param array $myArray
 * @return string
 */
function  lastItem(array $myArray):string{
    if($myArray[count($myArray)-1]==null){
        return null;
    }
    else{
        return $myArray[count($myArray)-1];
    }
}

/**
 * Function wich allows to sort and return the array given by user.
 *
 * @param array $myArray
 * @return string
 */
function sortItems(array $myArray):array{
    rsort($myArray);
    return $myArray;
}

/**
 * Function wich allows to convert and return the content of array in string seperate by virgules.
 *
 * @param array $myArray
 * @return string
 */
function stringItems(array $myArray):string{
    sort($myArray);
    $temp=$myArray[0];
    for($i=1 ; $i<count($myArray) ;$i++){
        
        $temp.=",$myArray[$i]";
    }
    return $temp;
}

echo '______________________________' . PHP_EOL;
echo '-----test of firstItem-----' . PHP_EOL;
echo firstItem($names).PHP_EOL;

echo '______________________________' . PHP_EOL;
echo '-----test of lastItem-----' . PHP_EOL;
echo lastItem($names).PHP_EOL;

echo '______________________________' . PHP_EOL;
echo '-----test of sortItem-----' . PHP_EOL;

$sortName=sortItems($names);

foreach((array)$sortName as $element){
    echo $element . PHP_EOL;
}

echo '______________________________' . PHP_EOL;
echo '-----test of stringItem-----' . PHP_EOL;
echo stringItems($names) . PHP_EOL;
echo PHP_EOL;