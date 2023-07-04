<?php
/**
 * Inputs class
 * @author FACQUEUR <facqueur.gatien@gmail.com>
 */
class Inputs
{
    /**
     * stringLength function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     * 
     * @param string $password (password chosen by user)
     * @return boolean
     * Return a boolean result in function of length of $password.
     */
    static function stringLength(string $password):bool
    {
        return strlen($password) >= 9 ? true : false;
    }

    /**
     * passwordCheck function
     *@author FACQUEUR <facqueur.gatien@gmail.com>
     *
     * @param string $password (password chosen by user)
     * @return boolean
     * Return a boolean result after check $password.
     * for true result the password must be comported at least 
     * -9 characters -1 numbers -1 uppercase -1 lowercase -1 special character
     */
    static function passwordCheck(string $password):bool
    {
        $patern="/^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[\W])[0-9a-zA-Z\W]{9,}$/";
        return preg_match($patern,$password) ? true : false ;
    }

    /**
     * userLogin function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     * 
     * @param string $user  (login sended by user)
     * @param string $password (password sended by user)
     * @param array $bdd (array sended by user)
     * @return boolean
     * Return a boolean result if the pair key value $user and $password are present in $bdd
     */
    static function userLogin(string $user , string $password , array $bdd):bool
    {
        return (key_exists($user , $bdd) AND $bdd[$user]==$password)? true : false;
    }
}