# PHPUnit setup

This is a simple bootstrap project for PHP with PHPUnit.

## Installation

The kata uses:

- [PHP 8.1+](https://www.php.net/downloads.php)
- [Composer](https://getcomposer.org)

Recommended:

- [Git](https://git-scm.com/downloads)

Clone the repository:

```sh
git clone git@github.com:swkBerlin/kata-bootstraps.git
```

or

```shell script
git clone https://github.com/swkBerlin/kata-bootstraps.git
```

Install all the dependencies using composer:

```shell script
cd kata-bootstraps/php
composer install
```

Run the passing test:

```shell script
composer test -- --filter testNotFailing
```

## Dependencies

The kata uses composer to install:

- [PHPUnit](https://phpunit.de/) v10, which requires PHP 8.1+ (See **Legacy PHP** below for other PHP options)

## Folders

- `src` - contains the **Kata** classes, which is a basic starter code.
- `tests` - contains a passing and failing test for the **Kata** class, which is a starter test.

## Testing

PHPUnit is pre-configured to run tests. PHPUnit can be run using a composer script. To run the unit tests, from the
root of the PHP kata run:

```shell script
composer test
```

## Run from docker

A shell script to start docker has been provided:

```shell
test.sh
```

## Legacy

If you have legacy version of PHP please change **composer.json** file and include the version that is compatible with
you version of PHP, also change PHPUnit to a [supported Version](https://phpunit.de/supported-versions.html).

If you change the PHPUnit version do not forget to run:

```shell
composer update --with-dependencies
```

**Happy coding**!
