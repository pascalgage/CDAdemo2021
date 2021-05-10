<?php

$tableau1 = array("DEVOLDERE", "CHATELOT", "THIRY","FLORES", "ROCHE","DEVOLDERE","LEROY","FLORES") ;
 
function RechercheMotTab(array $_tableau, string $_mot )
{
    $_mot=StrToUpper($_mot);
    $compteur=0;
    $tabposi=[];

    for ($i=0; $i <count($_tableau) ; $i++) 
    {
      
        if ($_tableau[$i]==$_mot)
            {
                $compteur++; 
                array_push($tabposi,$i+1);

            }    
    }

        if ($compteur==0)
            {
                return "le mot :".$_mot." n'est pas dans le tableau "; 
            }

        else if ($compteur==1) 
            {
                return "le mot :".$_mot." n'est présent qu'1 fois dans le tableau à la position ".$tabposi[0] ;   
            }
        
        //si le compteur de départ $compteur est supérieur à 1 fois ! Concaténations à suivre =Bonjour vieux...
        else
            { 

                 $chaineres="le mot :".$_mot." est présent ".$compteur." fois dans le tableaux aux rangs: " ;
                        for ($i=0; $i <count($tabposi) ;$i++)
                            {
                
                                 $chaineres.=$tabposi[$i].", ";
                            }
            
                $chaineres.=" il s'agit de doublons.";
                
                return $chaineres;

            }


//fin de la fonction !
}
//appel de la fonction...
echo  "test:".RechercheMotTab($tableau1, "ROCHE");

?>