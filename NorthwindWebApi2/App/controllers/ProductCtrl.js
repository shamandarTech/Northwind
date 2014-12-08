﻿northwindApp.controller("ProductCtrl", ["$scope", "$location", "$routeParams", "ProductService", function ($scope, $location, $routeParams, productService) {
    $scope.products = [];

    productService.getAll().then(function(result) {
        $scope.products = result.data;
    });

    $scope.create = function() {
        $location.path("/product-create");
    };

    $scope.details = function(id) {
        $location.path("/product-details/" + id);
    };

    $scope.edit = function(id) {
        $location.path("product-edit/" + id);
    };

    $scope.delete = function(id) {
        $location.path("/product-delete/" + id);
    };
}]);




northwindApp.controller("CreateProductCtrl", ["$scope", "$location", "ProductService", function ($scope, $location, productService) {
    $scope.model = {};

    $scope.create = function () {
        productService.create($scope.model);

        $location.path("/products");
    };

    $scope.cancel = function () {
        $location.path("/products");
    };
}]);



northwindApp.controller("EditProductCtrl", ["$scope", "$location", "$routeParams", "ProductService", function ($scope, $location, $routeParams, productService) {
    $scope.model = {};

    productService.get($routeParams.id).then(function (result) {
        $scope.model = result.data;
    });

    $scope.edit = function (id) {
        $location.path("/product-edit/" + id);
    };

    $scope.update = function () {
        productService.update($scope.model);

        $location.path("/products");
    };

    $scope.delete = function () {
        productService.delete($scope.model);

        $location.path("/products");
    };

    $scope.cancel = function () {
        $location.path("/products");
    };
}]);