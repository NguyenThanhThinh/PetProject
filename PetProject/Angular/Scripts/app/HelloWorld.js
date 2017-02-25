/// <reference path="../angular.js" />
var myApp = angular.module('liveDemoHelloWorld', []);
myApp.controller('GoodByeController', function ($scope)
{
    $scope.goodByeMessage = "Hello Again";
})
myApp.controller('HelloWorldAgainController', function ($scope) {
    $scope.newMessage = "Goodbye";
})