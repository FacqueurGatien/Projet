<?php
declare(strict_types=1);

Class Dice
{
    private int $dice_result;
    /**
     * Return the current result dice roll
     *
     * @return array
     */
    public function __construct()
    {
        $this->dice_result=random_int(1,6); 
    }
    public function getDice_result():int
    {
        return $this->dice_result;
    }
    /**
     * Allows the changement the dice roll result if the player will decide dice reroll 
     * @param integer $_diceResult (coressponding at the new dice rool result)
     * @return void
     */
    public function setDice_result(int $_dice_result) : void
    {
        $this->dice_result = $_dice_result;
    }
    /**
     * Allows of generate a random numbers 
     *
     * @return void
     */
    public function dice_roll():void
    {
        $this->setDice_result(random_int(1,6)); 
    }
}