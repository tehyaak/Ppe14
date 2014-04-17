<?php
// bootstrap.php
require_once "vendor/autoload.php";
	require_once "classes/Admin.php";
	require_once "classes/Competence.php";
	require_once "classes/Etudiant.php";
	require_once "classes/Examinateur.php";
	require_once "classes/Professeur.php";
	require_once "classes/Statut.php";
	require_once "classes/Utilisateur.php";
	require_once "classes/Validation.php";
	session_start();
use Doctrine\ORM\Tools\Setup;
use Doctrine\ORM\EntityManager;


// Préparation de la prise en compte des annotations (directives dans les commentaires)
$isDevMode = true;
$config = Setup::createAnnotationMetadataConfiguration(array(__DIR__."/classes"), $isDevMode);

// Paramètres de connexion
$dbParams = array(
    'driver'   => 'pdo_mysql',
    'user'     => 'root',
    'password' => 'djidane',
    'dbname'   => 'ppe14',
);

$entityManager = EntityManager::create($dbParams, $config);