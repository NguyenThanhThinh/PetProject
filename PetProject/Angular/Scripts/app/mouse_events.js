/// <reference path="../angular.js" />

var myApp = angular.module('app', []);
myApp.controller('NgChangeController', function ($scope) {
    $scope.clickCounter = 0;
    $scope.doubleClickCounter = 0;
    $scope.mouseUpDownText = 'Hover me';
    $scope.clicked = function clicked() {
        $scope.clickCounter += 1;
    }
    $scope.doubleClicked = function doubleClicked() {
        $scope.doubleClickCounter += 1;
    }
    $scope.onMouseEnter = function onMouseEnter() {
        $scope.mouseUpDownText = 'Mouse inside';
    }
    $scope.onMouseLeave = function onMouseLeave() {
        $scope.mouseUpDownText = 'Mouse outside';
    }
})