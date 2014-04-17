<?php
	require_once "../bootstrap_doctrine.php";
	$test = new Etudiant;
	$test->setNom($_POST['nom']);
	$test->setPrenom($_POST['prenom']);
	$test->setEmail($_POST['email']);
	$test->setLogin($_POST['username']);
	$test->setPassword($_POST['password']);
	$test->setSpecialite(1);
	$etu = $entityManager->getRepository('Utilisateur');
	$etudiant= $etu->findOneBy(array('login' => $test->getLogin()));
	if ($etudiant == null) {
		$entityManager->persist($test);
		$entityManager->flush();
		echo "Succes de l'insertion";
		$_SESSION['flash'] = "Succes de l'insertion";
	}
	else {
		echo "Echec de l'insertion";
		$_SESSION['flash'] = "Echec de l'insertion";
	}


?>