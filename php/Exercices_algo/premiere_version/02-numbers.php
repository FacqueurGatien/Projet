<?php
/**
 * Function which allows of add two numbers.
 *
 * @param integer $numbers1
 * @param integer $numbers2
 * @return integer
 */
function getSum(int $numbers1 , int $numbers2):int{
    return $numbers1 + $numbers2;
}
echo getSum(5,3) . PHP_EOL;

/**
 * Function which allows of substract two numbers.
 *
 * @param integer $numbers1
 * @param integer $numbers2
 * @return integer
 */
function getSub(int $numbers1 , int $numbers2):int{
    return $numbers1 - $numbers2;
}
echo getSub(5,3) . PHP_EOL;

/**
 * Function which allows of product two numbers.
 *
 * @param float $numbers1
 * @param float $numbers2
 * @return float
 */
function getMulti(float $numbers1 , float $numbers2):float{
    return $numbers1 * $numbers2;
}
echo getMulti(5,3) . PHP_EOL;

/**
 * Function wich allows of divided two numbers.
 *
 * @param integer $numbers1
 * @param integer $numbers2
 * @return integer
 */
function getDiv(int $numbers1 , int $numbers2):int{
    if($numbers2!=0){
        return $numbers1 * $numbers2;
    }
    else{
        return 0;
    }
}
echo getDiv(5,0) . PHP_EOL;