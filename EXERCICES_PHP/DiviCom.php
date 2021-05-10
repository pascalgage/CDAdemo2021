<?php

function DiviCom(int $a, int $b)

{
	$div = 0;
	$Tab = [];

	while ( $div < $a && $div < $b ) 
	{
		$div++;

		if ($a % $div == 0 && $b % $div == 0)
		{
			array_push ( $Tab, $div );
		}
	}

	return json_encode($Tab);
}

	echo DiviCom(24,12);

?>