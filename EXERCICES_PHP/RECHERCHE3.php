<?php 

$tableau=["pascal","pierre","julien","pascal"];

function RECH(array $tab, string $mot)
{
	$compteur = 0;
	$position = [];
	$mot=strtolower($mot);

	for ( $i=0 ; $i< count($tab) ;$i++ )
	{
		if( $tab[$i] == $mot )
		{
			$compteur++;
			array_push($position, $i+1);
		}
	}
	//Fin boucle principale de recherche !
	if(count($tab) == 0)
	{
		return "Le tableau est vide !";
	}

	if($compteur == 0)
	{
		return "Le mot".$mot."n'apparaît pas dans le tableau !";
	}
	else if ($compteur == 1)
	{
		return "Le mot".$mot."apparaît".$compteur." fois dans le tableau à la position ".$position[0];
	}
	else
	{
		$res="Le mot".$mot." apparaît ".$compteur." fois dans le tableau aux positions :";
		for($j=0; $j<count($position); $j++)
		{
			$res.=$position[$j]." , ";
		}
		$res.= "Ceux sont des doublons !";
		return $res;
	}

}
echo RECH($tableau, "PIERRE");
?>