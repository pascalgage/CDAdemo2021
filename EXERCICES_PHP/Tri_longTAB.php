<?php

$TAB=['pierre','guillaumme','lea','julien','Cornelius'];
$TABR=[];

function Tri_length(array $item,array $recup, int $long){
	for($i=0;$i<count($item);$i++){
		if(strlen($item[$i])>$long){
			array_push($recup, $item[$i]);
		}
	}
	return json_encode($recup);
}
echo Tri_length($TAB,$TABR,6);
?>