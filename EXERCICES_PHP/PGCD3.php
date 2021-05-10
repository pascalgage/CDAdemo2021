<?php
function PGCD(int $a, int $b)
{
	$TABX=[];
	$DIV=1;

	while($DIV<$a && $DIV<$b)
	{
		$DIV++;
		if($a % $DIV == 0 && $b % $DIV == 0)
		{
			array_push($TABX, $DIV);
		}
	}
	$SR=count($TABX)-1;
	return $TABX[$SR];
}
echo PGCD(1974,2021);
?>