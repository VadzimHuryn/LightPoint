angular.module('app').controller('HomeworkController', HomeworkController);


function HomeworkController($scope, $http, PersonsService)
{
    $scope.hide = true;
    $scope.hide2 = true;
    $scope.phoneHide = false;
    $scope.faxHide = true;
    $scope.selectHead = 'Home Phone Number';
    $scope.selectPhone = 'Home Phone Number';
    $scope.selectFax = 'Fax Phone Number';
    $scope.letter = "";
    $scope.deletePersonId;
    $scope.alertHide = true;
    $scope.personState = [];


    var personsarray = [];
    PersonsService.getPersons().then(function (responce) {
        personsarray = responce.data;
        $scope.userarray = personsarray;
    });


    //function  persons() {
    //    var per = [];
    //    for (var k = 1; k <= localStorage.getItem("maxKey") ; k++) {
    //        if (JSON.parse(localStorage.getItem(k)) != undefined)
    //            per.push(JSON.parse(localStorage.getItem(k)));
    //    }
    //    $scope.userarray = per;
    //};
    //persons();


    $scope.editPerson = function(personId)
    {
        for(var i=0; i<personsarray.length; i++)
        {
            if(personsarray[i].id==personId)
            {
                $scope.editPersonId = personId;
                $scope.editPersonFirstName = personsarray[i].firstName;
                $scope.editPersonLastName = personsarray[i].lastName;
                $scope.editPersonAge = personsarray[i].age;
                $scope.editPersonStreetAddress = personsarray[i].address.streetAddress;
                $scope.editPersonCity = personsarray[i].address.city;
                $scope.editPersonState = personsarray[i].address.state;
                $scope.editPersonPostalCode = personsarray[i].address.postalCode;
                $scope.editPersonHomePhoneNumber = personsarray[i].phoneNumber[0].number;
                $scope.editPersonFaxPhoneNumber = personsarray[i].phoneNumber[1].number;
            }
        }
    }

    $scope.updatePerson = function (personId) {
        personsarray = PersonsService.updatePerson(personsarray, personId, $scope);
    }

    $scope.clearAddPerson = function () {
        $scope.personId = '';
        $scope.personFirstName = '';
        $scope.personLastName = '';
        $scope.personAge = '';
        $scope.personStreetAddress = '';
        $scope.personCity = '';
        //$scope.personState = '';
        $scope.personPostalCode = '';
        $scope.homePhoneNumber = '';
        $scope.faxPhoneNumber = '';
    }

    $scope.savePersonId = function (personId) {
        $scope.deletePersonId = personId;
    }

    $scope.deletePerson = function(personId)
    {
        personsarray = PersonsService.deletePerson(personsarray, personId);
    }

    $scope.addperson = function()
    {
        personsarray = PersonsService.addPerson(personsarray, $scope);
    }
    //$scope.getCountry = function()
    //{
    //    $http.get("http://htmlweb.ru/geo/api.php?city_name=" + $scope.personCity + "&json&api_key=3dff3cb5658649e1b8a8444f22ac6843").success(function (data) {
    //        var states = [];
    //        states = data;
    //        //for (var i = 0; i < 20;i++)
    //        //{
    //        //        states.push(data[i].full_name);
    //        //}
    //        $scope.personState = states;
    //    });
    //}
}