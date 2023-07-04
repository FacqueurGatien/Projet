<?php
declare(strict_types=1);
/**
 * Function wich allows to get the lastname of MC2 equation's author
 *
 * @return string
 */
function getMC2():string{
    $lastName='Einstein';
    return $lastName;
}

/**
 * Function wich allows to return the name and last name of user without space beetween
 *
 * @param string $name
 * @param string $lastName
 * @return string
 */
function getUserName(string $_name ,string $_lastName):string{
    return $_name.$_lastName;
}
/**
 * Function wich allows to return the name and last name with gestion of Case and space beetween.  
 *
 * @param string $name
 * @param string $lastName
 * @return string
 */
function getFullName(string $_name ,string $_lastName):string{
    return mb_convert_case($_name,MB_CASE_TITLE) . ', ' . mb_convert_case($_lastName,MB_CASE_UPPER); 
}

/**
 * Function wich allows to return has user hello followed by his name and last name and a question about MC2 equation?
 *
 * @param string $name
 * @param string $lastName
 * @return string
 */
function askUser(string $_name ,string  $_lastName):string{
    return 'Hello ' . getFullName($_name , $_lastName) . ' do you know ' . getMC2() . ' ?';
}

echo getMC2() . PHP_EOL;
echo getUserName('panda' , 'faon') . PHP_EOL;
echo getFullName('panda' , 'faon') . PHP_EOL;
echo askUser('panda' , 'faon') . PHP_EOL;