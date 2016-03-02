phpunit setup
==========

This is a simple bootstrap project for PHP with phpunit

For PHP 5.6 or above just run:

```
./composer install

```

To run the tests just run:

```
./vendor/bin/phpunit

```
You need PHP 5.6 or above to run it since we have phpunit 5.2.


If you have legacy version of php please change composer.json file
and include the version that is compatible with you version of PHP


If you change the phpunit version do not forget to run:

```
./composer update --with-dependencies

```
