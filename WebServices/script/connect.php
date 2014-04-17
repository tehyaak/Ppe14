<?php
    // on "lance" doctrine
    require_once "../bootstrap_doctrine.php";
    
    // on indique que l'on a besoin de certaines classes
    require_once "../classes/Admin.php";
    require_once "../classes/Competence.php";
    require_once "../classes/Etudiant.php";
    require_once "../classes/Examinateur.php";
    require_once "../classes/Professeur.php";
    require_once "../classes/Statut.php";
    require_once "../classes/Utilisateur.php";
    require_once "../classes/Validation.php";
    
// Connection au serveur
    $use = $entityManager->getRepository('Utilisateur');
    $user= $use->findOneBy(array('login' => $_POST['user_login']));
    $pass= $use->findOneBy(array('password' => $_POST['user_pwd']));

    if ($user != null)
    {
        if ($pass != null)
        {
            $_SESSION['user'] = $user;
            header("location:../admin.php");
            die();
        }
        else
        {
            echo "Le mot de passe saisie n'est pas correct.";
        }
    }
    else
    {
        echo "Login invalide.";
    }
?>