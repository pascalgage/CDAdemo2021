<?php

$TAB=[5,31,7,48,1,29,13,98,63];

function TRI_BULL(array $TABI){
	
$temp=0;

$bool=false;



	while($bool==false){
			
			$bool=true;

		for($i=0;$i<count($TABI)-1;$i++){
		

			if($TABI[$i]>$TABI[$i+1]){
				
				$bool=false;
				$temp=$TABI[$i];
				$TABI[$i]=$TABI[$i+1];
				$TABI[$i+1]=$temp;
			}
			
		}

	}
	for($j=0;$j<count($TABI);$j++){
	if($TABI[$j]>50){
		$TABI[$j]=0;
	}
	}
$result="Le tableau devient: ".json_encode($TABI);
return $result;

}
echo TRI_BULL($TAB);
?>