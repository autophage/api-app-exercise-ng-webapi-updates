'use strict';

// Declare app level module which depends on views, and components
angular.module('myApp', [
  'ngRoute',
  'myApp.view1',
  'myApp.view2',
  'myApp.version'
]).
config(['$locationProvider', '$routeProvider', function($locationProvider, $routeProvider) {
  $locationProvider.hashPrefix('!');

  $routeProvider.otherwise({redirectTo: '/view1'});
}])
.controller("PersonsController", function($scope, $http){
	$scope.people = [];
	$scope.personBeingEdited = {};
	$scope.editing = false;
	
	$scope.editPerson = function(person) {
		$scope.editing = true;
		$scope.personBeingEdited = person;
		$scope.personBeingEdited.editable = true;
	};
	
	$scope.cancelChanges = function() {
		$scope.personBeingEdited = {};
		$scope.editing = false;
	};
	
	$scope.submitChanges = function(person) {
		$scope.personBeingEdited.editable = false;
		$http({
			method: 'PUT',
			url: 'http://localhost:3928/api/Person/1/' + person.FirstName + '/' + person.LastName + '/' + person.JobTitle
		}).then(function cb(response){
			$scope.editing = false;
			$scope.personBeingEdited = {};
			
			//And then reset with the new results...
			$http({
				method: 'GET',
				url: 'http://localhost:3928/api/Person'
			}).then(function cb(response){
				$scope.people = response.data;
			});
		});
		
	};
	
	$http({
		method: 'GET',
		url: 'http://localhost:3928/api/Person'
	}).then(function cb(response){
		$scope.people = response.data;
	});
});
