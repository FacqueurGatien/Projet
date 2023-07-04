<?php

$mdp='aaaaaaaa@Aaa1';

$patern="/^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[\W])[0-9a-zA-Z\W]{9,}$/";

function checkPassword(string $_patern,string $_mdp):bool{

    if(preg_match($_patern,$_mdp)){
        return true;
    }
    else{
        return false;
    }
}
echo checkPassword($patern,$mdp);