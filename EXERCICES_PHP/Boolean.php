<?php
function makeitworks($mot){
	 $OK=true;

	if(strlen($mot)>3){
		$OK=true;
	}else{
		$OK=false;
	}
	return $OK;
}



if(makeitworks("po")==false){
	echo "ça marche pas";
}else{
	echo"boolean est true";
}
?>

