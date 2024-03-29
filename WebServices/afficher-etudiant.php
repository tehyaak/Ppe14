<?php
	// on "lance" doctrine
	require_once "bootstrap_doctrine.php";
	
	// on indique que l'on a besoin de certaines classes
	require_once "classes/Admin.php";
	require_once "classes/Competence.php";
	require_once "classes/Etudiant.php";
	require_once "classes/Statut.php";
	require_once "classes/Utilisateur.php";
	require_once "classes/Validation.php";

	$depotEtudiant = $entityManager->getRepository('Etudiant');
	$listeEtudiant = $depotEtudiant->findAll();
	foreach($listeEtudiant as $e) {
		echo "<etudiant><nom>" . $e->getNom() . "</nom>" .
						"<prenom>" . $e->getPrenom() . "</prenom>" .
						"<specialite>" . $e->getOption() . "</specialite>" .
			"</etudiant>";
}