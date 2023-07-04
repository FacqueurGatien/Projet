<?php
require './Autoloader.php';
Autoloader::register();
/*
red = E63946
red light = F28482
pink = F5CAC3
pink light = F7EDE2
green ligth = 84A59D
blue ligth = A8DADC
orange = F6BD60
*/
?>
<style>
    h1
    {
        font-size: 4vmax;
        color: E63946;
    }    
    h3 
    {
        font-size: 3vmax;
        color: E63946;
    }
    h4
    {
        font-size: 2.5vmax;
        color: E63946;
    }
    li
    {
        font-size: 2vmax;
        color: A8DADC;
    }
    ul
    {
        text-align: left;
        font-size: 1.5vmax;
        margin-left: 5%;
        color: 84A59D;
        
    }
    body
    {
        display: flex;
        flex-wrap: wrap;
        flex-direction: column;
        background-attachment: fixed;
        background-size: cover ;
        background-image: url("https://i.pinimg.com/originals/d8/39/74/d839742a057e1d111d0373fa614de906.jpg");
        color: F1FAEE;
    }
    div{
        border-radius: 20% 5%;
        background: linear-gradient(rgba(230, 57, 70, 0.1), rgba(247, 237, 226, 0.2 ));
        margin:3% 40% 2% 15%;
        border: 1px solid salmon;
    }
    p
    {
        color: 457B9D;
    }
</style>
<body>
        <h1><CENTER>Exercice d'algo en PHP</CENTER></h1>
        <div>
            
            <?php
            ################### EXO 01 HELLO ####################
            echo '<h3><CENTER>EXO 01 Hello</CENTER></h3>' . PHP_EOL;
            echo '<li> 1er resultat:</li><ul>';
                Hello_World::HelloWorld();
            echo '</ul>' . PHP_EOL;
            echo '<li> 2eme resultat:</li><ul>' . Hello_World::Hello('Pandora') . '</ul>' . PHP_EOL;
            echo '<li> 3eme resultat:</li><ul>' . Hello_World::Hello_v1() . '</ul>' . PHP_EOL;
            ###############################################
            ?>

        </div>

        <div>
            <?php
            ################### EXO 02 NUMBERS ####################
            echo '<h3><CENTER>EXO 02 Numbers</CENTER></h3>' . PHP_EOL;
            echo '<li> 1er resultat:</li><ul>' . Numbers::getSum(4,6) . '</ul>' . PHP_EOL;
            echo '<li> 2eme resultat:</li><ul>' . Numbers::getSub(4,6) . '</ul>' . PHP_EOL;
            echo '<li> 3eme resultat:</li><ul>' . Numbers::getMulti(4,6) . '</ul>' . PHP_EOL;
            echo '<li> 4eme resultat:</li><ul>' . Numbers::getDiv(4,0) . '</ul>' . PHP_EOL;
            ###############################################
            ?>
        </div>

        <div>
            <?php
            ################### EXO 03 STRINGS ####################
            echo '<h3><CENTER>EXO 03 Strings</CENTER></h3>' . PHP_EOL;
            echo '<li> 1er resultat:</li><ul>' . Strings::getMC2() . '</ul>' . PHP_EOL;
            echo '<li> 2eme resultat:</li><ul>' . Strings::getUserName('pandora','klein-facqueur') . '</ul>' . PHP_EOL;
            echo '<li> 3eme resultat:</li><ul>' . Strings::getFullName('klein-facqueur','pandora') . '</ul>' . PHP_EOL;
            echo '<li> 4eme resultat:</li><ul>' . Strings::askUser('klein-facqueur','pandora') . '</ul>' . PHP_EOL;

            ###############################################
            ?>
        </div>

        <div>
            <?php
            ################### EXO 04 CONDITIONS ####################
            echo '<h3><CENTER>EXO 04 Conditions</CENTER></h3>' . PHP_EOL;
            echo '<li> 1er resultat:</li><ul>' . Conditions::isMajor(19) . '</ul>' . PHP_EOL;
            echo '<li> 2eme resultat:</li><ul>' . Conditions::getRetired(65) . '</ul>' . PHP_EOL;
            echo '<li> 3eme resultat:</li><ul>' . Conditions::getMAx(3,4,1) . '</ul>' . PHP_EOL;
            echo '<li> 4eme resultat:</li><ul>' . Conditions::capitalcity('Portugal') . '</ul>' . PHP_EOL;

            ###############################################
            ?>
        </div>

        <div>
            <?php
            ################### EXO 05 DATETIMES ####################
            echo '<h3><CENTER>EXO 05 Datetimes</CENTER></h3>' . PHP_EOL;
            echo '<li> 1er resultat:</li><ul>' . Datetimes::getToday() . '</ul>' . PHP_EOL;
            echo '<li> 2eme resultat:</li><ul>' . Datetimes::getTimeLeft("2022-12-31") . '</ul>' . PHP_EOL;

            ###############################################
            ?>
        </div>

        <div>
            <?php
            ################### EXO 06 ARRAYS ####################
            echo '<h3><CENTER>EXO 06 Arrays</CENTER></h3>' . PHP_EOL;
            $names = ['Joe', 'Jack', 'Léa', 'Zoé', 'Néo' ];
            echo '<li> 1er resultat:</li><ul>' . Arrays::firstItem($names) . '</ul>' . PHP_EOL;
            echo '<li> 2eme resultat:</li><ul>' . Arrays::lastitem($names) . '</ul>' . PHP_EOL;
            echo '<li> 3eme resultat:</li><ul>' . implode(" " , Arrays::sortItems($names)) . '</ul>' . PHP_EOL;
            echo '<li> 4eme resultat:</li><ul>' . Arrays::stringItems($names) . '</ul>' . PHP_EOL;

            ###############################################
            ?>
        </div>

        <div>
            <?php
            ################### EXO 07 INPUTS ####################
            echo '<h3><CENTER>EXO 07 Inputs</CENTER></h3>' . PHP_EOL;
            $users = ['joe' => 'Azer1234!', 'jack' => 'Azer-4321', 'admin' => '1234_Azer'];
            echo '<li> 1er resultat:</li><ul>' . Inputs::stringLength('motDePasse') . '</ul>' . PHP_EOL;
            echo '<li> 2eme resultat:</li><ul>' . Inputs::passwordCheck('Tsubasa1234.') . '</ul>' . PHP_EOL;
            echo '<li> 3eme resultat:</li><ul>' . Inputs::userLogin('joe','Azer1234!',$users) . '</ul>' . PHP_EOL;

            ###############################################
            ?>
        </div>

        <div>
            <?php
            ################### EXO 08 HTML ####################
            echo '<h3><CENTER>EXO 08 Html</CENTER></h3>' . PHP_EOL;
            $names = ['Joe', 'Jack', 'Léa', 'Zoé', 'Néo' ];
            echo '<li> 1er resultat:</li><ul>' . Html::htmlList('Liste des personnes',$names) . '</ul>' . PHP_EOL;

            ###############################################
            ?>
        </div>
</body>