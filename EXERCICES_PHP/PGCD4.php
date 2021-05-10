<?php

function PGCD(int $A, int $B)
{
	$D=0;
	$TAB=[];

	while ($D < $A && $D <$B)
	{
		$D++;

		if ($A%$D==0 && $B%$D==0)
		{
			array_push($TAB, $D);
		}
	}

	$r=count($TAB)-1;
	return "Le PGCD de ".$A." et de ".$B." est : " .$TAB[$r];
}

echo PGCD(1974,2021);


?>