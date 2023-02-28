# PROG7321_Task_1

## Introduction

This readme file will explain the functions of the application for Part 1 of PROG 7321. The file will show how to interact with the application,
how the program works and the results. Components behind the application will also be explained on howit influences the functionality
of the program.

## Start of the application

When you start the program, you will enter the menu screen with three buttons to choose from Replacing books, identifying areas to finding
call numbers.
For now only the first part with replacing books will be functional. The rest of the buttons will not respond to user clicks.

For replacing books, 10 random call numbers will be generated. These call numbers are generated using a Random class with next method for
the number and for loop used with random selected from the alphabet string as character. These are then combined together as a string. They are
then stored in a List of strings called CallNums (SingletonSean, 2021) (mkyong, 2015).
There are two listboxes, one for the random generated call numbers and one
for the user's answer as a result. The listbox items can be drag and dropped from one listbox to another(Diptimaya Patra, 2010). When dropped
the listbox list of items will be updated and reflected on the display.
The item dropped will appear last but can be rearranged in the listbox (Diptimaya Patra, 2010).
When the User clicks on the submit button, the listbox list of items from the second listbox will be checked. A sort of 
the list is done using bubble sort although work is being done to convert radix sort to work for strings (w3resource, 2022).

##After submit button in application

When the sort is done, the sorted list will be compared to the list submitted by the user. If there is a match, the user will be notified of 
successful match. The progress bar will increase by ten percent and there will be a 30 point increase. User can then proceed to the next 
part with next set of random numbers. Process is the same as explained before.
 However if there is no match, then User will get decrease of 5 points and 10 percent decrease in the progress bar. If progress bar is less 
than zero, then the game is over. This also occurs if the points is less than zero. If the progress bar reaches 100%, then the game will be completed. A new high score will be recorded.

When you exit the window via back button, it will go back to the main menu and show you the score during user's run.

## Identifying Areas

Second part of the application is match the columns with the call numbers and their descriptions. For this part 7 random call numbers will be generated (mkyong, 2015). Each call number will be 
assigned their description depending on the Call Number. They are stored in a dictionary.These will be displayed and the first 4 call numbers from dictionary are assigned to each respective 4 buttons. This can also be 4 descriptions as
they alternate between each other. The same goes from the 7 call numbers or description which are randomly placed in 7 buttons(GeeksforGeeks,2022)(abierhaus,2015).

To select the question button, click on it. It will change the color to cyan or light blue to confirm the button has been selected. Then you can click on the answer button on the right side
of the window. It will draw a line between the buttons slected. This will add the answer to the answers dictionary(Zafer Ayan, 2013). To deselect the question button, click on it again and it will remove the line and change the color to purple.
It also removes the answer and question from the answers dictionary. It also deselects the button.
Same applies to the 4 question buttons and the 7 answer buttons.

When you submit the answers dictionary will be compared to the orign Callnumbers dictionary. If there is a 100% match, the user will be notified of the 100% match to the colunm. If there is
no 100% match, the user will be informed of the incorrect match and will be shown the correct match (Evan Won, 2014). The progress bar will increase by ten percent and a 50 point increase in the score. There is
also a 50 point decrease and 10 percent decrease in progress bar value if the user does not get 100% match. Once the user gets to 100% in the progress bar, he/she will be given a option
to progress to level 2, continue with the current level or exit the game.

If you select to progress to level 2, you will get more challenge matching the colunms as they also include sub categories of the Dewey decimal system as well. Points rewarded are 70 points.
Progress bar remains the same as level 1. If you complete level 2, you have the optiion of either continue with the level, downgrade to level one or exit the window(Evan Won, 2014).

When exiting to the main menu via back button and option given after finishing the level, the user wil go back to the main menu and displayed a score during his/her run.

## Identifying Call Numbers

Identifying call numbers is the quiz where you find the call number relating to the description. First you will be given a description and 4 random buttons with different top level 
call numbers is given. These numbers are for example 000 or 700. Three are incorrect and one is the right answer. If you choose a correct answer, 4 other buttons appear with different second 
level call numbers for example 720 or 150. Same format  with three incorrect and one right call number. If the user clicks on the button and the answer is correct then the final 
part is shown. Again 4 random buttons are shown and with similar format used except it is for third level call numbers like 123 or 555. If the final answer  is correct, then 
the answer will be shown on top in the center of the main window. 50 points will also be gained and shown.

If the user clicks a button with the wrong answer, then the user can lose 50 points in the score. If the score is less than 50, the game will be over and the user will shown the final 
score before going to main menu. However as the user progress through different levels, the points you lose decreases to 25 points when on second level and 15 points on the third 
level. 

The progress bar in this case includes one that increases by 40 when user passes top level, 40 again when second level and then 20 for the third level. The progress bar will
reset when the user clicks on the button for the wrong answer.


## Conclusion

The Readme file explains how the application works, the functionality behind the program and the general flow of the application. Thus far 
the Replacing books functionality and identifying areas with call numbers and description match is shown as required. The identifying call
numbers have been added getting call numbers for given description.
