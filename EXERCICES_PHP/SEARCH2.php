<?php

$Tableau=["doris","pascal","andre","david","doris"];

function SEARCH2(array $TAB, string $WORD){
	$compteur=0;
	$position=[];

	if(count($TAB)==0){"Le tableau est vide !";}
	for($i=0; $i<count($TAB);$i++)
	{
		if($TAB[$i]==$WORD)
		{
			$compteur++;
			array_push($position, $i+1);
		}
	}
	//fin du FOR recherche principal...
	if($compteur==0){return "Le mot".$WORD."n'apparaît pas dans le tableau !";}
	
	else if($compteur==1)
	{
		return "Le mot ".$WORD." apparaît une fois à la position ".$position[0];
	}
	else
	{
		$resultat="Le mot ".$WORD." apparaît ".$compteur." fois dans le tableau aux positions:";
			for($j=0; $j<count($position); $j++){
				$resultat.=$position[$j]." , ";
			}
			$resultat.=" Ceux sont des doublons !";
			return $resultat;
	}
}
echo SEARCH2($Tableau,"doris")


?>