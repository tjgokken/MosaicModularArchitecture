#!/bin/bash

FEATURE=$1
if [ -z "$FEATURE" ]; then
  echo "Usage: ./create-feature.sh FeatureName"
  exit 1
fi

BASE="App/Features/$FEATURE"
mkdir -p "$BASE/Models"

cat <<EOF > "$BASE/${FEATURE}ViewModel.cs"
public class ${FEATURE}ViewModel { }
EOF

cat <<EOF > "$BASE/I${FEATURE}Service.cs"
public interface I${FEATURE}Service { }
EOF

cat <<EOF > "$BASE/${FEATURE}Service.cs"
public class ${FEATURE}Service : I${FEATURE}Service { }
EOF

cat <<EOF > "$BASE/Models/${FEATURE}Model.cs"
public class ${FEATURE}Model { }
EOF

echo "Feature '$FEATURE' scaffolded under App/Features."
