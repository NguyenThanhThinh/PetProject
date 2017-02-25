var myAppp = angular.module('myApp', []);
myAppp.controller('studentController', studentController);
myAppp.controller('teacherController', teacherController);
myAppp.controller('schoolController', schoolController);

function schoolController($scope) {
    $scope.message = "Hello school";
}
function studentController($scope) {
    //$scope.message = "Hello student";
}
function teacherController($scope) {
    //$scope.message = "Hello teacher";
}