# fictional-carnival
Test for Progress Teaching role

Before beginning to program, I broke the two tasks down into subroutines that each performed a unique function. This planning saved me from having to rewrite parts of my code and therefore saved time. This also stopped unneeded repetitions in the code making for a smaller and easier to read file. This process is more noticeable with Task 2 as the function that calculates each subject's progress score has to be called three times.

In order to not have to rewrite broken code, I tested each function after I programmed it, leading to many changes. One of these was when I accidentally entered a string into a variable that the computer then attempted to convert to a double which lead me to realise that this would be a common user misinput if this code was ever to be distributed. To fix this, each Task class has a try-catch statement which prevents the programme from crashing if the user enters the wrong datatype into a variable.

Once I had finished programming, I used the test data supplied in the email to make sure that my programme works. Although I did not have time to test data from every row in the table, I took a random selection of students and ran their data through my programme, which did come to the same average and progress scores that are in the table. In addition, I also tested edge cases such as wrong datatype entry (as mentioned above), no data, too few scores (eg. Maths and English present but no third score to be assigned to Science) and others. 
