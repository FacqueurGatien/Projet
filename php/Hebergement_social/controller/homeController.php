<?php
namespace Hebergement\controller;

class homeController
{
    function index()
    {
        require dirname(__DIR__). '/view/homeView.php';
    }
}