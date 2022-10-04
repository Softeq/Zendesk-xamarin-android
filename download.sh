#!/bin/bash

# Repo:
# https://zendesk.jfrog.io/ui/native/repo/com/zendesk/
# lib-path/lib-name:lib-version
libs=(
    "belvedere2/belvedere:3.0.5"
    "belvedere2/belvedere-core:3.0.5"
    "chat-providers:3.3.6"
    "chat:3.3.6"
    "chat-socket-client:6.1.3"
    "chat-visitor-client:8.3.3"
    "common-ui:4.0.5"
    "sdk-configurations:2.0.3"
    "core:4.0.8"
    "guide:1.0.9"
    "guide-providers:1.0.9"
    "java-common:2.0.0" # .jar instead of .aar
    "messaging:5.2.5"
    "messaging-api:5.2.5"
    "support-providers:5.1.0"
    "support:5.1.0"
)

postfixes=(
    "-javadoc.jar"
    "-sources.jar"
    ".aar"
    ".pom"
    ".jar"
)

download_path="./.download-cache"

rm -rf $download_path

for lib in ${libs[*]}; do
    # Support any path with nesting
    lib_path=${lib%%%/*}            # part before last /
    lib_name=${lib##*/}             # part after last /
    lib_version=${lib#*:}           # part after :
    lib_path=${lib_path/$lib_name/} # empty if no path
    lib_name=${lib_name%%:*}        # part before :

    for postfix in ${postfixes[*]}; do
        artifact_path="/$lib_path/$lib_name/$lib_version/$lib_name-$lib_version$postfix"
        artifact_path=${artifact_path/\/\//\/} # fix double slashes

        output_path="$download_path/$lib_name"
        url="https://zendesk.jfrog.io/artifactory/repo/com/zendesk$artifact_path"

        wget -P $output_path $url
    done
done

echo "Success."
