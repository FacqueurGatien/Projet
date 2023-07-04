<?php
/**
 * Function wich allows to know if the size of string element containt is superior has 9.
 *
 * @param string $strElement
 * @return boolean
 */
function stringLength(string $strElement):bool{
    if(strlen($strElement)>=9){
        return true;
    }
    else{
        return false;
    }
}

/**
 * Function wich allows to check if the password enter by user meets the defiened criteria.
 *
 * @param string $_strElement
 * @return boolean
 */
function passwordCheck(string $_strElement):bool{
    $i=0;
    $size=false;
    $num=false;
    $strlower=false;
    $strupper=false;
    $stralnum=false;
    $info='';
    if(strlen($_strElement)>=9){
        $size=true;
        $info.='s';
    }
    while($i<strlen($_strElement) and ($num==false or $strlower==false or $strupper==false or $stralnum==false)){
        if (ctype_digit($_strElement[$i])){
            $num=true;
            $info.='n';
        }
        elseif(ctype_lower($_strElement[$i])){
            $strlower=true;
            $info.='l';
        }
        elseif(ctype_upper($_strElement[$i])){
            $strupper=true;
            $info.='u';
        }
        elseif(!ctype_alnum($_strElement[$i])){
            $stralnum=true;
            $info.='a';
        }
        $i++;
    }
    if($i<strlen($_strElement) and ($size and $num and $strlower and $strupper and $stralnum)){
        echo 'correct password' . PHP_EOL;
        return true;
    }
    else{
        if(!str_contains($info,'s')){
        echo 'The length\'s password is not correct' . PHP_EOL;
        }
        if(!str_contains($info,'n')){
            echo 'there is not numbers in password' . PHP_EOL;
        }
        if(!str_contains($info,'l')){
            echo 'there is not lowercase in password' . PHP_EOL;
        }
        if(!str_contains($info,'u')){
            echo 'there is not uppercase in password' . PHP_EOL;
        }
        if(!str_contains($info,'a')){
            echo 'there is not alphanumeric character in password' . PHP_EOL;
        }
            return false;
    }
}

$users = [
    'joe' => 'Azer1234!',
    'jack' => 'Azer-4321',
    'admin' => '1234_Azer',
   ];

/**
 * Function wich allows to check if there is a correspondence between the login and the password enter by user.
 *
 * @param string $login
 * @param string $password
 * @param array $_users
 * @return boolean
 */
function userLogin(string $login,string $password,array $_users):bool{
    $result='incorect password';
    if(key_exists($login,$_users)){
        if($_users[$login]==$password){
            echo "Bonjour $login" . PHP_EOL;
            return true;
        } 
        else{
            echo 'incorect password' . PHP_EOL;
            return false;
        }
    }
    else{
        echo 'this user does not exist' . PHP_EOL;
        return false;
    }
}

echo '----test of stringLength----'. PHP_EOL;
stringLength('motDePasse');
stringLength ('azer');
echo '_____________________________' . PHP_EOL;

echo '----test of passwordCheck----'. PHP_EOL;
passwordCheck('6@kosddopStl');
echo '_____________________________' . PHP_EOL;

echo '----test of passwordCheck----'. PHP_EOL;
userLogin('joe','Azer1234!' , $users);
echo '_____________________________' . PHP_EOL;
?>

<?php

$mdp='9A@789efrS';

$patern="/(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[\W])[0-9a-zA-Z\W]{9,}$/i";

function checkPassword(string $_patern,string $_mdp):bool{

    if(preg_match($_patern,$_mdp)){
        return true;
    }
    else{
        return false;
    }
}
echo checkPassword($patern,$mdp);