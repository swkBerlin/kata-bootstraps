#!/bin/bash
find . -type f -name build.gradle | xargs -I {} sh -c "dirname {}" | xargs -I {} sh -c "cd {} && pwd && ./gradlew clean test --warning-mode all"
