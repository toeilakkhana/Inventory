'use strict';

myapp.controller('LoginController', function ($scope, $http) {

    $scope.Init = function () {
        $scope.GetUser();
    };

    $scope.GetUser = function (lge) {
        console.log(lge)
        var obj = {
            User_Email: lge.user_Email,
            User_Pass: lge.user_Pass
        }
        console.log(obj)
        $http.post(window.baseUrl + 'Login/GetUser', JSON.stringify(obj))
            .then(function (res) {
                if (res.data == true) {
                    Swal.fire({
                        icon: 'success',
                        title: 'Login success'

                    })
                } else {
                    Swal.fire({
                        icon: 'error',
                        title: 'Invalid Username or Password'
                    })
                }
            });
    }

});
