<?php
function S100(int $N)
{
	
	$resultat=0;

	for($i=0;$i<=$N;$i++)
	{
	$resultat=$resultat+$i;
	}
	return $resultat;

}
echo S100(1000);

?>