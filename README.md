You should create a Car class that has private fields for the make, model, rental price, and availability status (rented or not rented), as well as public methods for renting and returning a car, and printing information about a car.

Your program should also include a Main method that creates a collection of Car objects, and allows the user to rent and return cars, as well as view information about available cars.



Requirements
Your program should meet the following requirements:

Create a Car class with the following private fields:

make (string)

model (string)

rentalPrice (decimal)

rented (bool)



Create the following public methods in the Car class:

Rent: sets the rented field to true if the car is not currently rented, and returns true if the rental was successful. If the car is already rented, it should display an error message and return false.

Return: sets the rented field to false if the car is currently rented, and returns true if the return was successful. If the car is not currently rented, it should display an error message and return false.

PrintInfo: prints the car's make, model, rental price, and availability status (based on the rented field) to the console.



Create a Main method that does the following:

Creates a collection of Car objects.

Displays a menu with the following options:

Rent a car: prompts the user for a car to rent, and calls the Rent method on that car.

Return a car: prompts the user for a car to return, and calls the Return method on that car.

View available cars: prints information about all cars that are not currently rented, using the PrintInfo method.

Exit: ends the program.

Repeat the menu until the user chooses to exit.



Constraints
Your program should meet the following constraints:

The user interface should be clear and easy to use. Use descriptive menu options and clear prompts to guide the user through the program.

The program should handle invalid user input gracefully. For example, if the user enters a non-existent car ID, the program should display an error message and return to the menu.

The program should be well-organized and easy to read. Use meaningful variable names, clear formatting, and comments to make your code easy to understand.

Your code should be properly documented with comments explaining the purpose and functionality all important pieces of the code.



Example Output
Here's an example of what your program output might look like:

Welcome to the car rental system!
 
Menu:
1. Rent a car
2. Return a car
3. View available cars
4. Exit
 
Please enter your choice: 1
 
Rent a Car:
1. Toyota Corolla (Rental price: 50/day) - Available
2. Honda Civic (Rental price: 60/day) - Available
3. Ford Mustang (Rental price: 80/day) - Available
Please enter the ID of the car you want to rent: 1
 
Rented the Toyota Corolla for $50/day.
 
Menu:
1. Rent a car
2. Return a car
3. View available cars
4. Exit
 
Please enter your choice: 1
 
Rent a Car:
1. Toyota Corolla (Rental price: 50/day) - Rented
2. Honda Civic (Rental price: 60/day) - Available
3. Ford Mustang (Rental price: 80/day) - Available
Please enter the ID of the car you want to rent: 1
 
Sorry, the selected car is not available for rent.
 
Menu:
1. Rent a car
2. Return a car
3. View available cars
4. Exit
 
Please enter your choice: 3
 
Available cars:
1. Toyota Corolla (Rental price: 50/day) - Rented
2. Honda Civic (Rental price: 60/day) - Available
3. Ford Mustang (Rental price: 80/day) - Available
Menu:
1. Rent a car
2. Return a car
3. View available cars
4. Exit
 
Please enter your choice: 1
 
Rent a Car:
1. Toyota Corolla (Rental price: 50/day) - Rented
2. Honda Civic (Rental price: 60/day) - Available
3. Ford Mustang (Rental price: 80/day) - Available
Please enter the ID of the car you want to rent: 4
 
Sorry, the selected car is not available for rent.
 
Menu:
1. Rent a car
2. Return a car
3. View available cars
4. Exit
 
Please enter your choice: 2
 
Return a Car:
1. Toyota Corolla (Rental price: 50/day) - Rented
2. Honda Civic (Rental price: 60/day) - Available
3. Ford Mustang (Rental price: 80/day) - Available
Please enter the ID of the car you want to return: 1
 
Returned the Toyota Corolla.
 
Menu:
1. Rent a car
2. Return a car
3. View available cars
4. Exit
 
Please enter your choice: 3
 
Available cars:
1. Toyota Corolla (Rental price: 50/day) - Available
2. Honda Civic (Rental price: 60/day) - Available
3. Ford Mustang (Rental price: 80/day) - Available
Menu:
1. Rent a car
2. Return a car
3. View available cars
4. Exit
 
Please enter your choice: 4
Thank you for using the car rental system!
