<?php

$TAB = ['pascal','david','doris','pascalx'];

function AFFICHETAB( array $monTab){

	for ($i=0; $i <count($monTab) ; $i++) {

		echo $monTab[$i]." "; 
		
	}
}
//AFFICHETAB($TAB);


function RECHTAB(array $monTab, string $item){

	for($i=0;$i<count($monTab);$i++){
		
		if($item==$monTab[$i]){
			return "l'élément recherché se trouve à la position: ".$i. " du tableau";
			
		}
		else{
			echo 'element non trouvé !';
		}
	}

}
//echo RECHTAB($TAB,"pascal");

function AfficheTable($table){


	for ($i=0; $i<=10 ; $i++) { 

		$res= $i*$table;
		echo $res.'<br>';	
	}


}
AfficheTable(12);

$TAB=['LUNDI','MARDI','MERCREDI','JEUDI','VENDREDI','SAMEDI', 'DIMANCHE'];

function AFFJOURSEM(array $tab){

	for($i=0;$i<count($tab);$i++){
		echo $tab[$i].'<br>';
	}
}
//AFFJOURSEM($TAB);















?>