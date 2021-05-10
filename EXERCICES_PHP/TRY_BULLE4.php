<?php
$Tab=[3,8,5,43,26,17];

function TRI_BULL(array $tableau)
{
	$temp=0;
	$bool=false;

	while ($bool==false)
	{
		$bool=true;
		for ($i=0; $i<count($tableau)-1;$i++)
		{
			if($tableau[$i]>$tableau[$i+1])
			{
				$bool=false;
				$temp=$tableau[$i];
				$tableau[$i]=$tableau[$i+1];
				$tableau[$i+1]=$temp;
			}
		}
	}
	return json_encode($tableau);
}
echo TRI_BULL($Tab);

?>