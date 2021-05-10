<?php

$Tablo=[9,17,5,43,29];

function TRI(array $Tab)
{
	$temporal=0;
	$boolean=false;

	while ($boolean==false)
	{
		$boolean=true;
		for($i=0;$i<count($Tab)-1;$i++)
		{
			if($Tab[$i]>$Tab[$i+1])
			{
				$boolean=false;
				$temporal=$Tab[$i];
				$Tab[$i]=$Tab[$i+1];
				$Tab[$i+1]=$temporal;			
			}
		}
	}

	return json_encode($Tab);
}
echo TRI($Tablo);
?>