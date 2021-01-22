#!/bin/bash

 docker run \
    -v $(pwd):/data \
    -w /data \
    -t grihabor/pytest \
    python -m pytest tests/test_thing_fixture.py
