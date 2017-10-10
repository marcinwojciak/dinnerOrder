app.controller("HomeController", function ($scope, $http) {
    $scope.message = "Herzlich Willkommen";
    $scope.restaurants = [];
    $scope.addedRestaurant = false;
    $scope.canVote = true;

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
            $scope.restaurants = response.data.Restaurants;
            $scope.canVote = response.data.CanVote;
            $scope.restaurantsWithMostVotes = response.data.RestaurantWithMostVotes;
            console.log(response.data);
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
                $scope.canVote = false;
            }
            else { alert("Nie dodano zamówienia: " + response.data); }
        }, function errorCallback(response) {
        });
    };

    $scope.removeLastOrder = function () { ; 
        $http({
            method: 'POST',
            url: '/Home/RemoveLastOrder',
        }).then(function successCallback(response) {
            console.log(response);
            if (response.data === 'Success') {
                alert("Usunięto pomyślnie dzisiejsze zamówienie. Zagłosuj ponownie");
                $scope.canVote = true;
            }
            else { alert("Nie usunięto zamówienia: " + response.data); }
        }, function errorCallback(response) {
        });
    };

    $scope.addingNewRestaurant = function () {
        $scope.addedRestaurant = !$scope.addedRestaurant;
    };
});
