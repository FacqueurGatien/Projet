<?php
/**
 * Function wich allows to know if uuser's year old is superior has 18.
 *
 * @param integer $year
 * @return boolean
 */
function isMajor(int $year):bool{
    if($year >= 18){
        return true;
    }
    else{
        return false;
    }
}

/**
 * Function wich allows to know if user is retired.
 *
 * @param integer $year
 * @return string
 */
function getRetired(int $year):string{
    $retired = 60;
    switch ($year) {
        case $year>60:
            return 'You are retired since ' . $year-$retired . ' year !' . PHP_EOL;
            break;
        case $year==60:
            return 'It\'s time to retire !' . PHP_EOL;
            break;
        case $year>=0:
            return 'You have ' . $retired-$year . ' left before retired !' . PHP_EOL;
            break;
        case $year<0:
            return 'You are not born yet !' . PHP_EOL;
            break;
    }
}

/**
 * Function wich allows to return tthe largest number among the three given by user. 
 *
 * @param integer $num1
 * @param integer $num2
 * @param integer $num3
 * @return integer
 */
function getMax(int $num1, int $num2,int $num3):int{

    if($num1==$num2 or $num2==$num3 or $num1==$num3){
        return 0;
    }
    else{
        if($num1>$num2){
            if($num1>$num3){
                return round($num1,3);
            }
            else{
                return round($num3,3);
            }
        }
        else{
            if($num2>$num3){
                return round($num2,3);
            }
            else{
                return round($num3,3);
            }
        }
    }
}

/**
 * Function wich allows to return the Capital city of country given by user.
 *
 * @param string $country
 * @return string
 */
function capitalCity(string $country):string{
    switch ($country) {
        case 'France':
            return 'Paris';
        case 'Allemagne':
            return 'Berlin';
        case 'Italie':
            return 'Rome';
        case 'Maroc':
            return 'Rabat';
        case 'Espagne':
            return 'Madrid';
        case 'Portugal':
            return 'Lisbonne';
        case 'Angleterre':
            return 'Londres';
        default:
            return 'Not country available';
        }
}

echo 'test of function "isMajor" ' . PHP_EOL;
echo isMajor(12) . PHP_EOL;
echo isMajor(18) . PHP_EOL;
echo isMajor(42) . PHP_EOL;
echo PHP_EOL;

echo 'test of function "getRetired" ' . PHP_EOL;
echo getRetired(50);
echo PHP_EOL;

echo 'test of function "getMax" ' . PHP_EOL;
echo getMax(10,15.5555,20.3654) . PHP_EOL;
echo PHP_EOL;

echo 'test of function "capitalCity" ' . PHP_EOL;
echo capitalCity('France') . PHP_EOL;
echo PHP_EOL;