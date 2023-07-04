<?php 
class Autoloader{

    static function autoload($class)
    {
        $class = str_replace('\\','/',$class); 
        if(is_file(__DIR__ . '/' . $class . '.php')){
            require __DIR__ . '/' . $class . '.php'; 
        }
    }

    static function register()
    {   
        spl_autoload_register([
            __CLASS__,
            'autoload'
        ]);
    }
}
