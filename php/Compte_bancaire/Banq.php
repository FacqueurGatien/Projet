<?php
declare(strict_types=1);
namespace Banque;

Class Banq
{
    /**
     * List of account of the bank
     *
     * @var array
     */
    private array $listAccount;
    /**
     * Numbre of account of the bank
     *
     * @var integer
     */
    private int $nbAccount;
    /**
     * Name of the bank
     *
     * @var string
     */
    private string $banqName;
    /**
     * Name of county from the bank
     *
     * @var string
     */
    private string $county;


    /**
     * Constructor of Bnaq class
     *
     * @param string $_banqName
     * @param string $_county
     */
    public function __construct(string $_banqName, string $_county)
    {
        $this->listAccount = [];
        $this->nbAccount = 0;
        $this->banqName = $_banqName;
        $this->county = $_county;
    }
    /**
     * Diplaying function
     *
     * @return string
     */
    public function __toString()
    {
        foreach($this->listAccount as $e)
        {
            echo $e->getNameOfProprietor() . ' : ' . $e->getBalance() . ' : ' . $e->getNumero() . PHP_EOL;
        }
        return PHP_EOL;
    }
    /**
     * Function which allows to creat and add account in account list
     *
     * @param string $_nameOfProprietor
     * @param integer $_balance
     * @param integer $_overdraftAllowed
     * @param integer $_num
     * @return void
     */
    public function addAccount( string $_nameOfProprietor, float $_balance=0, int $_overdraftAllowed=0,string $_num='0'):void
    {
        array_push($this->listAccount, new BanqAccount($_nameOfProprietor,$_balance,$_overdraftAllowed,$_num));
        $this->nbAccount++;
    }
    /**
     * Function which allows to creat and add to the account list from an alraedy existing account
     *
     * @param BanqAccount $_banqAccount
     * @return void
     */
    private function addAccountCopy(BanqAccount $_banqAccount):void
    {
        array_push($this->listAccount, $_banqAccount);
        $this->nbAccount++;
    }
    /**
     * Undocumented function
     *
     * @param integer $_numAccount
     * @return BanqAccount|null
     */
    public function accountReturn(string $_numAccount):?BanqAccount
    {
        $tempAccount = null;
        foreach($this->listAccount as $account)
        {
            if($account->getNumero()===$_numAccount)
            {
                $tempAccount = $account;
            }
        }
        return $tempAccount;
    }
    /**
     * Function which return account whith highest balance
     *
     * @return BanqAccount
     */
    public function topAccount():BanqAccount
    {
        $topAccount = $this->listAccount[0];
        foreach($this->listAccount as $account)
        {
            if($topAccount->getBalance()<$account->getBalance())
            {
                $topAccount = $account;
            }
        }
        return $topAccount; 
    }
    /**
     * Allows to transfert a amount from a account to other account
     *
     * @param string $_numAccountDebit
     * @param string $_numAccountCredit
     * @param float $_amount
     * @return boolean
     */
    public function accountTransfert(string $_numAccountDebit, string $_numAccountCredit, float $_amount):bool
    {
        $accountDebit=$this->accountReturn($_numAccountDebit);
        $accountCredit=$this->accountReturn($_numAccountCredit);
        if($accountDebit!==null and $accountCredit!==null and $accountDebit->authorization($_amount))
        {
            $accountDebit->transfert($_amount,$accountCredit);
            echo 'Transfert Done' . PHP_EOL;
            return true;
        }
        else
        {
            echo 'Transfert impossible' . PHP_EOL;
            return false;
        }
    }
    /**
     * Allows to transfert a amond from a account of a bank to other account  of other bank
     *
     * @param string $_numAccountDebit
     * @param Banq $_anotherBanq
     * @param string $_numAccountCredit
     * @param float $_amount
     * @return boolean
     */
    public function accountTransfertBetweenBanq(string $_numAccountDebit,Banq $_anotherBanq, string $_numAccountCredit, float $_amount):bool
    {
        $accountDebit=$this->accountReturn($_numAccountDebit);
        $accountCredit=$_anotherBanq->accountReturn($_numAccountCredit);
        if($accountDebit!==null and $accountCredit!==null and $accountDebit->authorization($_amount))
        {
            $accountDebit->transfert($_amount,$accountCredit);
            echo 'Transfert Done' . PHP_EOL;
            return true;
        }
        else
        {
            echo 'Transfert impossible' . PHP_EOL;
            return false;
        }
    }
    public function getListAccount():array
    {
        return $this->listAccount;
    }
    public function setListAcount(array $_listAccaount):void
    {
        $this->listAccount = $_listAccaount;
    }
    public function getNbAccount():int
    {
        return $this->nbAccount;
    }
    public function setNbAccount(int $_nbAccount):void
    {
        $this->nbAccount = $_nbAccount;
    }
    public function getBanqName():string
    {
        return $this->banqName;
    }
    public function setBanqName(string $_banqName):void
    {
        $this->banqName = $_banqName;
    }
    public function getCounty():string
    {
        return $this->county;
    }
    public function setCounty(string $_county):void
    {
        $this->county = $_county;
    }
}