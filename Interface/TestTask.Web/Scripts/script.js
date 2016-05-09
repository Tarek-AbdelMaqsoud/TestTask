var scotchApp = angular.module('scotchApp', ['ngRoute']);
scotchApp.config(function ($routeProvider) {
    $routeProvider

        // route for the home page
        .when('/', {
            templateUrl: 'Products/Index.html',
            controller: 'mainController'
        })

        // route for the home page
        .when('/products', {
            templateUrl: 'Products/Index.html',
            controller: 'mainController'
        })

        // route for the about page
        .when('/products/new', {
            templateUrl: 'Products/new.html',
            controller: 'newProductController'
        })
});

// create the controller and inject Angular's $scope
scotchApp.controller('mainController', function ($scope, $http) {
    $http.get('http://localhost:21354/api/products/getall').
      success(function (data, status, headers, config) {
          $scope.products = data;
      }).
      error(function (data, status, headers, config) {
          // log error
          alert("erro");
      });
});

scotchApp.controller('ProductAddController', ['$scope', '$http', function ($scope, $http) {
            $scope.submit = function () {
                if ($scope.Name) {
                    var product = {
                        "Name": $scope.Name,
                        "Description": $scope.Description,
                        "Price": $scope.Price,
                        "Count": $scope.Count
                    }
                    $http.post('http://localhost:21354/api/products/add', product).
                    success(function (data, status, headers, config) {
                        if (data == 'true') {
                            window.location = "/";
                        }
                        else {
                            alert('Invalid Data');
                        }
                    }).
                    error(function (data, status, headers, config) {
                        alert("erro");
                    });
                }
            };
        }]);