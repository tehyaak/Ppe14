<?php


namespace Repositories;

 
use Doctrine\ORM\EntityRepository;
use Entities;


class UtilisateurRepository extends EntityRepository {
	public function findByValidateSkillsByUser($u) {
		$q = $this
		   ->createQueryBuilder('c')
		   ->select('c')
		   ->where('c.etudiant = :etudiant')
		   ->setParameter('etudiant', $u)
		   ->getQuery()
		   ->getResult();
	}
}