<?php
	require_once "Utilisateur.php";
	/**
	* @Entity
	* @Table(name="professeur")
	**/
	class Professeur extends Utilisateur{
		/**
		* @Column(name="id", type="integer")
		* @Id
		* @GeneratedValue(strategy="IDENTITY");
		*/
		private $id;

    	/** @ORM\OneToOne(targetEntity="Validation", nullable="true", cascade={"persist"}) */
    	private $validation;
    	
		public function getId() {
			return $this->id;
		}
	}