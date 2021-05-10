<?php
function PREMIER(int $N)
{
		$decision=$N." EST PREMIER !";
		$reste;
		$div=1;
		$lim=sqrt(abs($N));
		$N=abs($N);
		$bool=true;
do {
		if($N==1){$decision=$N." N'EST PAS PREMIER !";}
		$div++;
		$reste=$N%$div;
		if($reste == 0 & $N!=2)
		{
		$decision=$N." N'EST PAS PREMIER !";
		$bool=false;
		}

	} while($div<=$lim);
	//attention deux valeurs de retour possibles avec cette fonction: demandez soit $decision, soit $bool.
	return $decision;
	//return $bool;
}
echo PREMIER(2);
function GivePremier(int $NBR){
		$TAB=[];
		
		for($i=1;$i<=$NBR;$i++){

			$value=$i;

		if(PREMIER($value)==true & ($value)!=1){
			array_push($TAB, $value);
		}
	}

	return json_encode($TAB);
}
//echo GivePremier(200);
?>