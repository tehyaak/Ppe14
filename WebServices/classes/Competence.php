<?php
require_once 'Statut.php';
	/**
	* @Entity
	* @Table(name="competence")
	**/
	class Competence{
		/**
		* @Column(name="id", type="integer")
		* @Id
		* @GeneratedValue(strategy="IDENTITY");
		*/
		private $id;
		
		/** @Column(type="string") */
		private $description;
		
		/** @Column(type="integer") */
		 private $parcours;

		/** @Column(type="boolean") */
		private $obligatoire;

    	/** @ORM\OneToOne(targetEntity="Statut", cascade={"persist"}) */
    	private $statut;

        /** @ManyToMany(targetEntity="Validation", mappedBy="competence") */
        private $validation;
        
		public function getId() {
			return $this->id;
		}

		public function getDescription() {
			return $this->description;
		}

		public function setDescription($d) {
			$this->description = $d;
		}

		public function getParcours() {
			return $this->parcours;
		}

		public function setParcours($p) {
			$this->parcours = $p;
		}

		public function getObligatoire() {
			return $this->obligatoire;
		}

		public function setObligatoire($ob) {
			$this->obligatoire = $ob;
		}
	}
	