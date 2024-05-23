# taskscsharp

#task1

#scenario 1: inform if user are logged
I Start application
Then i receive mensage "[INFO] User logged in"  

#scenario 2 : inform time when user are logged in
I Start application
Then i receive mensage with current time

#scenario 3 :inform if have warnings and message of warning
I Start application
Then i receive mensage "[WARNING] Failed login attemp"  

#scenario 4: inform time when user receive warning
I Start application
Then i receive mensage with current time


#task2

#scenario 1:Verify is :Sorted by Name (Ascending)
I start application
Then list with name should be Ascending

#scenario 2:Verify is :Sorted by Name (Descending)
I start application
Then list of name should be Descending

#scenario 3:Verify is :Sorted by Price (Ascending)
I start application
Then list with price should be Descending

#scenario 4:Verify is :Sorted by Price (Descending)
I start application
Then list with price should be Descending

#scenario 5:Verify is :Sorted by Stock (Ascending)
I start application
Then list with stock should be Ascendending

#scenario 6:Verify is :Sorted by Stock (Descending)
I start application
Then list with stock should be Ascendending
