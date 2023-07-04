<?php

function prix_pc()
{
    $prix=0;
    $nb = readline('combien de photocopie?: ');
    if ($nb <= 10)
    {
        $prix=$nb*0.3;
    }
    else if ($nb <= 30)
    {
        $prix=10*0.3 + ($nb-10)*0.25;
    }
    else
    {
        $prix=10*0.3 + 20*0.25 + ($nb-30)*0.2;
    }
    return $prix;
}

echo prix_pc();