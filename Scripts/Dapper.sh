#!/bin/bash
cd /Users/cedric/Documents/repos/METIS-TA/ORM/MyDapper/MyDapper
for i in {1..100}
do
  val=$(dotnet run)
  echo $val | awk '{print $NF}' >> ./output.csv  
done
echo done