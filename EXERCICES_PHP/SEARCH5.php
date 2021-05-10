<?php

$tableau=["pierre","doris","pascal"];

function RECH_TAB(array $Tab, string $mot)
{
	$compteur=0;
	$position=[];

	for($i=0; $i<count($Tab); $i++)
	{
		if($Tab[$i]==$mot)
		{
			$compteur++;
			array_push($position, $i+1);
		}
	}
	//FIN du FOR de RECHERCHE dans tableau...
	if(count($Tab)==0){return "Le tableau est vide !";}
	if($compteur==0){return "Lélément ".$mot."n'existe pas dans le tableau !";}
	else if ($compteur==1){return "Lélément ".$mot." est présent une seule fois dans le tableau à la position ".$position[0];}
	else 
	{
		$answ="L'élément ".$mot." est présent ".$compteur." fois dans le tableau aux positions suivantes :";
		for($j=0; $j<count($position);$j++)
		{
			$answ.=$position[$j]. " ,";
		}
		$answ.= "Il s'agit de doublons !!!";
		return $answ;
	}

}
echo RECH_TAB($tableau,"pierre");


?>