<?php

$tableau1=[3,12,1,2,27,38,49,16];
function tri_a_bulle(array $tab)
{
	$temp=0;
	$bool=false;

	while ($bool==false)
	{
		$bool=true;
		for($i=0; $i<count($tab)-1;$i++)
		{
			if($tab[$i]>$tab[$i+1])
			{
				$bool=false;
				$temp=$tab[$i];
				$tab[$i]=$tab[$i+1];
				$tab[$i+1]=$temp;
			}
		}
	}
	return json_encode($tab);
}
echo tri_a_bulle($tableau1);

?>