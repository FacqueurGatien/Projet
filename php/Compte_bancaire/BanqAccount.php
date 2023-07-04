<?php
declare(strict_types=1);
namespace Banque;
use \DateTime;
/**
 *@author Facqueur Gatien <facqueur.gatien@gmail.com>
 *
 */
Class BanqAccount{
    private string $numero;
    private string $nameOfProprietor;
    private float $balance;
    private int $overdraftAllowed;

    function __construct(string $_nameOfProprietor, float $_balance=0, int $_overdraftAllowed=0,string $_num='0')
    {
        if($_num==='0')
        {
            $this->numero=$this->constructNum();
        }
        else
        {
            $this->numero = $_num;
        }
        $this->nameOfProprietor=$_nameOfProprietor;
        $this->balance=$_balance;
        $this->overdraftAllowed=$_overdraftAllowed;
    }

    /**
     * wich allows to creat an unique ID
     *
     * @return string
     */
    function constructNum():string{
        $temp = new DateTime();
        return $temp->format('YmdHisu');
    }

    /**
     * wich allows to show the information of client's account
     *
     * @return void
     */
    function __toString()
    {
        return "Proprietor's Name : \t" . $this->getNameOfProprietor() . PHP_EOL 
        . "Account number : \t" . $this->getNumero() . PHP_EOL 
        . "balance : \t\t" . round($this->getBalance(),2) . PHP_EOL 
        . "Overdraft allowed : \t" . $this->getOverdraftAloowed() . PHP_EOL; 
    }

    /**
     * wich allows to add an sum on the balance client's account
     *
     * @param float $_amount
     * @return void
     */
    function credit(float $_amount){
        $this->setBalance($this->getBalance()+$_amount);
    }

    /**
     * wich allows to substract an sum on the balance client's account
     *
     * @param float $_amount
     * @return void
     */
    function debit(float $_amount):void
    {
        if($this->authorization($_amount)){
            $this->setBalance($this->getBalance()-$_amount);
        }
    }
    /**
     * wich allows to transfert an sum since an account to an other account
     *
     * @param float $_amount
     * @param BanqAccount $_accountCredit
     * @return void
     */
    function transfert(float $_amount, BanqAccount $_accountCredit):bool
    {
        if($_amount>0)
        {
            $this->debit($_amount);
            if($this->authorization($_amount)){
                $_accountCredit->credit($_amount);
            }
            return true;
        }
        else
        {
            return false;
        }
    }

    static function compare(BanqAccount $_accountRef, BanqAccount $_accountToCompare):bool{
        if($_accountRef->getBalance()>$_accountToCompare->getBalance()){
            return true;
        }
        else{
            return false;
        }
    }
    /**
     * wich allows to check if is it possible to substract an sum of the client's account
     *
     * @param float $_amount
     * @return boolean
     */
    function authorization(float $_amount):bool{
        if($this->getBalance()-$_amount>-$this->getOverdraftAloowed()){
            return true;
        }
        else{
            return false;
        }
    }
    /**
     * Getter
     *
     * @return 
     */
    function getNumero():string{
        return $this->numero;
    }
    function getNameOfProprietor():string{
        return $this->nameOfProprietor;
    }
    function getBalance():float{
        return $this->balance;
    }
    function getOverdraftAloowed():int{
        return $this->overdraftAllowed;
    }

    /**
     * Setter
     *
     * @param 
     * @return void
     */
    function setBalance(float $_balance){
        $this->balance=$_balance;
    }
    function setOverdraftAloowed(int $_overdraftAllowed){
        $this->overdraftAllowed=$_overdraftAllowed;
    }
}

