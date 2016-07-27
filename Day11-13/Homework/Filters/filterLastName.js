angular.module('app')
    .filter('filterLastName', function () {
        return function (items, word, typeNumber) {
            var filtered = [];
            
            for(var i=0; i<items.length; i++)
            {
                if (typeNumber == "Home Phone Number") {
                    var firstName = items[i].firstName + " " + items[i].lastName+" " +items[i].phoneNumber[0].number ;
                }
                else {
                    var firstName = items[i].firstName + " " + items[i].lastName + " " + items[i].phoneNumber[1].number;
                }
                
                if(firstName.indexOf(word)!=-1)
                {
                    filtered.push(items[i]);
                }
            }
            return filtered;
        }
    })