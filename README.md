# _Vendor Orders_

#### _A MVC Application that tracks vendors and their orders, March 2020_

#### By _**K. Wicz**_


## Description

_This program provides an admin page for a small business owner to track their vendors and each of their vendors orders._


## Project Specifications

| Behavior | Input | Output |
|:---|:---:|:---:|
|User can add a new vendor|"Epicodus Coffee" |A new instance of the vendor object called "Epicodus Coffee" is instantiated and added to a vendor list.|
|User can view all vendors|Navigate to "All Vendors" page| A list of all vendors with links to individual vendor page|
|User can view individual vendor|Clicks individual vendor link| All data for that vendor is displayed|
|User can delete all vendors| User selects "Clear Vendor List| User confirmation is requested and then vendor data is cleared|
|User can add a new order to an individual vendor|"Bagels"|A new instance of the order object called "Bagel" is instantiated and added to an order list for a specific vendor"|
|User can specify the quantity of the order|"Bagels", 4|Quantity is added to the "bagel" order object|
|User can view all orders|User navigates to all orders|All orders are displayed with a link to their individual order detail page|
|User can view individual order details|User clicks link individual order link|All data for that order is displayed|
|User can clear all orders| User selects "Clear Order List"| User confirmation is request and then order data is cleared|


## Setup/Installation Requirements

In your computer's terminal:

1. Navigate to where you want this application to be saved, i.e.:
```sh
cd desktop
```
2. Clone the file from GitHub with HTTPS
```sh
git clone 
```
3.  Enter into the new file directory
```sh
cd vendororders.solutions
```
4.  Start the program
```sh
dotnet run
```
## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/kwicz/vendororders.solutions/issues) here on GitHub._

## Technologies Used

* C#
* .NET Core
* Razor Templating

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_K.Wicz_**
