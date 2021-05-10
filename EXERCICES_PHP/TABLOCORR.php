<?php
$tableau1=['pascal','doris','david','pascal'];

function RechercheElement(array $montab,string $item )
{
    if (count($montab)==0 )
    {
       return "tableau vide recherche impossible"; 
    }
    else 
    {           $compteur=0;
                $tabposition=[];

            for ($i=0; $i < count($montab); $i++) 
            { 
                if($item==$montab[$i])
                {
                $compteur++;
                array_push($tabposition,$i+1);
                //$tabposition[]=$i+1; 
                    
                }
            }
            if($compteur==0)
            {
                return "l'élément n 'existe pas dans le tableau";
            }
            else {
                $temp="l'élément ".$item." se trouve aux ".$compteur." positions suivantes:";
              for ($j=0; $j<count($tabposition );$j++) 
              { 
                $temp.=$tabposition[$j].", ";
              }
              return $temp;
   
            }
    }
}

  echo "<br><br>On recherche l'element suivant \"DEVOLDERE\" dans notre tableau de noms :<br>".RechercheElement($tableau1,"pascal");

 ?>