<?php

function Perfect(int $A){

$TAB=[];
$i=0;
$A=abs($A);
$NBR=1;

for ($i = 1; $i <= $A; $i++)
{
                do
                {
                    $NBR++;
                    $D = 1;
                    $DS = 0;
                    do
                    {
                        $R = $NBR % $D;
                        if ($R==0)
                        {
                            $DS += $D;
                            $D++;
                        }
                        else
                        {
                            $D++;
                        }

                    } while ($D<$NBR);
                    if($DS == $NBR)
                    {
                        array_push($TAB,$NBR);
                    }

                } while ($DS != $NBR);
}
return json_encode($TAB);
}
echo Perfect(3);
?>