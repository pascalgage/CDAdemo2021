<?php
function somme(){
	$arg1= 5;
	$arg2= 5;
	$result= $arg1+$arg2;
	echo $result;
}


function soustraction(){
	$arg1=3;
	$arg2=7;

	$result= $arg1-$arg2;
	return $result;
}


echo '<br/>';

function multiplication($x,$y){
	
	return $x*$y;
}
echo multiplication(3,6);

echo '<br/>';

function division($x,$y){
	
	if($y==0)
	{
		$r=0;
	}
	else
	{
		
		$r=($x/$y);
		$r=number_format($r,2);
	}

	return $r;
}
echo division(20,7);

echo '<br/>';

function EstMajeur($age){
	$bool;	
	if($age<18){
		 $bool= "false";
	}
	else{
		 $bool= "true";
	}
	return $bool;
}
echo EstMajeur(18);







?>