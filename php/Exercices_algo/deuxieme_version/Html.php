<?php
/**
 * Html class
 * @author FACQUEUR <facqueur.gatien@gmail.com>
 */
class Html
{
    /**
     * htmlList function
     *
     * @param string $nom_liste (name of the list)
     * @param array $tableau (array contening the list of people)
     * @return string
     * Return the liste of people and the title of the list
     */
    static function htmlList(string $nom_liste , array $tableau):string
    {
        return count($tableau) > 0 ? "<h4>$nom_liste</h4>\n<ul>\n<li>". implode("</li>\n<li>",$tableau) ."</li>\n</ul>" : "<h4>$nom_liste</h4>\n<p>Aucun résultat</p>";
    }
}