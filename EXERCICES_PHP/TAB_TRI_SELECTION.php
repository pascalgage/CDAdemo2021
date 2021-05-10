<?php

$TABLO=[3,2,12,7];

function Tri_SELECT(array $TAB){
	$mini=0;
	$temp=0;

	for($i=0; $i<count($TAB)-1;$i++){
		$mini=$TAB[$i];

		for($j=$i+1; $j<count($TAB);$j++){
			if($TAB[$j]<$mini){
				$temp=$TAB[$i];
				$TAB[$i]=$TAB[$j];
				$TAB[$j]=$temp;
			}

		}



	}
	return json_encode($TAB);
}

echo Tri_SELECT($TABLO);




?>