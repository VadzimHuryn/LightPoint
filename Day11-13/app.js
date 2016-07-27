angular.module('app', ['ngMessages', 'ngResource', 'ngRoute'])
    .config(function ($routeProvider) {
        $routeProvider.when('/contacts', 
            {
                templateUrl: "Homework/Templates/contacts.html",
                controller: "ContactsController"
            });
        $routeProvider.when('/persons', 
            {
                templateUrl: "Homework/Templates/persons.html",
                controller: "HomeworkController"
            });
        $routeProvider.otherwise({ redirectTo: '/persons' });
});