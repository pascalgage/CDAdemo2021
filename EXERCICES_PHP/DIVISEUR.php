<?php
function DIVIDE(int $NBR)
{
	$TAB=[];
	$DIV=0;
	
		
		do
		{
			$DIV++;

			if($NBR % $DIV == 0)
			{
				array_push($TAB,$DIV);
			}
			
		}


		while($DIV<$NBR);
		
		
	
	return json_encode($TAB);
}
echo DIVIDE(50);
?>