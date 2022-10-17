<Query Kind="SQL" />


--SQL to parse out JSON into columns

declare @jsonStr varchar(max)

set @jsonStr = (select top 1 SearchCriteria
from savedSearch with (nolock)
where Id = '8B094824-9EB8-46BB-A71A-30F7354C25A4')

print @JsonStr

SELECT *
FROM OPENJSON(@jsonStr);