<?php
/**
 * Arrays class
 * @author FACQUEUR <facqueur.gatien@gmail.com>
 */
class Arrays
{
    /**
     * firstItem function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     *
     * @param array $tableau (array send in parameter)
     * @return string|null
     * Return the first element in array if not void.
     */
    static function firstItem(array $tableau = []):?string
    {
        return count($tableau) > 0 ? $tableau[0] : null;
    }

    /**
     * lastItem function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     *
     * @param array $tableau (array send in parameter)
     * @return string|null
     * Return the last element in array if not void.
     */
    static function lastItem(array $tableau):?string
    {
        return count($tableau) > 0 ? $tableau[count($tableau)-1] : null;
    }

    /**
     * sortItems function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     *
     * @param array $tableau (array send in parameter)
     * @return array
     * reverse sort $tableau and returns it 
     */
    static function sortItems(array $tableau=[]):array
    {
        rsort($tableau);
        return $tableau;
    }

    /**
     * stringItems function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     *
     * @param array $tableau (array send in parameter)
     * @return string
     * sort $tableau and return a string with $tableau's containt seperate by a space and comma
     */
    static function stringItems(array $tableau):string
    {
        sort($tableau);
        return count($tableau) > 0 ? implode(" , " , $tableau): 'Nothing to display' ;
    }
}
