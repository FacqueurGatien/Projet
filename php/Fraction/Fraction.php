<?php

class Fraction
{
    private int $numerator;
    private int $denominator;

    public function __toString()
    {
        if($this->numerator === $this->denominator)
        {
            return "voici l'entier :\n1" . PHP_EOL;
        }
        elseif($this->numerator!==0 and $this->denominator!==1 and $this->denominator!==0 )
        {
            return  "voici la fraction :\n" . $this->numerator . '\\' . $this->denominator . PHP_EOL;
        }
        elseif($this->numerator!==0)
        {
            return  "voici l'entier :\n" . $this->numerator . PHP_EOL;
        }
        else
        {
            return "resultat null :\n0" . PHP_EOL;
        }
    }
    public function createFraction(int $_numerator=0, int $_denominator=1):void
    {
        $this->setNumerator($_numerator);
        $this->setDenominator($_denominator);
        
    }
    public static function cpoyFraction(Fraction $_fraction):Fraction
    {
        $fractionTemp = new Fraction;
        $fractionTemp->setNumerator($_fraction->getNumerator());
        $fractionTemp->setDenominator($_fraction->getDenominator());
        return $fractionTemp;
    }
    public function oppose():void
    {
        $this->setNumerator(-$this->getNumerator());
    }
    public function inverse():bool
    {
        if($this->numerator!==0 and $this->denominator!==1)
        {
            $value = [$this->numerator,$this->denominator];
            $this->setNumerator($value[1]);
            $this->setDenominator($value[0]);
            return true;
        }
        else
        {
            return false;
        }
    }
    public function superiorTo(Fraction $_fractionCompare):bool
    {
        if(($this->getNumerator() / $this->getDenominator()) > ($_fractionCompare->getNumerator() / $_fractionCompare->getDenominator()))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public function equalTo(Fraction $_fractionCompare):bool
    {
        if(($this->getNumerator() / $this->getDenominator()) === ($_fractionCompare->getNumerator() / $_fractionCompare->getDenominator()))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private function reduce():void
    {
        $Pgcd = $this->getPgcd();
        if($this->getNumerator() < 0 and $this->getDenominator() < 0)
        {
            $this->setNumerator(abs($this->getNumerator() / $Pgcd));
            $this->setDenominator(abs($this->getDenominator() / $Pgcd));
        }
        else
        {
            $this->setNumerator($this->getNumerator() / $Pgcd);
            $this->setDenominator($this->getDenominator() / $Pgcd);
        }
    }
    private function getPgcd():int
    {
        $a = abs($this->getNumerator());
        $b = abs($this->getDenominator());
        $result = 1;
        if($a>$b)
        {
            $aTemp=abs($b);
            $aRef=abs($b);
            $bRef=abs($a);
        }
        else
        {
            $aTemp=abs($a);
            $aRef=abs($a);
            $bRef=abs($b);
        }
        while($aTemp!==$result)
        {
            $aTemp--;
            if($aRef % $aTemp === 0)
            {
                if($bRef % $aTemp === 0 )
                {
                    $result = $aTemp;
                }
            }
        }
        return $result;
    }
    public function add(Fraction $_fraction , Fraction $_fractionAddable) : Fraction
    {
        $_result = new Fraction;
        $numerator1 = $_fraction->getNumerator() * $_fractionAddable->getDenominator();
        $numerator2 = $_fractionAddable->getNumerator() * $_fraction->getDenominator();
        $denominatorCommun = $_fraction->getDenominator() * $_fractionAddable->getDenominator();
        $_result->createFraction(($numerator1 + $numerator2) , $denominatorCommun);
        $_result->reduce();
        echo 'Addition' .PHP_EOL;
        echo $_result.PHP_EOL;
        return $_result;
    }
    public function substract(Fraction $_fraction , Fraction $_subtractable)
    {
        $_result = new Fraction;
        $numerator1 = $_fraction->getNumerator() * $_subtractable->getDenominator();
        $numerator2 = $_subtractable->getNumerator() * $_fraction->getDenominator();
        $denominatorCommun = $_fraction->getDenominator() * $_subtractable->getDenominator();
        $_result->createFraction(($numerator1 - $numerator2) , $denominatorCommun);
        $_result->reduce();
        echo 'Soustraction' .PHP_EOL;
        echo $_result.PHP_EOL;
        return $_result;
    }
    public function multiply(Fraction $_fraction , Fraction $_fractionMultiplyable)
    {
        $_result = new Fraction;
        $numerator = $_fraction->getNumerator() * $_fractionMultiplyable->getNumerator();
        $denominator = $_fraction->getDenominator() * $_fractionMultiplyable->getDenominator();
        $_result->createFraction($numerator , $denominator);
        $_result->reduce();
        echo 'Multiplication' .PHP_EOL;
        echo $_result.PHP_EOL;
        return $_result;
    }
    public function divided(Fraction $_fraction , Fraction $_fractionDividable)
    {
        $_result = new Fraction;
        $numerator = $_fraction->getNumerator() * $_fractionDividable->getDenominator();
        $denominator = $_fraction->getDenominator() * $_fractionDividable->getNumerator();
        $_result->createFraction($numerator , $denominator);
        $_result->reduce();
        echo 'Division' .PHP_EOL;
        echo $_result.PHP_EOL;
        return $_result;
    }
    public function getNumerator():int
    {
        return $this->numerator;
    }
    public function setNumerator(int $_numerator):void
    {
        $this->numerator = $_numerator;
    }
    public function getDenominator():int
    {
        return $this->denominator;
    }
    public function setDenominator(int $_denominator):void
    {
        $this->denominator = $_denominator;
    }
}