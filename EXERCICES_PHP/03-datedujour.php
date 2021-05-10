<?php
function DateDuJour(){
	$date= new DateTime('2000-01-01');
	echo $date->format('Y-m-d H:i:s');
}

DateDuJour();


?>