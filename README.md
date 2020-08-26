# 200826 Partial Views Classwork

### Set Up
- Create a .NET MVC app using the .NET CLI called `Classwork`
- Create a controller called `StreamingPlatfroms`
- Run in browser
- Create a postman collection and one request for the landing page

### End Product
Create a Streaming Platform that allows users to view all streaming platfroms, view the details of one platfrom, view platfroms with 5 or more shows/movies and view platfroms with less than 5 shows/movies

### Assigment
#### Models
- Platfrom Model : name, list of shows/movie
- Show/Movie Model : title, description
- PlatfromShows View Model : list of platforms populated in constructor with 3 platfroms

#### PLatfrom Landing Page
- Action : Return associated view
- View : Display h1 with text `Welcome to the Platfrom Landing Page` with links to View all Platfroms, View Popular Platforms, and View Unpopular Platforms

#### View All Platfroms
- Action : Pass public list of platfroms to associated view
- View : Use partial to render details of each platfrom

#### View One Platfrom
- Action : Accept one query param of platfrom name, find platfrom from list of platfroms, pass matching platfrom to approriate view, if matching is not found display view with the text `Platfrom Not Found`
- View : Use partial to render details of each platfrom

#### View Popular Platfroms
- Action : Pass public list of platfroms to associated view
- View : Use partial to render details of each platfrom that have a 3 or more shows/movies (handle the condition in the view)
- * If no platfroms have 3 or more shows/movies display an h1 with the text `All the platfroms are unpopular`

#### View Unpopular Platfroms
- Action : Pass public list of platfroms to associated view
- View : Use partial to render details of each platfrom that have under 3 shows/movies (handle the condition in the view)
- * If no platfroms under 3 shows/movies display an h1 with the text `All the platfroms are popular`