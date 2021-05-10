<?php


$TABLEAU=[3,2,8,-7,45,37.5,37.3,-98,1978,-1311];
$TAB=[5,3,7,4,1,9];


function TriBulle(array $TAB){
	$bool=true;
	$temp=0;

	do
	{
		$bool=true;

		for($i=0;$i<count($TAB)-1;$i++){

			if($TAB[$i]>$TAB[$i+1]){
				$bool=false;
				$temp=$TAB[$i];
				$TAB[$i]=$TAB[$i+1];
				$TAB[$i+1]=$temp;
			}
		}
	} while($bool==false);

	$result= "Le tableau devient: ".json_encode($TAB);
	return $result;

	
}
echo TriBulle($TABLEAU);
echo '<br>';
echo TriBulle($TAB);
?>