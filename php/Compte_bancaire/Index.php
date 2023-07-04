<?php
declare(strict_types=1);
namespace Banque;
require 'BanqAccount.php';
require 'Banq.php';
/*
$accountClient=new BanqAccount('Thierry',800.0,500);
echo'----1er compte du client----'.PHP_EOL;
$accountClient->showInformation();
echo'_________________________'.PHP_EOL;
$accountClient->credit(800);
$accountClient->debit(500);
$accountClient2=new BanqAccount('Thierry C2');
$accountClient2->credit(1600);

echo'________________Avant transfert______________'.PHP_EOL;
echo'----1er compte du client----'.PHP_EOL;
$accountClient->showInformation();
echo'______________________________' . PHP_EOL;
echo'----2eme compte du client----'.PHP_EOL;
$accountClient2->showInformation();

$accountClient2->transfert(800,$accountClient);

echo'________________Apres transfert______________'.PHP_EOL;
echo'----1er compte du client----'.PHP_EOL;
$accountClient->showInformation();
echo'______________________________' . PHP_EOL;
echo'----2eme compte du client----'.PHP_EOL;
$accountClient2->showInformation();

echo BanqAccount::compare($accountClient,$accountClient2);*/

$banq1=new Banq('creditN','Mecity','98765');
$banq1->addAccount('Dylan',500,500,'5613614');
$banq1->addAccount('Jaccob',600,500,'444125');
$banq1->addAccount('Ryan',400,500,'145258');
$banq1->addAccount('Nick',1000,500,'645165');

$banq2 = new Banq('CreditT','LoCity');
$banq2->addAccount('Abigail',600,500,'464251');
$banq2->addAccount('Emma',600,500,'98751');
$banq2->addAccount('Laura',900,500,'654687');
$banq2->addAccount('kaytlin',100,500,'196865');

echo $banq1;
$banq1->accountTransfert('5613614','145258',544);
echo $banq1;
/*
echo PHP_EOL;
echo $banq1;
echo $banq2;

echo 'The most highest account from the ' . $banq1->getBanqName().PHP_EOL;
echo $banq1->topAccount(). PHP_EOL;
echo 'The most highest account from the ' . $banq2->getBanqName().PHP_EOL;
echo $banq2->topAccount(). PHP_EOL;

$banq1->accountTransfert('645165','5613614',200);
$banq1->accountTransfertBetweenBanq('645165',$banq2,'654687',100);
echo PHP_EOL;

echo $banq1. PHP_EOL;
echo $banq2.PHP_EOL;
*/