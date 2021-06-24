'use strict';

myapp.controller('ProjectController', function ($scope, $http) {

    $scope.Init = function () {
        $scope.GetType();
        $scope.GetStatus();
        $scope.GetProjectMng();
    };         

    $scope.GetType = function () {
        $http.post(window.baseUrl + 'Home/GetType', {})
            .then(function (res) {
                console.log(res.data);
                $scope.type = res.data;
            });
    }

    $scope.GetStatus = function () {
        $http.post(window.baseUrl + 'Home/GetStatus', {})
            .then(function (res) {
                console.log(res.data);
                $scope.status = res.data;
            });
    }

    $scope.GetProjectMng = function () {
        $http.post(window.baseUrl + 'Home/GetProjectMng', {})
            .then(function (res) {
                console.log(res.data);
                $scope.projectmanager = res.data;
            });
    }

    $scope.GetKeyUser = function (en) {
        $http.post(window.baseUrl + 'Home/GetName', JSON.stringify(en))
            .then(function (res) {
                if (res.data == false) {
                    Swal.fire({
                        icon: 'error',
                        title: 'Invalid Employee Code'
                    })
                    $scope.keyUser.customer_Id = null;
                    $scope.keyUser.customer_Name = null;
                } else {
                    $scope.keyUser = res.data;
                }
            });
    }

    $scope.GetBusinessT = function (en) {
        $http.post(window.baseUrl + 'Home/GetName', JSON.stringify(en))
            .then(function (res) {
                if (res.data == false) {
                    Swal.fire({
                        icon: 'error',
                        title: 'Invalid Employee Code'
                    })
                    $scope.businessT.customer_Id = null;
                    $scope.businessT.customer_Name = null;
                } else {
                    $scope.businessT = res.data;
                }

            });
    }

    $scope.GetBusinessTe = function (en) {
        $http.post(window.baseUrl + 'Home/GetName', JSON.stringify(en))
            .then(function (res) {
                if (res.data == false) {
                    Swal.fire({
                        icon: 'error',
                        title: 'Invalid Employee Code'
                    })
                    $scope.businessTe.customer_Id = null;
                    $scope.businessTe.customer_Name = null;
                } else {
                    $scope.businessTe = res.data;
                }

            });
    }

    $scope.SaveProject = function (pj) {
        var pj = {
            ProjectName: $scope.pj.projectName,
            BusinessAnalyst: $scope.pj.businessAnalyst,
            JobCode: $scope.pj.jobCode,
            JobCodeName: $scope.pj.jobCodeName,
            NumSR: $scope.pj.numSR,
            NumPOT: $scope.pj.numPOT,
            Revenue: $scope.pj.revenue,
            BusinessUnit: $scope.pj.businessUnit
        }
        console.log(pj)
        $http.post(window.baseUrl + 'Home/SaveProject', JSON.stringify(pj))
            .then(function (res) {
                if (res.data == true) {
                    Swal.fire({
                        icon: 'success',
                        title: 'Save successfully'
                    })
                } else {
                    Swal.fire({
                        icon: 'error',
                        title: 'Can Not Save'
                    })
                }
                $scope.GetProject();
                $scope.pj.projectName = null;
                $scope.pj.businessAnalyst = null;
                $scope.pj.jobCode = null;
                $scope.pj.jobCodeName = null;
                $scope.pj.numSR = null;
                $scope.pj.numPOT = null;
                $scope.pj.revenue = null;
                $scope.pj.businessUnit = null;
                $('#modalAdd').modal('hide');
               
            });
    }
  

});

    

    

  
