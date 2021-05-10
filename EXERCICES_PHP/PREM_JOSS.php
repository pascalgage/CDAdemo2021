<?php
function nbrPremier(int $nbr)
{
    for ($i=2; $i < $nbr ; $i++) {
        if($nbr % $i == 0)
        {
            return false;
        }
    }
    return true;
}
 
// Test (2 à 20) : 
for ($i=2; $i <= 20; $i++) { 
    echo $i.' : '.(nbrPremier($i) ? 'true' : 'false').'<br>';
}

nbrPremier(20);
?>