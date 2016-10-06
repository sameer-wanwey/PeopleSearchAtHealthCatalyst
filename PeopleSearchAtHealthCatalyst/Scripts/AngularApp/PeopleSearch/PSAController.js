angularApp.controller('PSAController',
    function PSAController($scope, PSAservice) {
        $scope.Person = PSAservice.Person;

        $scope.Search = function () {
            //Ajax call
        }

        $scope.DelayInSearch = function () {
            //Ajax call
        }
    });