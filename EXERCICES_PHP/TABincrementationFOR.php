<?php

$TAB=array(10,20,30);
$TAB2=[12,24,9,18,42];

function TabINCR(array $monTab, int $Plus){

for($i=0; $i<count($monTab);$i++){

	$monTab[$i]=$monTab[$i]+$Plus;
}

return json_encode($monTab);



}

echo TabINCR($TAB,5);
echo'<br>';
echo TabINCR($TAB2,6);
?>