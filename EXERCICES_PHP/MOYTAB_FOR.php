<?php

$TABPASKY=[12,9,13,5,4,6];
$TABARMY=[4,12,16,11,20];
$TABERIC=[5,12,16,14,17];

function MOYENNE(array $tableau){

$moy=0;

for($i=0; $i<count($tableau); $i++)
{
	$moy=($moy+$tableau[$i]);
}
	$RES=round(($moy/count($tableau)),2);


	if($RES>=10){
		$test="L'élève passe en classe supérieur avec: ".$RES." de moyenne";
	}else{
		$test="Elève recalé avec: ".$RES." de moyenne";
	}
	return $test;
}

echo MOYENNE($TABARMY);
echo'<br>';
echo MOYENNE($TABPASKY);
echo'<br>';
echo MOYENNE($TABERIC);

?>