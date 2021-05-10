<?php
function REPEAT(int $NBR){



$chaine="";
$NBR;
$CMP=5;

if($NBR<3){
	$chaine="Le nombre ".$NBR." est inférieur à 3";
}
else if ($CMP<$NBR){
	$chaine="Le nombre ".$NBR." est supérieur à 3 et à ".$CMP;
}
return $chaine;
}

//echo REPEAT(6);



?>