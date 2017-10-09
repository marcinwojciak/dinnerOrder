app.controller("HomeController", function ($scope, $http) {
    $scope.message = "Hello World";
    $scope.restaurants = [];

    $scope.getDataTest = function () {
        $http({
            method: 'GET',
            url: '/Home/GetTestRestaurants?name=' + $scope.data,
        }).then(function successCallback(response) {
            console.log(response);
        }, function errorCallback(response) {
        });
    };

    $scope.getDataFromDb = function () {
        $http({
            method: 'GET',
            url: '/Home/GetAllRestaurants',
        }).then(function successCallback(response) {
            console.log(response);
        }, function errorCallback(response) {
        });
    };

    $scope.addDataTest = function () {
        var model = { model: { Name: $scope.name } };
        console.log(model);
        $http({
            method: 'POST',
            url: '/Home/AddRestaurant',
            data: JSON.stringify(model),
        }).then(function successCallback(response) {
            console.log(response);
            if (response.data = 'success') {
                alert("Dodano pomyślnie restaurację: " + $scope.name);
            }
        }, function errorCallback(response) {
        });
    };
});
