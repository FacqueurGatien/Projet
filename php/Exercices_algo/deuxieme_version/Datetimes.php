<?php
/**
 * Datetimes class
 * @author FACQUEUR <facqueur.gatien@gmail.com>
 */
class Datetimes
{
    /**
     * getToday function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     *
     * @return string
     * Return the date of today
     */
    static function getToday():string
    {
        return date("Y-m-d");
    }

    /**
     * getTimeLeft function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     * 
     * @param string $date (date chosen)
     * @return string
     * Return a text in function of interval between a date chosen and the date of today
     * intervale - ...  intervale = ...  interval + ...
     */
    static function getTimeLeft(string $date):string
    {
        $intervale='';
        $today=strtotime(str_replace('-','/',Datetimes::getToday()));
        $date=strtotime(str_replace('-','/',$date));
        $today > $date ? $intervale = 'evenement passé.' : ($today == $date ? $intervale = 'La date correspond à aujourd\'hui.' : ( $intervale = date_diff(new dateTime(date("Y-m-d",$date)),new dateTime(date("Y-m-d",$today)))->format('Il reste %y année(s), %m mois et %d jour(s) avant la date choisit')));
        return $intervale;
    }
}
