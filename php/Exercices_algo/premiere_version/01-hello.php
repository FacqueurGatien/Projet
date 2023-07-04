<?php
/**
 * show hello followed by name
 *
 * @param string $name
 * @return string
 */
function hello(string $name=''):string{
    if(mb_strlen(trim($name,' '))>0){
        return "Hello $name";
    }
    else{
        return 'Nobody';
    }
}
echo hello('        ') . PHP_EOL;
echo hello('Pandora') . PHP_EOL;
