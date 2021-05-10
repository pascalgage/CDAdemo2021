<?php

function PPCM (int $x, int $y)

{

	$div=0;
	$tab=[];

	while ($div < $x && $div < $y)

	{

		$div ++;

		if ($x % $div == 0 && $y % $div == 0)
		{
			array_push($tab, $div);
		}

		
	}

		$r = count($tab)-1;

		$ppcm="Le PPCM est de : ".($x*$y)/($tab[$r]). " alors que le PGCD est de : ".($tab[$r]);
		

		return $ppcm;

}

	echo PPCM(1974,2021);

?>