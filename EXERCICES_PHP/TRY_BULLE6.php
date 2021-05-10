<?php

$tableau=[19,32,5,3,29,18];


function TRI_BULL(array $TAB)
{
	$temp=0;
	$bool=false;

	while ($bool==false)
	{
		$bool=true;
		for($i=0;$i<count($TAB)-1;$i++)
		{
			if ($TAB[$i]>$TAB[$i+1])
			{
				$bool=false;
				$temp=$TAB[$i];
				$TAB[$i]=$TAB[$i+1];
				$TAB[$i+1]=$temp;
			}
		}
	}
	return json_encode($TAB);
}
echo TRI_BULL($tableau);




?>