<?php
namespace Hebergement\controller;

class activitesController
{
    function index()
    {
        require dirname(__DIR__).'/view/activitesView.php';
    }
}