<?php 
/**
 * Class Autoloader
 * add all require needed
 */
class Autoloader{
    /**
     * Used for check if the class needed exist and create a require with the path of the class
     *
     * @param string $class
     * @return void
     * @author Johnny Charvet <charvetjohnny@outlook.fr>
     */
    static function autoload($class){
        $class = str_replace('\\','/',$class); 
        if(is_file(__DIR__ . '/' . $class . '.php')){
            require __DIR__ . '/' . $class . '.php'; 
        }
    }
    /**
     * Used for register to the autoloader
     *
     * @return void
     * @author Johnny Charvet <charvetjohnny@outlook.fr>
     */
    static function register()
    {   
        spl_autoload_register([
            __CLASS__,
            'autoload'
        ]);
    }
}