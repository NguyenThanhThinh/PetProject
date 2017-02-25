/// <reference path="../angular.js" />

var myApp = angular.module('app', []);
myApp.controller('NgChangeController', function ($scope)
{
    $scope.counter = 0;
    $scope.checkboxChange = function checkboxChange() {
        $scope.counter += 1;
    }
})