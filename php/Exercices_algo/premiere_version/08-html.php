<?php
$names = ['Joe', 'Jack', 'Léa', 'Zoé', 'Néo' ];
$names2 = [];

/**
 * Function which allows to insert the array content between HTML tag.
 *
 * @param string $listName
 * @param array $list
 * @return string
 */
function htmlList(string $listName,array $list):string{
    sort($list);
    $result='';
    if(count($list)>0){
        $result.="<h3>$listName</h3>\n<ul>\n";
        foreach($list as $element){
            $result.="\t<li>$element</li>\n";
        }
        $result.='</ul>';
    }
    else{
        $result.="<h3>$listName</h3>\n<p>Aucun résultat</p>";
    }
    return $result;
}

echo htmlList ("Liste des personnes", $names ) . PHP_EOL;
echo PHP_EOL;
echo '-----------------------------------------------' . PHP_EOL;
echo PHP_EOL; 
echo htmlList ("Liste des personnes", $names2 ) . PHP_EOL;
echo PHP_EOL; 