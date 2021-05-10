<?php

$TABLO=[3,7,2,43,18,15,27];

function Tri_Bull(array $Tab)
{
	$temp=0;
	$bool=false;
	while($bool==false)
	{
		$bool=true;
		for($i=0; $i<count($Tab)-1;$i++)
		{
		if ($Tab[$i]>$Tab[$i+1])
			{
				$bool=false;
				$temp=$Tab[$i];
				$Tab[$i]=$Tab[$i+1];
				$Tab[$i+1]=$temp;

			}
		}
	}
	return json_encode($Tab);
	
}
echo Tri_Bull($TABLO);

?>
//fait seul en 10 minutes de mémoire 100% ME !!!!