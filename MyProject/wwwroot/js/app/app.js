"use strict";

var myapp = angular.module('myApp', [])


myapp.directive('ngEnter', function () {
    return function (scope, element, attrs) {
        element.bind('keydown keypress', function (event) {
            var code = event.keyCode || event.which;
            if (code === 13) {
                scope.$apply(function () {
                    scope.$eval(attrs.ngEnter);
                });
                event.preventDefault();
            }
        });
    };
});