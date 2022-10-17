<Query Kind="Expression" />

//Truth Tables

/*

NOT (!)
Operand | Result
F       | T
T	    | F


AND (&&)
Operand1|Operand2|Result
F		|F	     |F
F		|T		 |F
T		|F		 |F
T		|T		 |T


Inclusive OR
Operand1|Operand2|Result
F		|F	     |F
F		|T		 |T
T		|F		 |T
T		|T		 |T


Exclusive OR (only want 1 to be true)
Operand1|Operand2|Result
F		|F	     |F
F		|T		 |T
T		|F		 |T
T		|T		 |F


if (!((x>3) && !found)){}
x>3		|found 	 |!found |x>3&&!found |!(x>3&&!found)
F		|F	     |T		 |F			  |T
F		|T		 |F		 |F			  |T
T		|F		 |T		 |T			  |F
T		|T		 |F		 |F			  |T

!((x>3) && !found) -> re-written as:  !(x>3) || found

x>3	|!x>3  |found |OR 
F	|T	   |F	  |T
F	|T	   |T	  |T	
T	|F	   |F	  |F
T	|F	   |T	  |T



!(x>3) || found  -> re-written as: (x<=3) or found

(amazing!)
x<=3 |found |OR 
F	 |T	    |T	  
F	 |F	    |F	 	
T	 |T	    |T	 
T	 |F	    |T	 



*/