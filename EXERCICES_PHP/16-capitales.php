<?php
function Capitale(string $pays){
	switch($pays){
		case "France": echo'Paris'; break;
		case "Angleterre": echo'Londres'; break;
		case "Allemagne": echo'Berlin';break;
		case ($pays!="case"):echo'inconnu';break;
	}
}
Capitale("France");
//Capitale("France");
?>