<?php
	require_once "Utilisateur.php";
	/**
	* @Entity
	* @Table(name="examinateur")
	**/
	class Examinateur extends Utilisateur{
		/**
		* @Column(name="id", type="integer")
		* @Id
		* @GeneratedValue(strategy="IDENTITY");
		*/
		private $id;

		public function getId() {
			return $this->id;
		}
	}
	