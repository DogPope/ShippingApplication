# Shipping App
## So how is Visual Studio for Markdown?
### Fine, but theres no preview that I can see.
### Just checked there, it requires another plugin.
### Never mind, a preview can be seen using SHIFT+F7. GG.

*This project is a college project. It is not connected to a live Database, the data entering the Database is not currently encrypted. Encryption will be added at a later date. It should throw an error when attempting to connect and store information.*

* When changing a git directory, you can just use Bash commands to move folders around. Git may prefer that treatment.

## To-Do list
- Write Encrypted Data into Database, Needs library for encryption along with Salting and Hashing. I'll try this on the Customer Class.
- Familiarise with MySql methods and database.
- Refactor Queries to prevent SQL injection. Parameterised Queries maybe?
- Get plugin for Markdown Preview.
- Generalised testing of Visual Studio to see how it can be broken.
- Refactor 'Status' String to Char.

To make a clone of this project from this Repository, run 
`git clone -b https://github.com/DogPope/ShippingApplication.git`
from a terminal, using the Git Client.

## When the folders are downloaded

Running this script for yourself will not result in data being stored in the app. You will need a copy of Oracle Database for use. Use Oracle to run the script.
The script does not contain any data from real sources. Any resemblence to real people is purely coincidental, and not intended by the author.

Run the shippingSYS.sql Oracle script to create tables for use in the Application. This file contains data for use testing the application. On each install, re-run the Script to generate new Table Definitions.