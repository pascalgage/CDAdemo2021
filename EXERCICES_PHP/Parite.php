<?php

function PAIR(int $nbr){
	$DIV=2;
	$bool=true;
	if($nbr%$DIV==0){
		$bool=true;
		$decision=$nbr." est pair !";

	}
	else{
		$bool=false;
		$decision=$nbr." est impair !";
	}

	return $bool;
}
//echo PAIR(4);

function GivePair(int $NBR){
	$TAB=[];

	for($i=1;$i<=$NBR;$i++){
		if(PAIR($i)==false){
			array_push($TAB, $i);
		}
	}

	return json_encode($TAB);
}
//echo GivePair(50);
function WHILE_PREMIER(int $N){
		$decision=$N." EST PREMIER !";
		$reste;
		$div=1;
		$lim=sqrt(abs($N));
		$N=abs($N);
		$bool=true;
		while($div<=$lim){
		if($N==1){$decision=$N." N'EST PAS PREMIER !"; $bool=false;}
		$div++;
		$reste=$N%$div;
		if($reste == 0 && $N!=2)
		{
		$decision=$N." N'EST PAS PREMIER !";
		$bool=false;
		}
	return $bool;	
	}

}

$TABleau=[1,3,5,6,2,27,48,53,47];

function PairANDPrem(array $TAB){
	$TABres=[];

	for($i=0;$i<count($TAB);$i++){
		if(WHILE_PREMIER($TAB[$i])==true && PAIR($TAB[$i])==true){
			array_push($TABres,$TAB[$i]);
		}
	}
	return json_encode($TABres);
}

echo PairANDPrem($TABleau);



?>
