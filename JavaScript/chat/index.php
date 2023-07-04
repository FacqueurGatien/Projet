<?php
session_start();
if(!isset($_SESSION['chatCanal']))
{
    $_SESSION['chatCanal']="Public";
}
if(isset($_POST['chat']))
{
    $_SESSION['chatCanal']=$_POST['chat'];
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=H, initial-scale=1.0">
    <link rel="stylesheet" href="src/css/style.css" media="screen">
    <title>Homme</title>
</head>
<body>
    <header>    
        <h1>Accueil</h1>
        <p id="vue">
            
            <?php
            /*
                $fichier = fopen('src/text/vue.txt','r+');
                $vue = fgets($fichier);
                $vue++;

                fseek($fichier,0);
                fputs($fichier,$vue);
                fclose($fichier);
                echo "nombre de vue: " . $vue;
                */
            ?>  
            
            </p>
    </header>

    <main>
        <h2>Accueil</h2>
        <?php
        if(isset($_POST['chat']))
        {
            $chat = $_POST['chat'];
        }
        else
        {
            $chat = 'Public'; 
        }
        $bdd = new PDO("mysql:host=127.0.0.1;dbname=monsite;charset=utf8","root", "");
        if(isset($_POST['pseudo']) AND isset($_SESSION['chatCanal']) AND isset($_POST['chatBox']))
        {
            $chatId=$bdd->prepare("SELECT chatId FROM CHAT WHERE chatCanal=?");
            $pseudoId=$bdd->prepare("SELECT userId FROM UTILISATEUR WHERE userPseudo=?;");
            $chatId->execute(array($_SESSION['chatCanal']));
            $pseudoId->execute(array($_POST['pseudo']));    

            $chatId = $chatId->fetch()['chatId'];
            $pseudoId = $pseudoId->fetch()['userId'];
            $contenue = $_POST['chatBox'];

            $datetime = new DateTime();
            $datetime = $datetime->format('Y-m-d H:i:s');

            $insert = $bdd->prepare("INSERT INTO MESSAGE(messageContenue,messageDate,chatId,userId)VALUES(?,?,?,?);");
            $insert->execute(array($contenue,$datetime,$chatId,$pseudoId));
            ?>
            <meta http-equiv="refresh" content="0; URL=test.php" />
            <?php
        }
        $canal='Prive';
        $requete = $bdd->prepare("SELECT  userPseudo , messageContenue
            FROM MESSAGE
            NATURAL JOIN UTILISATEUR 
            NATURAL JOIN CHAT 
            WHERE chatCanal= ?
            GROUP BY messageId 
            ORDER BY messageDate DESC
            LIMIT 15;");
        $requete->execute(array($_SESSION['chatCanal']));

        $requete2 = $bdd->query("SELECT * FROM CHAT");
        $resultat2 = $requete2->fetch();
        ?>
            <table>
            <thead>
            <label>Chat <?php echo$_SESSION['chatCanal']; ?></label>    

            </thead>
                <tr>
                    <th>Pseudo</td>
                    <th>Message</td>
                </tr>
                <tbody>
                    <?php
                    while($resultat = $requete->fetch())
                    {
                    ?>
                    <?php
                        echo "<tr>";
                            echo "<td>";
                                echo $resultat['userPseudo'];
                            echo "</td>";
                            echo "<td>";
                                echo $resultat['messageContenue'];
                            echo "</td>";
                        echo "</tr>";
                    }
                    ?>
                </tbody>
            </table>
        <!-- 
            <div class="var">
            <?php
                if(isset($_POST['pseudo']))
                {
                    echo "Bonjour " . $_POST['pseudo']; 
                }
                echo "</br>";
                if(isset($_POST['age']))
                {
                    echo "Vous avez " . $_POST['age'] . " ans"; 
                }
            ?>
            </div>

            <p id="narutoWiki">
            <?php
                $fichier = fopen('src/text/test.txt','r+');
                $ligne="";
                while($ligne!="this is the end!!!")
                {
                    $ligne = fgets($fichier);
                    if($ligne!="this is the end!!!")
                    {
                        echo $ligne;
                        echo "<br />";
                    }
                }
                fclose($fichier);
            ?>  
            </p> 
        -->
    </main>
    <aside>
        <form method="POST" action="">
            <div id="buttonAside">
                <input type="text" name="pseudo" placeholder="Pseudo" required="required"/>
                <textarea name="chatBox" placeholder="ecrivez un message" required="required"></textarea>
                <input type="submit" value="Valider"/>
            </div>
        </form>
        <form method="POST" action="">
            <select name="chat" onchange="this.form.submit()">
                <option>Choisir un chat</option>
                <option value="Public">Public</option>
                <option value="Prive">Prive</option>
                <option value="Amis">Amis</option>
                <option value="VIP">VIP</option>
            </select>
        </form>
    </aside>
    <footer>
        <p>copyrigth : Lorem ipsum dolor sit amet consectetur adipisicing elit. </p>
    </footer>
</body>
</html>