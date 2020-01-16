#!/bin/bash

 docker run \
    -v $(pwd):/data \
    -w /data \
    -i -t composer \
    composer install --prefer-dist && ./vendor/bin/phpunit --bootstrap vendor/autoload.php tests
