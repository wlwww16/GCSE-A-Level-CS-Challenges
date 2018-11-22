# I had some difficulty finding the most optimised code for this project. This all works, but there might be better ways to do it.
# Since this project is licensed under the MIT license, feel free to modify this code and make it better.
# Regardless, here's the code.

import random
import time
import sys

credit = 100 # Define the "credit" variable as 100 (pence)
symbols = ['Bell', 'Cherry', 'Skull', 'Star', 'Orange', 'Lemon'] # Define the "symbols" variable as the list of possible symbols.

while True:
    credit -= 20 # For every turn the user makes, take away 20p.

    firstSymbol = random.choice(symbols) # Define the "firstSymbol" variable as a random selection from the "symbols" list.
    secondSymbol = random.choice(symbols) # Define the "secondSymbol" variable as a random selection from the "symbols" list.
    thirdSymbol = random.choice(symbols) # Define the "thirdSymbol" variable as a random selection from the "symbols" list.

    prompt = input('Press the Enter key to roll the machine, or type \'q\' and the Enter key to exit.\n') # Prompt the user to either roll the machine or to quit.

    if credit <= 0: # If the credit is less than or equal to 0 (pence)...
        print('I\'m sorry, you ran out of money. Go to the bank and take out a loan.') # Tell the user they ran out of money and need to restart.
        print('You will now exit the Fruit Machine.') # Tell the user that the application will now close.

        time.sleep(3) # Pause for 3s.

        sys.exit() # Exit.
                            
    if prompt == 'q' or prompt == 'Q': # If the user says 'q' or 'Q' (to quit)...
        print('You will now exit the Fruit Machine. You may re-run this file to start again with £1.') # Tell the user they can start again with £1 by re-running the file.
        
        time.sleep(3) # Pause for 3s.
        
        sys.exit() #Exit.
    else: # If they have more than 0 credit and did not choose the quit...
        print('You rolled the following:') # Tell the user the symbols they rolled.
        print(firstSymbol, '-', secondSymbol, '-', thirdSymbol + '\n') # Show those symbols.

        if firstSymbol == secondSymbol or firstSymbol == thirdSymbol or secondSymbol == thirdSymbol: # If any 2 of the 3 symbols are the same...
            if firstSymbol == secondSymbol == firstSymbol == thirdSymbol: # If all 3 are the same...
                if firstSymbol != 'Bell': # If they are not all bells...
                    if firstSymbol != 'Skull': # If they are not all skulls...
                        credit += 100 # Add £1 to the credit.
                        if credit <= 0: # Add a double-check if their credit is less than or equal to 0 (pence).
                            print('I\'m sorry, you ran out of money. Go to the bank and take out a loan.') # Tell the user they ran out of money and need to restart.
                            print('You will now exit the Fruit Machine. You may re-run this file to start again with £1.') # Tell the user they can start again with £1 by re-running the file.
                            
                            time.sleep(3) # Pause for 3s.
                            
                            sys.exit() # Exit.

                        converted = round(credit/100, 2) # Round the £1.
                        newCredit = str(converted) # String-ify that rounding.

                        print('You won £1 for having all three symbols the same! Your new credit is £' + newCredit + '0.') # Print the user's new credit.
                    else: # Else, if they ARE all skulls...
                        credit -= 500 # Take £5 from their credit.
                        if credit <= 0: # If the credit is less than or equal to 0...
                            print('I\'m sorry, you ran out of money. Go to the bank and take out a loan.') # You know what this means by now, surely.
                            print('You will now exit the Fruit Machine.') # You know what this means by now, surely.
                            
                            time.sleep(3)  # You know what this means by now, surely.
                            
                            sys.exit() # You know what this means by now, surely.
                        converted = round(credit/100, 2) #Round the credit.
                        newCredit = str(converted) # String-ify that rounding.

                        print('You lost £5 for having three Skulls! Your new credit is £' + newCredit + '0.') # Print the user's new credit.
                else: # Else, if they ARE all bells...
                    credit += 300 # Add £3 to their credit.

                    converted = round(credit/100, 2) # Round the credit.
                    newCredit = str(converted) # String-ify that rounding.

                    print('You won £3 for having all three symbols as the bell! Your new credit is £' + newCredit + '0.') # Print the user's new credit.
            else: # Else, if there are only two of the same symbols...
                credit += 50 # Add 50p to their credit.

                converted = round(credit/100, 2) # Round the credit.
                newCredit = str(converted) # String-ify that rounding.

                print('You won 50p for having two of the same symbols. Your new credit is £' + newCredit + '0.') # Print the user's new credit.
        else: # Else, if none of the symbols were the same.
            if credit <= 0: # Check if the user's credit is less than or equal to 0...
                print('I\'m sorry, you ran out of money. Go to the bank and take out a loan.') # You know what this means by now, surely.
                print('You will now exit the Fruit Machine.') # You know what this means by now, surely.
                            
                time.sleep(3) # You know what this means by now, surely.

                sys.exit() # You know what this means by now, surely.
            
            converted = round(credit/100, 2)  # You know what this means by now, surely.
            newCredit = str(converted) # You know what this means by now, surely.
            print('You didn\'t win anything this time! Your new credit is £' + newCredit + '0.') # You know what this means by now, surely.
