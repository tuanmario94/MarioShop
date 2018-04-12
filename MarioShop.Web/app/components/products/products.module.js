﻿/// <reference path="../../../assets/admin/libs/angular/angular.js" />



(function () {
    angular.module('marioshop.products', ['marioshop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider
            .state('products', {
                url: "/products",
                templateUrl: "/app/components/products/productListView.html",
                parent: 'base',
                controller: "productListController"
            }).state('product_add', {
                url: "/product_add",
                templateUrl: "/app/components/products/productAddView.html",
                parent: 'base',
                controller: "productAddController"
            }).state('product_edit', {
                url: "/product_edit/:id",
                templateUrl: "/app/components/products/productEditView.html",
                controller: "productEditController",
                parent: 'base',
            });
    }
})();