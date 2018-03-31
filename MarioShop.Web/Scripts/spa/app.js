/// <reference path="../plugins/bower-angular-master/angular.js" />

var myApp = angular.module('myModule', []);

myApp.controller("studentController", studentController);
myApp.controller("teacherController", teacherController);
myApp.controller("schoolController", schoolController);
//declare
function studentController($scope) {
    //$scope.message = "This is my message from studentController";
}
function teacherController($scope) {
    //$scope.message = "This is my message from teacherController";
}

function schoolController($scope) {
    $scope.message = "Announce from school!";
}