<?php

require 'Dice.php';
require 'Party.php';
require 'Round.php';

$number_of_round=10;

$test = new Party(readline('How much of round want you playing?: '),readline('What is your pseudo?: '));
$test->start_party();
