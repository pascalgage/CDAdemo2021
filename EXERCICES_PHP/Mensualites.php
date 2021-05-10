<?php
function CalculMensualites(int $K, float $I, int $MOIS){
	
	$mensualite=($K*(1+($I/100)))/$MOIS;
	return round($mensualite,2);
}

echo CalculMensualites(2500,3.5,21);

?>