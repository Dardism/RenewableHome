# RenewableHome

1. Introduction
 
1.1  Purpose of this Document

This document provides a low-level and high-level description of the Renewable Home web application. This application allows a user to see the possible effects of using or investing into renewable energy resources for their home. This is done by the user inputting information about their home, and then seeing how different energy sources can affect their utility cost. The use of this document can be utilized by software developers and project managers.

1.2 Scope of the Development Project

The Renewable Home application will be hosted online and can be viewed by any user accessing it. On the start screen, the user will begin by entering in information about their home, including the total square feet, as well as their monthly utility consumption. There is a helpful dropdown showing the consumption rates by state, in case the user doesn’t have their information on hand, or if they are curious as to how other states match up. There will then be a screen depicting various forms of energy use, with a slider to indicate the percentage use. A button will be displayed besides each source to provide helpful information, and to also provide links to outside websites in case the user wants to learn more about each source of energy. The final page will use the energy indicators to determine the final calculation on the next screen. This will display their yearly energy cost and the cost per square foot for the user to see how much a sustainable energy lifestyle would cost.

Objectives

The objectives of the overall application include an increased awareness on renewable energy resources to help promote sustainability within residential communities. One way to do that is to have an application to show different renewable energy sources on the market to see how current trends can shape the costs of the user. Information about each source will be provided and helpful links will also be provided to raise awareness about each source of energy. An important objective includes having a clean interface to easily navigate through the different pages. The user interface will also be able to adapt to different devices and screen sizes to maximize its usability.



1.3 Definitions, Acronyms, Abbreviations

User - Any person accessing the web application
KW - Kilowatt
CO2 - Carbon Dioxide
UI – User Interface
ASP.NET – Framework used for application development
Visual Studio – Microsoft’s integrated development environment

 
1.4  References
 
Rozenblat, Lazar. "Your Guide to renewable Energy." Renewable Energy Sources: Cost Comparison. N.p., n.d. Web. 11 June 2017. <http://www.renewable-energysources.com/>
Simmons, C. Instant Responsive Web Design : Learn the Important Components of Responsive Web Design and Make Your Websites Mobile-friendly. Birmingham, UK : Packt Publishing, 2013
Amin, Adnan Z. "How renewable energy can be cost-competitive." UN Chronicle P8 52.3 (2015): 8-11. UWF Libraries. Web. 4 June 2017
Bellomy, Ian1. "The Grain of the Browser: What Designers Should Know about the Craft of Web Design." International Journal of Visual Design, vol. 11, no. 1, Mar. 2017, pp. 1-15. EBSCOhost


2. System Architecture Description

2.1 Overview of Modules/Components

The application is built in Visual Studio, and has the ability o be deployed on any web hosting service, such as Microsoft’s Azure cloud service. The data repository is used to provide the current information about a type of energy. This is then tied to the energy calculation table to provide the specified outcome on the final page. The main class for the application will create instances of the HomeInfo class, the EnergyType class, and the HomeController class to handle all get and post requests to the application. These instances are created during runtime. During the application, the user will enter in information which includes their home information, as well as their chosen combination of energy. The web server will provide validation checks to make sure the user is entering the correct type of data. The final results page will display the yearly cost of the chosen resource allocation, and it will include cost per square feet.

2.2 Structure and relationships

The application interface will handle user commands and will access the web server being used to then access the data repository for information. The repository will then provide the application with information to initialize objects to use for the energy calculation for the user.
