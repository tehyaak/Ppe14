<?php

use Doctrine\ORM\Mapping as ORM;

	require_once "Utilisateur.php";
	/**
	* @Entity
	* @Table(name="etudiant")
	**/
	class Etudiant extends Utilisateur{
		/**
		* @Column(name="id", type="integer")
		* @Id
		* @GeneratedValue(strategy="IDENTITY");
		*/
		private $id;
		/** @Column(type="boolean") */
		private $specialite;
		/** @Column(type="string") */
		private $email;

    	/** @ORM\ManyToMany(targetEntity="Validation", cascade={"persist"}) */
    	private $validation;

    	public function setId($i) {
    		$this->id = $i;
    	}

		public function getId() {
			return $this->id;
		}

		public function getSpecialite() {
			return $this->specialite;
		}
 
		public function setSpecialite($s) {
			$this->specialite = $s;
		}

		public function getEmail() {
			return $this->email;
		}

		public function setEmail($e) {
			$this->email = $e;
		}

		public function getValidation() {
			return $this->validation;
		}

		public function __construct() {

		}
	}