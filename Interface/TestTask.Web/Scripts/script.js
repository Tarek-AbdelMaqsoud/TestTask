var scotchApp = angular.module('scotchApp', ['ngRoute']);
scotchApp.config(function ($routeProvider) {
    $routeProvider

        .when('/', {
            templateUrl: 'Products/Index.html',
            controller: 'mainController'
        })

        .when('/products', {
            templateUrl: 'Products/Index.html',
            controller: 'mainController'
        })

        .when('/products/new', {
            templateUrl: 'Products/new.html',
            controller: 'ProductAddController'
        })
});

scotchApp.controller('mainController', function ($scope, $http) {
    $http.get('http://localhost:21354/api/products/getall').
      success(function (data, status, headers, config) {
          $scope.products = data;
      }).
      error(function (data, status, headers, config) {
          alert("error");
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