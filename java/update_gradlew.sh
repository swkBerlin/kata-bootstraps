#!/bin/bash
GRADLE_VERSION="6.0.1"
find . -type f -name build.gradle | xargs -I {} sh -c "dirname {}" | xargs -I {} sh -c "cd {} && pwd && gradle wrapper --gradle-version ${GRADLE_VERSION}"
