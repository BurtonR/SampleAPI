# SampleAPI
A RESTful API sample

## Project initialization:
* You must have an instance of SQL Server running
* The Server must be aliased with 'LocalDB'
* Run the two .sql files in the Database directory
 * dofactory-model.sql   _first_
 * dofactory-data.sql   _after dofactory-model.sql runs_
* Create a user:
  * Username: "doFactoryService"
  * Password: "doFactoryService"


## To use the API:
* Run the project (F5)
* Go to: "localhost:[port]/api/Customer"
  * To get a list of the customers
* Go to: "localhost:[port]/api/Customer/5"
  * To get a single customer


***


##### More updates to come as I get time and play around some more
