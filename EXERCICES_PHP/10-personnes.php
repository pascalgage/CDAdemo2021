<?php
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

echo '<br/>';

function CalculRetraite($age){

	$seuil=60;

	if($age>0 && $age!=60 && $age<60){

		$res=$seuil-$age;
		echo "Vous partirez à la retraite dans : ".$res;
	}
	else if ($age==$seuil){
		echo "Vous êtes à la retraite cette année";

	}
	else if ($age>$seuil){
		$res1=$age-$seuil;
		echo "Vous êtes à la retraite depuis ".$res1." an(s).";
	}



	else{
		echo "Vous n'êtes pas encore né !";
	}

}

CalculRetraite(64);

echo '<br/>';















?>