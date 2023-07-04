<?php
namespace Hebergement\controller;

class employesController
{
    function index()
    {
        require dirname(__DIR__).'/view/employesView.php';
    }
}