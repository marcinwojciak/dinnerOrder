app.controller("HomeController", function ($scope, $http) {
    $scope.message = "Herzlich Willkommen";
    $scope.restaurants = [];
    $scope.addedRestaurant = false;

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
            url: '/Home/GetRestaurantsViewModel',
        }).then(function successCallback(response) {
            $scope.restaurants = response.data.restaurants;
            }, function errorCallback(response) {
                alert('Data not found'); 
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
            if (response.data === 'Success') {
                alert("Dodano pomyślnie restaurację: " + $scope.name);
            }
            else {alert("Nie dodano restauracji: " + response.data);}
            }, function errorCallback(response) {
        });
    };

    $scope.addNewOrder = function (restId) {
        var model = { model: { RestaurantId: restId } };
        console.log(model);
        $http({
            method: 'POST',
            url: '/Home/AddNewOrder',
            data: JSON.stringify(model),
        }).then(function successCallback(response) {
            console.log(response);
            if (response.data === 'Success') {
                alert("Dodano pomyślnie zamówienie. Dziękujemy");
            }
            else { alert("Nie dodano zamówienia: " + response.data); }
        }, function errorCallback(response) {
        });
    };

    $scope.addingNewRestaurant = function () {
        $scope.addedRestaurant = !$scope.addedRestaurant;
    };
});
