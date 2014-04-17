<?php
use Doctrine\ORM\Mapping as ORM;
	require_once "Validation.php";
	/**
	* @Entity
	* @Table(name="utilisateur")
	* @InheritanceType("JOINED")
	**/
	class Utilisateur{
		/**
		* @Column(name="id", type="integer")
		* @Id
		* @GeneratedValue(strategy="IDENTITY");
		*/
		private $id;
		/** @Column(type="string") */
		private $login;
		/** @Column(type="string") */
		private $password;
		/** @Column(type="string") */
		private $nom;
		/** @Column(type="string") */
		private $prenom;

		public function getId() {
			return $this->id;
		}

		public function recupId() {
			return $this->id;
		}

		public function getLogin() {
			return $this->login;
		}

		public function setLogin($l) {
			$this->login = $l;
		}

		public function getPassword() {
			return $this->password;
		}

		public function setPassword($p) {
			$this->password = $p;
		}

		public function getNom() {
			return $this->nom;
		}

		public function setNom($n) {
			$this->nom = $n;
		}

		public function getPrenom() {
			return $this->prenom;
		}

		public function setPrenom($pre) {
			$this->prenom = $pre;
		}

		public function __construct() {
			
		}


	}