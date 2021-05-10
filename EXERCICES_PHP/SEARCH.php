<?php
$TableauN=["pascal","pascal","pascal","david","doris"];
function SEARCHING(array $TAB, string $MOT){

	$compteur=0;
	$position=[];
	$MOT=$MOT;

	if (count($TAB)==0){return"Le tableau est vide !";}
	for($i=0; $i <count($TAB); $i++)
	{

		if($TAB[$i]==$MOT)
			{
			$compteur++;
			array_push($position, $i+1);
			}


	}//fin du FOR important //primaire de recherche

		if($compteur==0){return "Mot inexistant dans le tableau:";}
		else if($compteur==1){return "Mot trouvé dans le tableau à la position ".($position[0]);}
		else
		{
			$resultat="Mot trouvé plusieurs fois soit ".$compteur." fois aux positions: ";
				for($j=0;$j<count($position);$j++)
				{
					$resultat.=$position[$j].", ";
				}
			$resultat.= "Ceux sont des doublons !";
			return $resultat;
		}

}
echo SEARCHING($TableauN,"pascal");