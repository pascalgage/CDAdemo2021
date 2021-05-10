<?php
function PGCD(int $x, int $y)
{
	$div=0;

	$Tab= [];

	while ( $div < $x && $div < $y)
	{
		$div++;

		if ($x % $div == 0 && $y % $div == 0)
		{
			array_push($Tab, $div);
		}
	}

	$result = count($Tab)-1;
	return $Tab[$result];
}

echo PGCD(24,12);
?>