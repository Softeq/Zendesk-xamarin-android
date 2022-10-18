#!/bin/bash

# native-lib-name=BindingProjectName
map=(
    "belvedere=Belvedere"
    "belvedere-core=BelvedereCore"
    "chat=ChatSDK"
    "chat-providers=ChatProvidersSDK"
    "chat-socket-client=ChatSocketClient"
    "chat-visitor-client=ChatVisitorClient"
    "common-ui=CommonUI"
    "core=CoreSDK"
    "guide=Guide"
    "guide-providers=GuideProviders"
    "java-common=JavaCommon"
    "messaging=Messaging"
    "messaging-api=MessagingApi"
    "sdk-configurations=ConfigurationSDK"
    "support=SupportSDK"
    "support-providers=SupportProvidersSDK"
)

download_path="./.download-cache"

for lib in ${map[*]}; do
    lib_name=${lib%%=*}     # part before =
    binding_name=${lib#*=}  # part after =

    lib_files_path="$download_path/$lib_name/*"
    binding_path="./src/$binding_name.Bindings.Droid/Jars/"

    cp $lib_files_path $binding_path

    # exclude
    rm $binding_path*-javadoc.jar
done