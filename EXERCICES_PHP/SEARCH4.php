<?php

$Tableau = ["pascal","doris","pascal","sophie","pascal"];

function Search4(array $montab, string $mot)
{
	$compteur=0;
	$position=[];

	for($i=0;$i<count($montab);$i++)
	{
		if ($montab[$i]==$mot)
		{
			$compteur ++;
			array_push($position, $i+1);
		}
	}
	//Fin de la boucle principale de recherche dans le tableau...
	//Début des conditions...

	if ( count($montab) == 0){return "Le tableau est binaire !";}
	if ( $compteur == 0 ){return "L'élément".$mot." n'apparaît pas dans le tableau !";}
	else if ( $compteur == 1 ){return "L'élément".$mot." apparaît une seule fois à la position: ".$position[0];}
	else 
	{
		$res="L'élément ".$mot." apparaît plusieurs fois dans le tableau aux positions :";
		for($j=0; $j<count($position);$j++)
		{
			$res.=$position[$j]." , ";
		}
		$res.="Ceux sont des doublons !";
		return $res;		
	}
}

echo Search4 ($Tableau,"pascal");

?>