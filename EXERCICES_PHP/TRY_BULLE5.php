<?php
$Tab=[3,8,5,43,26,17,2,1,28,57];
function TRI(array $monTab)
{
	$temp=0;
	$bool=false;

	while ($bool==false)
	{
		$bool=true;
		for($i=0;$i<count($monTab)-1;$i++)
		{
			if($monTab[$i]>$monTab[$i+1])
			{
				$bool=false;
				$temp=$monTab[$i];
				$monTab[$i]=$monTab[$i+1];
				$monTab[$i+1]=$temp;
			}
		}
	}
	return json_encode($monTab);
}
echo TRI($Tab);


?>