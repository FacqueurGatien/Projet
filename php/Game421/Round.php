<?php
declare(strict_types=1);

/**
 * Game of 421
 * It's a game played with 3 dices and the purpose is throw dice and making 4 2 1 with the dice result
 */
Class Round
{
    private int $try;
    private int $point_of_round;
    /** @var Dice[] */
    private array $diceList;
    private bool $round;

    /**
     * Constructor
     */
    public function __construct()
    {
        $this->try = 1;
        $this->point_of_round = -15;
        $this->diceList = [new Dice(),new Dice(),new Dice()];
        rsort($this->diceList);
        $this->round = true;
    }
    public function start_round() : void
    {
        $this->show_dice();
        while($this->try <= 3)
        {
            $this->show_try();
            if($this->round)
            {
                $number_change_dice=readline('How much dice do you whant change ?');
            }
            else
            {
                $number_change_dice = 0;
            }
            if($number_change_dice==='3')
            {
                $list_change = [0,1,2];
            }
            else
            {
                $list_change =[];
                while($number_change_dice > 0)
                {
                    $nb=intval(readline('what dice do you want to change ?'));
                    $nb--;
                    array_push($list_change,$nb);
                    $number_change_dice--;
                }
            }
            $this->dices_reroll($list_change);
            $this->show_dice();
            $this->check_421();
        }
    }
    public function show_try():void
    {
        echo '___________Try n°: ' . $this->try . '___________' . PHP_EOL;
    }
    public function show_dice() : void
    {
        rsort($this->diceList);
        $n=1;
        foreach($this->diceList as $dice)
        {
            echo 'Dice N°' . $n . ': ' .  $dice->getDice_result() . ' ' . PHP_EOL;
            $n++;
        }
        echo PHP_EOL;
    }
    public function dices_reroll(array $_list_change):void
    {
        if(count($_list_change)>0)
        {
            foreach($_list_change as $nb)
            {
                $this->diceList[$nb]->dice_roll();
            }
        }
    }
    public function check_421() : void
    {
        rsort($this->diceList);
        $temp='';
        foreach($this->diceList as $dice)
        {
            $temp.=$dice->getDice_result();
        }
        if($temp=='421')
        {
            $this->try=4;
            $this->round=false;
            $this->point_of_round = 30;
        }
        else
        {
            $this->try++;
        }
    }
    public function getPoint_of_round() : int
    {
        return $this->point_of_round;
    }
}