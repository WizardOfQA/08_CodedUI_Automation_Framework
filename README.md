# CodedUI_Automation_Framework with Page Object Model
## Description:
Coded UI Test(CUIT) is a Microsoft's GUI testing tool which can test windows form, WPF, and Web applications.
In this project, I tested a couple of scenarios for the AUT(calculator)
I also made this automation framework with Page Object Model which is not many people uses for testing the desktop application.
However, I demonstrated POM here 
Specflow is a .NET version of Cucumber.
We can accomplish Behavior Driven Development(BDD) using Specflow.
In BDD, we write tests first and this can be done by even non programers such as Business Analyst, manual tester, product owner, etc since it uses plain English. Then we write code to support the scenarios.
Each scenario in Specflow becomes a test case. 
In here, I converted a couple of test cases used in POM into Specflow scenarios.
This is the final step of the entire series of creating Selenium UI Automation Framework.

### Setup
1> If your OS is Windows 10, please go to https://winaero.com/download.php?view.1795 and install the old version of calculator from "Download Old Calculator for Windows 10 from Windows 7 or Windows 8" link.
2> Set the application path in App.config file. For example, <add key="AUT" value="C:\Windows\System32\calc1.exe"/>
3> If your OS is Windows 10, skip 1> and just set up the path for the calculator in app.config file. 

## Sameple Test Cases Covered:

* Can_Calculate_Date_Differences
* Length_Conversion_Km_Mile
