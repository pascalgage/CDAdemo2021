<?php
// Selon: https://www.maths-cours.fr/methode/algorithme-euclide/
// L'algorithme d'Euclide permet de calculer le PGCD de deux entiers naturels non nuls a et b.

function calculDuPgcd($a, $b){
	
	$continuer = true; // Variable permettant de sortir de la boucle si false.
	
	$pgcd = min($a, $b); // Si a et b sont divisibles ou égaux, on retourne le PGCD qui est le plus petit des deux nombres.
	
	while($continuer){
		
		$r = $a % $b; // On effectue la division euclidienne de a par b. On note r le reste (on n'utilise pas le quotient).
		
		if($r != 0){ // si le reste n'est pas nul,
			$a = $b; // on remplace a par b,
			$b = $r; // puis b par r.
			$pgcd = $r; // Le PGCD de a et de b est le dernier reste non nul. On enregistre ce reste comme PGCD potentiel.
		} // Et on continue tant que le reste n'est pas nul.
		
		else{// Si le reste est nul, on a trouvé le PGCD.
			$continuer = false; // On arrête donc la boucle
		}
		
	}
	return($pgcd);
}

echo calculDuPgcd(1974,2021);

?>