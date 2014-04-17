<?php
	require_once "Competence.php";
	require_once "Statut.php";
	/**
	* @Entity(repositoryClass="ValidationRepository")
	* @Entity
	* @Table(name="validation")
	**/
	class Validation{
		/**
		* @Column(name="id", type="integer")
		* @Id
		* @GeneratedValue(strategy="IDENTITY");
		*/
		private $id;
		
		/** @Column(type="datetime") */
		private $date;
		
		/** @Column(type="string") */
		 private $commentaire;

		/** @Column(type="string") */
		private $lien;

        /** @ManyToMany(targetEntity="Competence", inversedBy="competence")
        * @JoinTable(name="valid_comp")
        */
    	private $competence;

    	/** @ORM\OneToOne(targetEntity="Statut", cascade={"persist"}) */
    	private $statut;

	    /** 
	    *@ManyToOne(targetEntity="Etudiant", inversedBy="validation")
	    * @JoinColumn(name="etudiant_id", referencedColumnName="id")
	    */
    	private $etudiant;

		public function getId() {
			return $this->id;
		}

		public function getDate() {
			return $this->date;
		}

		public function setDate($d) {
			$this->date = $d;
		}

		public function getCommentaire() {
			return $this->commentaire;
		}

		public function setCommentaire($c) {
			$this->commentaire = $c;
		}

		public function getLien() {
			return $this->lien;
		}

		public function setLien($l) {
			$this->lien = $l;
		}

		public function getCompetence() {
			return $this->competence;
		}
	}
	