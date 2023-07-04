<?php
/**
 * Function wich allows to get the date of today.
 *
 * @return string
 */
function getToday():string{
    return (new DateTime())->format('d/m/Y');
}

/**
 * Function which allows to get the time left before the date given in parameter by user or specify if that date is already past.
 *
 * @param string $_date
 * @return string
 */
function getTimeLeft( string $_date):string{
    $dateChoose = new DateTime($_date);
    $dateToday=new DateTime();
    $dateToday->setTime(12,0);
    $dateInterval = $dateToday->diff($dateChoose);
    $result='In ';

    $dateInterval->d++;
    if($dateChoose>$dateToday){
        if($dateInterval->format('%y')!=='0'){
            $result .= $dateInterval->format('%y'). ' year(s) ';
        }
        if($dateInterval->format('%m')!=='0'){
            $result .= $dateInterval->format('%m'). ' month(s) ';
        }
        if($dateInterval->format('%d')!=='0'){
            $result .= $dateInterval->format('%d'). ' day(s) ';
        }
    }
    elseif($dateChoose->format('d/m/Y')===$dateToday->format('d/m/Y')){
        $result = 'today';
    }
    else{
        $result = 'past event';
    }
    return $result;
}

echo '-----test of function "getToday"-----' . PHP_EOL;
echo getToday() . PHP_EOL;
echo PHP_EOL;

echo '-----test of function "getTimeLeft"-----' . PHP_EOL;

echo getTimeLeft('2022-06-24 00:00:00').PHP_EOL;
echo getTimeLeft('2022-06-25 00:00:00').PHP_EOL;
echo getTimeLeft('2022-06-24').PHP_EOL;
echo getTimeLeft('2022-06-25').PHP_EOL;
echo getTimeLeft('2022-06-26').PHP_EOL;
echo getTimeLeft('2023-07-30').PHP_EOL;
echo getTimeLeft('2039-08-31').PHP_EOL;

echo PHP_EOL;