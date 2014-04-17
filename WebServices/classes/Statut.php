<?php 
	/**
	* @Entity
	* @Table(name="statut")
	**/
	class Statut{
		/**
		* @Column(name="id", type="integer")
		* @Id
		* @GeneratedValue(strategy="IDENTITY");
		*/
		private $id;
		
		/** @Column(type="string") */
		private $description;

		public function getId() {
			return $this->id;
		}

		public function getDescription() {
			return $this->description;
		}

		public function setDescription($d) {
			$this->description = $d;
		}
	}
	