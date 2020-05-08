# ShoeCollectionLocalDB
# Summary
An iteration of my shoe collection program that uses a local database file using SQLite to store data the user enters.
The local database embedded within the program allows the program to be redistributed to other devices, allowing each user
to have their own personal list on their device.

## A Look Within
-------------------
### _Main Menu_
![Main Menu](https://github.com/giancarlo-david/ShoeCollectionLocalDB/blob/master/Resources/Main%20Menu.JPG)
  * Displays the current list of shoes that is stored within the database in a table form
  * Displays the current shoe count at the bottom right
  * Displays the currently selected shoe at the bottom left
  * Provides a filter for the user to filter their view of shoes by brand
  * Provides buttons for the user to interact with the program
  
### _Add Shoe_
![Add Shoe](https://github.com/giancarlo-david/ShoeCollectionLocalDB/blob/master/Resources/Add%20Shoe.JPG)
  * Provides drow down combo boxes for the user to pick the shoe's brand (currently restricted to choices
  that I have hard coded in) and size
  * Provides text boxes for the user to input the shoe model and colorway
  * When user is done filling the fields out they click the 'Add Shoe' button to add the shoe to the database
  * Finish button is used to close the Add Shoe form and return to the Main Menu
  
### _Edit Shoe_
![Edit Shoe](https://github.com/giancarlo-david/ShoeCollectionLocalDB/blob/master/Resources/Edit%20Shoe.JPG)
  * All fields are auto populated with the currently selected shoe to edit
  * Edit Shoe button is to finalize any changes the user decides to make
  * Finish button is used to close the Edit Shoe form and return to the Main Menu
  
### _Remove Shoe_
![Remove Shoe](https://github.com/giancarlo-david/ShoeCollectionLocalDB/blob/master/Resources/Remove%20Shoe.JPG)
  * Provides a prompt verifying that the user wants to delete the currently selected shoe when the remove button is clicked
  * Once user confirms removal, the shoe is removed from the database and user is provided dialog that the shoe was removed
  
### _Shoe of the Day_
![Shoe of the Day](https://github.com/giancarlo-david/ShoeCollectionLocalDB/blob/master/Resources/Shoe%20of%20the%20Day.JPG)
  * When the Shoe of the Day button is clicked a random shoe is picked for the user and is displayed via a MessageBox
  * Perfect for when you don't know what shoe to wear

### _Weekly Rotation_
![Weekly Rotation](https://github.com/giancarlo-david/ShoeCollectionLocalDB/blob/master/Resources/Weekly%20Rotation.JPG)
  * When the Weekly Rotation button is clicked a week's worth of random shoes will be picked and displayed to the user
  * Perfect for those that like to plan ahead
  * Currently can have duplicate shoes throughout the week in case user doesn't have different shoes for every day of the week
  
# Extra Stuff
  * All the colors that are on the program were inspired by colorways of my favorite model shoe, the Jordan I. Inspiration 
  colorways include: Bred Toes, Shattered Backboards, Royals
  * I am extremely proud of being able to complete this project and am one step closer to the end goal of making this a
  mobile application, right now I am happy to have turned it into an application since I had come up with this project idea 
  three years ago
  * Would like to improve the UI design in the future as it's super simplistic as of now, would need to learn how to do more
  designing
  * Thank you for checking my project out :)

