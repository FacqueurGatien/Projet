<?php
/**
 * Conditions class
 * @author FACQUEUR <facqueur.gatien@gmail.com>
 */
class Conditions
{
    /**
     * isMajor function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     *
     * @param integer $age (age chosen)
     * @return boolean
     * Return true if age is superior or equal to 18
     */
    static function isMajor(int $age):bool
    {
        return $age >=18 ? true : false; 
    }

    /**
     * getRetired function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     * 
     * @param integer $age (age chosen)
     * @return string
     * Return a certain result in function of age chosen
     * 60+ ... 60 ... 60- ... 0- ...
     */
    static function getRetired(int $age):string
    {
        return $age > 60 ? 'Vous etes à la retraite depuis ' . ($age - 60) . ' années.' : ($age == 60 ? 'Vous etes à la retraite à partir de cet année.' : ($age >= 0 ? 'il vous reste ' . (60 - $age) . ' année(s) avant la retraite.' : 'Vous n\'etes pas encore née.'));
    }

    /**
     * getMAx function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     * 
     * @param float $nombreA (first numbers chosen)
     * @param float $nombreB (second numbers chosen)
     * @param float $nombreC (third numbers chosen)
     * @return float
     * Check if at least two numbers are the same values, 
     * if it is then this function return 0, 
     * else it return the numbers with the greatest value.
     */
    static function getMAx(float $nombreA, float $nombreB, float $nombreC):float
    {
        return (($nombreA == $nombreB) OR ($nombreA == $nombreC) OR ($nombreB == $nombreC)) ? 0 :( ($nombreA > $nombreB AND $nombreA > $nombreC) ? number_format($nombreA) :(($nombreB > $nombreA AND $nombreB > $nombreC) ? number_format($nombreB) : number_format($nombreC)));      
    }

    /**
     * capitalcity function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     * 
     * @param string $pays (country chosen)
     * @return string
     * return the capital city of country chosen... 
     * If neither country matches to the one chosen, show 'Capital inconnue'
     */
    static function capitalcity(string $pays):string
    {
        switch (ucfirst(strtolower($pays)))
        {
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
                return 'Capital inconnue';
        }
    }
}