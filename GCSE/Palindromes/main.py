while True:
    userInput = input('Enter some text and this program will tell you if it is a palindrome: ') # Define the variable "userInput" as the user's input
 
    def reverseString(string): # Create a function that reverses any string. The variable "string" is the text that will be reversed.
        return string[::-1] # Return the text, reversed.

    reversedUserInput = reverseString(userInput) # Define the variable "reversedUserInput" as the user's input, reversed.
    if reversedUserInput == userInput: # If the reversed input is the same as the normal input...
        print('Yes, that is a palindrome.') # Tell the user that, yes, it is a palindrome.
    else: # If not...
        print('No, that text reversed is \'' + reversedUserInput + '\'. Not a palindrome.') # Tell the user that, no, it is not a palindrome.