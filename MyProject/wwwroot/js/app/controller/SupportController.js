﻿'use strict';

myapp.controller('SupportController', function ($scope, $http) {

    $scope.Init = function () {

        $scope.GetAppOwner();
        $scope.GetServerType();
        $scope.GetSmtp();
        $scope.GetAppstaName();
        $scope.GetOsSystem();
        $scope.GetAppStatus();
        $scope.GetSoftwareVer();
        $scope.GetDepartment();
        console.log('Work');
    };

    $scope.GetEmployee = function (en) {
        $http.post(window.baseUrl + 'Application/GetEmployee', JSON.stringify(en))
            .then(function (res) {
                if (res.data == false) {
                    Swal.fire({
                        icon: 'error',
                        title: 'Invalid Employee Code'
                    })
                    $scope.dataemp.emp_ID = null;
                    $scope.dataemp.emp_Name = null;
                    $scope.dataemp.department = null;
                } else {
                    $scope.dataemp = res.data;
                }
            });
    }

    $scope.GetFocial = function (en) {
        $http.post(window.baseUrl + 'Application/GetFocial', JSON.stringify(en))
            .then(function (res) {
                if (res.data == false) {
                    Swal.fire({
                        icon: 'error',
                        title: 'Invalid Employee Code'
                    })
                    $scope.dataempf.emp_ID = null;
                    $scope.dataempf.emp_Name = null;
                    $scope.dataempf.department = null;
                } else {
                    $scope.dataempf = res.data;
                }
            });
    }

    $scope.GetCustomer = function (en) {
        $http.post(window.baseUrl + 'Application/GetCustomer', JSON.stringify(en))
            .then(function (res) {
                if (res.data == false) {
                    Swal.fire({
                        icon: 'error',
                        title: 'Invalid Customer Code'
                    })
                    $scope.datacus.customer_Name = null;
                    $scope.datacus.customer_Company = null;
                } else {
                    $scope.datacus = res.data;
                }
            });
    }
    $scope.GetDepartment = function () {
        $http.post(window.baseUrl + 'Application/GetDepartment', {})
            .then(function (res) {
                console.log(res.data);
                $scope.department = res.data;
            });
    }






    $scope.GetServerType = function () {
        $http.post(window.baseUrl + 'Application/GetServerType', {})
            .then(function (res) {
                console.log(res.data);
                $scope.servertype = res.data;
            });
    }

    $scope.GetSmtp = function () {
        $http.post(window.baseUrl + 'Application/GetSmtp', {})
            .then(function (res) {
                console.log(res.data);
                $scope.smtp = res.data;
            });
    }

    $scope.GetAppstaName = function () {
        $http.post(window.baseUrl + 'Application/GetAppstaName', {})
            .then(function (res) {
                console.log(res.data);
                $scope.appstaname = res.data;
            });
    }

    $scope.GetOsSystem = function () {
        $http.post(window.baseUrl + 'Application/GetOsSystem', {})
            .then(function (res) {
                console.log(res.data);
                $scope.ossystem = res.data;
            });
    }

    $scope.GetAppStatus = function () {
        $http.post(window.baseUrl + 'Application/GetAppStatus', {})
            .then(function (res) {
                console.log(res.data);
                $scope.appstatus = res.data;
            });
    }

    $scope.GetSoftwareVer = function () {
        $http.post(window.baseUrl + 'Application/GetSoftwareVer', {})
            .then(function (res) {
                console.log(res.data);
                $scope.softwareVer = res.data;
            });
    }

    $scope.GetAppOwner = function (id) {
        console.log(id);
        $http.post(window.baseUrl + 'Application/GetAppOwner', JSON.stringify(id))
            .then(function (res) {
                console.log(res.data);
                $scope.appowner = res.data;
            });
    }
    $scope.SaveSupport = function (sp) {
        console.log(sp)
        var obj = {
            AppId: sp.app_id,
            AppName: sp.app_name,
            AppObj: sp.app_obj,
            AppUrl: sp.app_url,
            Company: sp.company,
            DocPath: sp.doc_path,
            FucDes: sp.func_des,
            Remark: sp.remark,
            Source_Path: sp.source_path,
            Port: sp.port,
            OcioName: sp.ocio_name,
            ProjectManager: sp.projectmanag,
            DatabaseName: sp.db_name,
            Bu: sp.bu,
            AppStatusName: sp.Appstatusname,
            AppStatus: sp.appstatus,
            Department: sp.department,
            OsSystem: sp.os,
            ServerType: sp.servertype,
            Smtp: sp.smtp,
            SoftwareVer: sp.softwareversion,
            Criticality:sp.crit,
        }
        console.log(obj)
        $http.post(window.baseUrl + 'Application/SaveSupport', JSON.stringify(obj))
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

                $scope.GetSupport();
                $scope.sp.app_id = null;
                $scope.sp.app_name = null;
                $scope.sp.app_obj = null;
                $scope.sp.app_url = null;
                $scope.sp.doc_path = null;
                $scope.sp.company = null;
                $scope.sp.func_des = null;
                $scope.sp.remark = null;
                $scope.sp.source_path = null;
                $scope.sp.port = null;
                $scope.sp.ocio_name = null;
                $scope.sp.projectmanag = null;
                $scope.sp.db_name = null;
                $scope.sp.bu = null;

                $scope.sp.Appstatusname = null;
                $scope.sp.appstatus = null;
                $scope.sp.department = null;
                $scope.sp.Os = null;
                $scope.sp.servertype = null;
                $scope.sp.smtp = null;
                $scope.sp.softwareversion = null;
                $scope.sp.crit = null;

            });
    }

    $scope.ResetForm = function (sp) {
        //Even when you use form = {} it does not work
        angular.copy({}, sp);
    }
    $scope.ShowModalAdd = function () {
        $('#modalAdd').modal('show');
    }
});