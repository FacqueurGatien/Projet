<?php
require 'Fraction.php';

$f1 = new Fraction;
$f1->createFraction();
$f2 = new Fraction;
$f2->createFraction(9);
$f3 = new Fraction;
$f3->createFraction(10,6);
$f4 = new Fraction;
$f4->createFraction(6,8);
$f5 = Fraction::cpoyFraction($f3);
//echo 'Avant'.PHP_EOL;
//echo "---> f1\n" . $f1 . PHP_EOL;
//echo "---> f2\n" . $f2 . PHP_EOL;
//echo "---> f3\n" . $f3 . PHP_EOL;
//echo "---> f4\n" . $f4 . PHP_EOL;
//$f4->oppose();
//$f4->inverse();
//echo 'Apres'.PHP_EOL;
//echo "---> f3\n" . $f3 . PHP_EOL;
//echo "---> f4\n" . $f4 . PHP_EOL;
//echo $f3->superiorTo($f4) . PHP_EOL;
//$f5 = Fraction::cpoyFraction($f3);
//echo $f3->equalTo($f5) . PHP_EOL;
echo $f3 . PHP_EOL;
echo $f4 . PHP_EOL;

$fadd = new Fraction;
$fadd->add($f3 , $f4);
$fsub = new Fraction;
$fsub->substract($f3 , $f4);
$fmul = new Fraction;
$fmul->multiply($f3 , $f4);
$fdiv = new Fraction;
$fdiv->divided($f3 , $f4);
