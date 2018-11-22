import random
import time
import sys

userInput = input('Input the numbers you have stolen: ') # Define the variable "userInput" as the user's input.

possibilities = [] # Create an empty list (often called an "array" in other languages).

splitNumbers = list(str(userInput)) # Define the variable "splitNumbers" as a list of all letters in the userInput variable.

timeout = time.time() + 2 # Define the variable "timeout" as the current time and an additional 2s.

while len(possibilities) < 25: # With 4 unique numbers, the maximum amount of possibilities is 24. So, while the length of items in the empty possibilities array is less than 25...
    if time.time() > timeout: # It only takes a split second to work out all possibilities, so  we only need to run the program while the current time is less than the time at which we started (and two more seconds after that.). 
        sys.exit() # If it is out of time, exit the program.
    randomSample = random.sample(splitNumbers, 4) # Randomly select 4 numbers from our 4 user provided numbers. This emulates 4 random numbers being selected.
    if randomSample not in possibilities: # If those 4 random numbers aren't in the list of already completed possibilities... 
        possibilities.append(randomSample) # Add those random 4 numbers to the list so they don't get repeated.
        print(randomSample) # Print the random 4 numbers.
