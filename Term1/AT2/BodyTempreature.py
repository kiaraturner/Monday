
user_input = float(input("Please enter your tempreature:"))  # prompts user for input

if (user_input >=37 and user_input<=38): # if a number higher than 37 or lower than 38 in entered normal will print to console
    print ("normal") 
    
elif (user_input >=38 and user_input<=39): # if a number higher than 38 or lower than 39 in entered fever will print to console
    print ("fever")

elif (user_input >=39 and user_input<=40): # if a number higher than 39 or lower than 40 in entered high fever will print to console
    print ("high fever")

elif (user_input >=40 and user_input<=41): # if a number higher than 40 of lower than 41 in entered very high fever will print to console
    print ("very high fever")

elif (user_input >=41): # if a number higher than 41 is entered than emergency will print to console
    print ("emergency")


