<?php
Class Point{
    private float $abscisse;
    private float $ordonne;

    public function __construct(float $_abscisse = 0 , float $_ordonne = 0.)
    {
        $this->abscisse = $_abscisse;
        $this->ordonne = $_ordonne;
    }

    public function movePoint(float $_abscisse , float $_ordonne):void
    {
        $this->setAbscisse($_abscisse);
        $this->setOrdonne($_ordonne);
    }

    public function showCoordonne():void
    {
        echo 'coordonne du point: (' . $this->getAbscisse() . ',' . $this->getOrdonne() . ')' . PHP_EOL;
    }

    public function createSymetricOrdonnePoint():Point
    {
        return new Point($this->getAbscisse() , -$this->getOrdonne());
    }
    public function createSymetricAbscisse():Point
    {
        return new Point(-$this->getAbscisse() , $this->getOrdonne());
    }
    public function createSymetricOrgiginPoint():Point
    {
        return new Point(-$this->getAbscisse() , -$this->getOrdonne());
    }
    public function permutSymetricBissectricePoint():void
    {
        $newAbscisse=$this->getOrdonne();
        $newOrdonne=$this->getAbscisse();
        $this->setAbscisse($newAbscisse);
        $this->setOrdonne($newOrdonne);
    }

    public function getAbscisse():float
    {
        return $this->abscisse;
    }
    public function setAbscisse(float $_abscisse):void
    {
        $this->abscisse = $_abscisse;
    }

    public function getOrdonne():float
    {
        return $this->ordonne;
    }
    public function setOrdonne(float $_ordonne):void
    {
        $this->ordonne = $_ordonne;
    }
}