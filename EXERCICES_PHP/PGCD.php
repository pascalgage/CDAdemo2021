<?php

function PGCD (int $x, int $y)

{

	$div=0;
	$tab=[];

	while ($div < $x && $div < $y)
		
	{

		$div ++;

		if ($x % $div ==0 && $y % $div ==0)
		{
			array_push($tab, $div);
		}

		
	}

		$r = count($tab)-1;
		return $tab[$r];

}

	echo PGCD(1974,2021);

?>