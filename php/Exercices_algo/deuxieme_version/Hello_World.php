<?php
/**
 * Hello_World Class
 * @author FACQUEUR <facqueur.gatien@gmail.com>
 */
Class Hello_World
{
    #Introduction 1
    /**
     * HelloWorld function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     * 
     * @return void
     * Show 'Hello World'
     */
    static function HelloWorld():void
    {
        echo 'Hello World' . PHP_EOL;
    }

    #Introduction 2
    /**
     * Hello function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     * 
     * @param string $name (name that will be returned)
     * @return string
     * Show 'Hello...' following by $name
     */
    static function Hello (string $name):string
    {
        return "Hello $name";
    }

    #version 1.A
    /**
     * Undocumented function
     * @author FACQUEUR <facqueur.gatien@gmail.com>
     * 
     * @param string|null $name (name that will be returned (can be null))
     * @return string
     * Show 'Hello...' following by name if not null, else show 'Nobody'
     */
    static function Hello_v1 (?string $name = null):string
    {
        return $name==null? 'Nobody' : "Hello $name" ;
    }
}
