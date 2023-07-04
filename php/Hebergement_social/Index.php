<?php require (__DIR__).'/vendor/autoload.php';
 require 'header.php';

            $page = $_GET['page'] ?? 'home'; // null coalescing operator
            switch($page)
            {
                case 'home':
                    $controller = new Hebergement\controller\homeController();
                    $controller->index();
                    break;
                case 'employes':
                    $controller = new Hebergement\controller\employesController();
                    $controller->index();
                    break;
                case 'intervenants':
                    $controller = new Hebergement\controller\intervenantsController();
                    $controller->index();
                    break;
                case 'residents':
                    $controller = new Hebergement\controller\residentsController();
                    $controller->index();
                    break;
                case 'activites':
                    $controller = new Hebergement\controller\activitesController();
                    $controller->index();
                    break;
                default:
                    echo 'Erreur 404';
                    break;
            }

require 'footer.php';
