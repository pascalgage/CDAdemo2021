<?php
$Tableau=[5,18,9,47,56,12,27,3,2,1];

function TRi_Bulle(array $Tab)
{
	$bool=false;
	$temp=0;

	while($bool==false)
	{
		$bool=true;
		for($i=0;$i<count($Tab)-1;$i++)
		{
			if($Tab[$i]>$Tab[$i+1])
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
echo TRi_Bulle($Tableau);
?>