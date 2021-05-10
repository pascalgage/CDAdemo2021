<?php
function concatenation(){
	$arg1="Mickael";
	$arg2="Devoldere";

	echo "$arg1 $arg2";

}
function concatenationV2(){
	$arg1="Mickael";
	$arg2="Devoldere";

	$arg1V=strtolower($arg1);
	$arg2V=strtoupper($arg2);

	echo"$arg1V $arg2V";	
}

concatenationV2();
?>