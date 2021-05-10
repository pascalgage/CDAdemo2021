<?php

$TAB=['Devoldere','Chatelot','Thiry','Roche','Leroy'];

function PremierElementTableau(){

global $TAB;
$premier=array_key_first($TAB);
$element=$TAB[$premier];

if($premier==''&&$premier!=0){$element="null";}

echo $element;
}

PremierElementTableau();

echo '<br/>';

function DernierElementTableau(){
	global $TAB;
	$dernier= array_key_last($TAB);
	$element=$TAB[$dernier];

	if($dernier==''){$element="null";}

	echo $element;
}

echo DernierElementTableau();

echo'<br/>';

function DernierElemTAB(){
	global $TAB;
	$element= end($TAB);

	return $element;
}
echo DernierElemTAB();
?>