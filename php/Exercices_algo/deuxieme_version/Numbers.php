<?php
/**
 * Numbers class
 * @author FACQUEUR <facqueur.gatien@gmail.com>
 */
class Numbers
{
    /**
     * getSum function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     *
     * @param integer $nombreA (A first numbers with a integer value)
     * @param integer $nombreB (A second numbers with a integer value)
     * @return integer
     * add $nombreA and $nombreB and return the result
     */
    static function getSum(int $nombreA , int $nombreB):int
    {
        return $nombreA + $nombreB;
    }

    /**
     * getSub function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     *
     * @param integer $nombreA (A first numbers with a integer value)
     * @param integer $nombreB (A second numbers with a integer value)
     * @return integer
     * substract $nombreA and $nombreB and return the result
     */
    static function getSub(int $nombreA , int $nombreB):int
    {
        return $nombreA - $nombreB;
    }

    /**
     * getMulti function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     *
     * @param integer $nombreA (A first numbers with a float value)
     * @param integer $nombreB (A second numbers with a float value)
     * @return integer
     * multiply $nombreA and $nombreB and return the result
     */
    static function getMulti(float $nombreA , float $nombreB):float
    {
        return number_format(($nombreA * $nombreB),2);
    }

    /**
     * getDiv function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     *
     * @param integer $nombreA (A first numbers with a float value)
     * @param integer $nombreB (A second numbers with a float value)
     * @return integer
     * Check if $numbeR is 0 and showed 0 if it is. 
     * Else divide $nombreA and $nombreB and return the result.
     */
    static function getDiv(float $nombreA , float $nombreB):float
    {
        return $nombreB == 0? 0 : number_format(($nombreA / $nombreB),2);
    }
}
