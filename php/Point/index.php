<?php

require 'point.php';
$point1=new Point(10,5);
$point1->showCoordonne();
$point1->permutSymetricBissectricePoint();
$point1->showCoordonne();

$point2 = $point1->createSymetricAbscisse();
$point3 = $point1->createSymetricOrdonnePoint();
$point4 = $point1->createSymetricOrgiginPoint();

$point2->showCoordonne();
$point3->showCoordonne();
$point4->showCoordonne();