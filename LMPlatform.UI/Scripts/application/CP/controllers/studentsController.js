﻿angular
    .module('cpApp.ctrl.students', ['ngTable'])
    .controller('studentsCtrl', [
        '$scope',
        '$modalInstance',
        'projectService',
        'ngTableParams',
        'projectId',
        function ($scope, $modalInstance, projectService, ngTableParams, projectId) {
            
            $scope.assignProject = function (studentId) {
                        projectService.assignProject(projectId, studentId).success(function () {
                            $modalInstance.close();
                            alertify.success("Тема курсового проекта (работы) успешно назначена студенту");
                        }).error(function (data) { 
                            $modalInstance.close();
                            $scope.handleError(data.ExceptionMessage);
                        });
            };

            $scope.tableParams = new ngTableParams(
                {
                    page: 1,
                    filter: {
                        courseProjectId: projectId
                    }
                }, {
                    total: 0,
                    counts: [],
                    hideDataTablesInfo: true,
                    getData: function ($defer, params) {
                        projectService.getStudents(projectId, params.url())
                            .success(function (data) {
                                $defer.resolve(data.Items);
                                params.total(data.Total);
                            });
                    }
                });

            $scope.closeDialog = function () {
                $modalInstance.close();
            };
        }]);