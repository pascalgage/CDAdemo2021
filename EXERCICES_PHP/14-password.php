<?php
function PasswordLength($pass){
$OK="true";
if(strlen($pass)>=8){
	
	$OK="true";
	
}else{
	
	$OK="false";
}
return $OK;

}
echo PasswordLength("azpu");


echo '<br/>';


function PasswordCheck($pass){

if (PasswordLength($pass)=="true" && preg_match('/(?=.*[0-9])[A-Z]|(?=.*[A-Z])[0-9]/', $pass)) {
echo "mot de passe ok";
}else{
	echo"au moins un chiffre et une lettre en majuscule et minimum 8 caractères !";
}

}
PasswordCheck("azR9t");











?>