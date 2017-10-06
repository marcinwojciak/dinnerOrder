app.controller("HomeController", function ($scope, $http) {
    $scope.message = "Hello World";

    $scope.getDataTest = function () {
        $http({
        method: 'GET',
        url: '/Home/GetTestRestaurants?name=' + $scope.data,
        }).then(function successCallback(response) {
            console.log(response);
            }, function errorCallback(response) {
    });
    };

    $scope.addDataTest = function () {
        $http({
            method: 'POST',
            url: '/Home/AddRestaurant',
            data: { 'name': $scope.name }, 
        }).then(function successCallback(response) {
            console.log(response);
        }, function errorCallback(response) {
        });
    };
});
