<?php
namespace Hebergement\controller;

class residentsController
{
    function index()
    {
        require dirname(__DIR__).'/view/residentsView.php';
    }
}