(function () {
    angular.module('app').service('PersonsService', function ($http) {
        return {
            getPersons: getPersons,
            addPerson: addPerson,
            updatePerson: updatePerson,
            deletePerson: deletePerson
        }

        function getPersons() {
            return $http.get("persons.json");
        };

        function addPerson(personsarray, $scope) {
            var personinfo = {
                id: getNewId(personsarray),
                firstName: $scope.personFirstName,
                lastName: $scope.personLastName,
                age: $scope.personAge,
                address: { streetAddress: $scope.personStreetAddress, city: $scope.personCity, state: $scope.personState, postalCode: $scope.personPostalCode },
                phoneNumber: [{ type: "home", number: $scope.homePhoneNumber }, { type: "fax", number: $scope.faxPhoneNumber }]
            };
            personsarray.push(personinfo);
            return personsarray;
        };

        function getNewId(personsarray) {
            var personID = 0;
            for (var i = 0; i < personsarray.length; i++) {
                if (personID <= personsarray[i].id) {
                    personID = +personsarray[i].id + 1;
                };
            }
            return personID;
        }

        function updatePerson(personsarray, personId, $scope) {
            for (var i = 0; i < personsarray.length; i++) {
                if (personsarray[i].id == personId) {
                    personsarray[i].firstName = $scope.editPersonFirstName;
                    personsarray[i].lastName = $scope.editPersonLastName;
                    personsarray[i].age = $scope.editPersonAge;
                    personsarray[i].address.streetAddress = $scope.editPersonStreetAddress;
                    personsarray[i].address.city = $scope.editPersonCity;
                    personsarray[i].address.state = $scope.editPersonState;
                    personsarray[i].address.postalCode = $scope.editPersonPostalCode;
                    personsarray[i].phoneNumber[0].number = $scope.editPersonHomePhoneNumber;
                    personsarray[i].phoneNumber[1].number = $scope.editPersonFaxPhoneNumber;
                }
            }
            return personsarray;
        }

        function deletePerson(personsarray,personId) {
            for (var i = 0; i < personsarray.length; i++) {
                if (personId == personsarray[i].id) {
                    personsarray.splice(i, 1);
                }
            }
            return personsarray;
        }

        function getCountry()
        {
            
            

        }
      

    });
})();