<?php

$TAB=["pierre", "paul", "jacques", "pierre", "pierre"];

function SEARCH3(array $Tab, string $Word)
{
	
	$compt=0;
	$posit=[];

	//Recherche initiale/ opérations en cours...
	for($i=0;$i<count($Tab);$i++)
	{
		if($Tab[$i]==$Word)
		{
			$compt++;
			array_push($posit, $i+1);
		}
	}
	//Fin recherche initiale...

	// 4 conditions : Tableau vide; élément pas trouvé; élément apparaît 1 fois; élément apparaît plusieurs fois...
	if(count($Tab)==0){return "Le tableau est vide !";}
	if($compt==0){return "L'élément recherché n'est pas présent dans le tableau !";}
	else if ($compt==1){return "L'élément ".$Word." apparaît une fois dans le tableau à la position ".$posit[0];}
	else
	{
		$resultat="L'élément apparaît ".$compt." fois dans le tableau aux positions:";
		for($j=0; $j<count($posit); $j++)
		{
			$resultat.=$posit[$j]." , ";
		}
		$resultat.=" Il s'agit de doublons !";

		return $resultat;
	}
	
}
echo SEARCH3($TAB, "pierre");
?>