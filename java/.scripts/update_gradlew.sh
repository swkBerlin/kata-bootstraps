#!/bin/bash
GRADLE_VERSION="7.2"
find ../. -maxdepth 2 -type f -name build.gradle | xargs -I {} sh -c "dirname {}" | xargs -I {} sh -c "cd {} && pwd && gradle wrapper --gradle-version ${GRADLE_VERSION}"
