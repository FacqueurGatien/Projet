<?php
declare(strict_types=1);

Class Party
{
    /** @var string $player (Name of player) */
    private string $player;
    /** @var int $number_of_round (Numbers of round in a party) */
    private int $number_of_round;
    private int $round_duration;

    private int $point;

    /**
     * Constructor
     *
     * @param integer $_number_of_round
     * @param string $_player (Name of player. Player 1 is the default choice )
     */
    public function __construct(int $_number_of_round , string $_player='Player 1')
    {
        $this->player = $_player;
        $this->number_of_round = $_number_of_round;
        $this->point = $_number_of_round*10;
        $this->round_duration = 1;
    }
    public function start_party() : void
    {
        $this->check_party_end();
        while($this->number_of_round>0 and $this->point>0)
        {
            $this->show_round();
            $round = new Round();
            $round->start_round();
            $this->point += $round->getPoint_of_round();
            $this->number_of_round--;
            $this->show_score();
            $this->check_party_end();
            readline(PHP_EOL);
        }
    }
    public function show_score() : string
    {
        return 'Your score: ' . $this->point . PHP_EOL;
    }
    public function show_round():void
    {
        echo "----------------------Round $this->round_duration----------------------\n";
        $this->round_duration++;
    }
    public function check_party_end():void
    {
        if($this->number_of_round<=0 and $this->point>0)
        {
            echo "You win!\nYour score: $this->point";
        }
        else if($this->point<=0)
        {
            echo "You lose!\n" . $this->show_score();
        }
        else
        {
            echo  $this->player . "\n" . $this->show_score();
        }
    }
}