<?php

$TA=[12,24,58,26,32,53,78,89,52];
$TA2=[58,53,78,89,52];

function SUP50(array $TAB,array $TABx){
	
	$TABx=[];
	$TA2=[];
	

		for($j=0;$j<count($TAB);$j++){
			
			
				if($TAB[$j]>50){
					
					
				array_push($TABx,$TAB[$j]);
						}
				
			}
		
	
	return json_encode($TABx);
}
echo SUP50($TA,$TA2);

echo'<br>';

function While_Tri($tab){
	$bool=false;
	$temp;

	while ($bool==false) {
		$bool=true;
		for($i=0;$i<count($tab)-1;$i++){
			if($tab[$i]>$tab[$i+1]){
					$bool=false;
					$temp=$tab[$i];
					$tab[$i]=$tab[$i+1];
					$tab[$i+1]=$temp;
					
				}
			}
		}
return json_encode($tab);
}
echo While_Tri($TA2);
?>