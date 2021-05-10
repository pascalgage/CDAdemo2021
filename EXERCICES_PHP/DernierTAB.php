<?php

$TABLEAU=['pascal','doris','david','hector'];

function Tab_Last(array $TAB){
	$resultat=array_key_last($TAB);

	return $TAB[$resultat];
}

//echo Tab_Last($TABLEAU);
function LAST(array $TAB){
	$r=count($TAB)-1;
	return $TAB[$r];
}
echo LAST($TABLEAU);
?>