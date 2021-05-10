<?php

$TAB=[];

function Recherche(array $tab, string $mot)
{
	$compteur=0;
	$position=[];

	for($i=0;$i<count($tab);$i++)
	{
		if ($tab[$i]==$mot)
		{
			$compteur++;
			array_push($position, $i+1);
		}
	}
	//fin de la boucle principale de recherche...

	if(count($tab)==0){return "Le tableau est vide !";}

	if($compteur==0){return "Le mot ".$mot." n'est pas présent dans le tableau !";}

	else if ($compteur ==1){return "Le mot ".$mot." est présent une seule fois à la position ".$postion[0];}

	else 
	{
		$res="Le mot ".$mot. " est présent ".$compteur." fois dans le tableau aux positions :";
		for ($j=0; $j<count($position); $j++)
		{
			$res.=$position[$j]." , ";
		}
		$res.=" Ceux sont des doublons !";
		return $res;
	}
}
echo Recherche($TAB,"marie");
?>