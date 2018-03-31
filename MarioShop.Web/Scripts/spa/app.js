/// <reference path="../plugins/bower-angular-master/angular.js" />

var myApp = angular.module('myModule', []);


myApp.controller("schoolController", schoolController);
myApp.directive("marioShopDirective", marioShopDirective);


myApp.service("validatorService", validatorService);

schoolController.$inject = ['$scope', 'validatorService']
//declare
function schoolController($scope, validatorService) {

    $scope.checkNumber = function () {
        $scope.message = validatorService.checkNumber($scope.num);
    }
    $scope.num = 1;
}

function validatorService($window) {
    return {
        //Name of value return don't need same the name of method
        checkNumber: checkNumber
    }
    function checkNumber(input) {
        if (input % 2 == 0) {
            return 'This is even';
        }
        else
            return 'This is odd';
    }
}

function marioShopDirective() {
    return {
        restrict: "A",
        templateUrl: "/Scripts/spa/marioShopDirective.html"
    }
}