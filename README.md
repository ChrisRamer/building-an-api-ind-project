# *Animal Shelter Client*

#### *Animal Shelter Client, 07/23/2021*

#### By **Chris Ramer**

## Description

An application that shows the animals available in an animal shelter and allows for modifying the list of animals.

## Setup/Installation Requirements

Clone this repo and the [API repo](https://github.com/ChrisRamer/building-an-api-ind-project-api).

Navigate to the `AnimalShelterApi` directory in the Terminal and run the command `dotnet ef database update` to create the database.

Then run the command `dotnet run` to run the API.

Then, open another Terminal window and navigate to the `AnimalShelterClient` directory and run the command `dotnet run` and open `localhost:5000` in your browser.

## Specs

* **Spec:** Selecting a version on homepage stores the selected version and directs to `/animals` using that version
* **Input:** Selected version: 2
* **Output:** Endpoint redirected to: `v2/animals`
* **Spec:** Clicking on an animal at `/animals` directs to page showing the details for that animal
* **Input:** Click on animal with ID of `5`
* **Output:** Directs to `/animals/5` to show details for that animal
* **Spec:** Editing an animal's details will overwrite that animal's details and update it in the database and redirects to that animal's details page
* **Input:** Change Floofer's name to Sabbath
* **Output:** Waits for Floofer's name to get updated to Sabbath in the database, then user is redirected to the details page for that animal which shows the new change
* **Spec:** Adding a new animal will add the animal to the database and redirect to page showing all animals
* **Input:** Add animal with name "John"
* **Output:** Waits for the database to update, then redirects to details page for John
* **Spec:** Deleting an animal will delete that animal from the database and redirect to page showing all animals, with the deleted animal removed from the list
* **Input:** Delete animal "John"
* **Output:** Waits for John to get deleted from the database, then redirects user to page showing all animals with John no longer shown

## Technologies Used

* C#
* ASP.NET
* .NET Core

### License

Copyright (c) 2021 **Chris Ramer**

This software is licensed under the MIT license.