<?php

function PasswordLength($pass){

$OK=true;

if(strlen($pass)>=8)
{
	
	$OK=true;
	
}else{
	
	$OK=false;
	
}

return($OK);


}

PasswordLength("azpu");


echo '<br/>';


function PasswordCheck($pass){

if (PasswordLength($pass)==true && preg_match('#[A-Z]+#',$pass)==true &&  preg_match('#[a-z]+#',$pass)==true && preg_match('#[0-9]+#',$pass)==true)
{
	return "mot de passe ok";
}
else
{
	return "au moins un chiffre et une lettre en majuscule et minimum 8 caractères !";
}

}

echo "res =".PasswordCheck("b12lmghT");

?>

