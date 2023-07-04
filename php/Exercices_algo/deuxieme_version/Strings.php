<?php
/**
 * Strings class
 * @author FACQUEUR <facqueur.gatien@gmail.com>
 */
class Strings
{
    /**
     * getMC2 function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     * 
     * @return string
     * Return the name of the inventor of formula E=MC²
     */
    static function getMC2():string
    {
        return 'Einstein';
    }
    
    /**
     * getUserName function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     * 
     * @param string $firstname (firstname of user)
     * @param string $lastname (lastname of user)
     * @return string
     * Return the concatenate of $firstname and $lastname without shaping
     */
    static function getUserName(string $firstname , string $lastname):string
    {
        return $firstname . $lastname;
    }

    /**
     * getFullName function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     *
     * @param string $firstname (firstname of user)
     * @param string $lastname (lastname of user)
     * @return string
     * Return the concatenate of $firstname and $lastname with shaping.
     * $firstname in lowercase and $lastname in uppercase.
     */
    static function getFullName(string $lastname , string $firstname):string
    {
        return strtolower($firstname) . ' ' . strtoupper($lastname);
    }

    /**
     * Undocumented function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     *
     * @param string $firstname (firstname of user)
     * @param string $lastname (lastname of user)
     * @return string
     * Return hello before the result of the function getFullName 
     * ---(Return the concatenate of $firstname and $lastname with shaping. $firstname in lowercase and $lastname in uppercase.)---.
     * Then ask at user if his know Einstein wich is the result of the function getMC2 
     * ---(Return the name of the inventor of formula E=MC².)---.
     */
    static function askUser(string $lastname , string $firstname):string
    {
        return 'Bonjour ' . Strings::getFullName($lastname , $firstname) . ' Connaissez-vous ' . Strings::getMC2() . ' ?';
    }
}
