# Zendesk SDK for Xamarin Android

[![Build Status](https://dev.azure.com/SofteqDevelopment/Xamarin.Binding.Libraries/_apis/build/status/zendesk-android-dev?branchName=main)](https://dev.azure.com/SofteqDevelopment/Xamarin.Binding.Libraries/_build/latest?definitionId=177&branchName=main)


Xamarin binding libraries for Zendesk Android SDKs:

Library Name  | Version        | NuGet
--------------|:--------------:|----------
belvedere | 3.0.0-RC | [![Softeq.ZendeskBelvedere](https://buildstats.info/nuget/Softeq.ZendeskBelvedere?includePreReleases=true)](https://www.nuget.org/packages/Softeq.ZendeskBelvedere)
belvedere-core | 3.0.0-RC | [![Softeq.ZendeskBelvedereCore](https://buildstats.info/nuget/Softeq.ZendeskBelvedereCore?includePreReleases=true)](https://www.nuget.org/packages/Softeq.ZendeskBelvedereCore)
common-ui | 4.0.1 | [![Softeq.ZendeskCommonUI.Droid](https://buildstats.info/nuget/Softeq.ZendeskCommonUI.Droid?includePreReleases=true)](https://www.nuget.org/packages/Softeq.ZendeskCommonUI.Droid)
sdk-configurations | 2.0.0 | [![Softeq.ZendeskSDKConfigurations.Droid](https://buildstats.info/nuget/Softeq.ZendeskSDKConfigurations.Droid?includePreReleases=true)](https://www.nuget.org/packages/Softeq.ZendeskSDKConfigurations.Droid)
core | 4.0.2 | [![Softeq.ZendeskCore.Droid](https://buildstats.info/nuget/Softeq.ZendeskCore.Droid?includePreReleases=true)](https://www.nuget.org/packages/Softeq.ZendeskCore.Droid)
guide | 1.0.1 | [![Softeq.ZendeskGuide.Droid](https://buildstats.info/nuget/Softeq.ZendeskGuide.Droid?includePreReleases=true)](https://www.nuget.org/packages/Softeq.ZendeskGuide.Droid)
guide-providers | 1.0.1 | [![Softeq.ZendeskGuideProviders.Droid](https://buildstats.info/nuget/Softeq.ZendeskGuideProviders.Droid?includePreReleases=true)](https://www.nuget.org/packages/Softeq.ZendeskGuideProviders.Droid)
messaging | 5.1.0 | [![Softeq.ZendeskMessaging.Droid](https://buildstats.info/nuget/Softeq.ZendeskMessaging.Droid?includePreReleases=true)](https://www.nuget.org/packages/Softeq.ZendeskMessaging.Droid)
messaging-api | 5.0.1 | [![Softeq.ZendeskMessagingAPI.Droid](https://buildstats.info/nuget/Softeq.ZendeskMessagingAPI.Droid?includePreReleases=true)](https://www.nuget.org/packages/Softeq.ZendeskMessagingAPI.Droid)
support-providers | 5.0.2 | [![Softeq.ZendeskSupportProviders.Droid](https://buildstats.info/nuget/Softeq.ZendeskSupportProviders.Droid?includePreReleases=true)](https://www.nuget.org/packages/Softeq.ZendeskSupportProviders.Droid)
support | 5.0.2 | [![Softeq.ZendeskSupport.Droid](https://buildstats.info/nuget/Softeq.ZendeskSupport.Droid?includePreReleases=true)](https://www.nuget.org/packages/Softeq.ZendeskSupport.Droid)
java-common | 1.14 | [![Softeq.ZendeskJavaCommon](https://buildstats.info/nuget/Softeq.ZendeskJavaCommon?includePreReleases=true)](https://www.nuget.org/packages/Softeq.ZendeskJavaCommon)
suas | 1.2.0 | [![Softeq.ZendeskSuas](https://buildstats.info/nuget/Softeq.ZendeskSuas?includePreReleases=true)](https://www.nuget.org/packages/Softeq.ZendeskSuas)
chat-providers | 3.3.6 | [![Softeq.ZendeskChatProviders.Droid](https://buildstats.info/nuget/Softeq.ZendeskChatProviders.Droid?includePreReleases=true)](https://www.nuget.org/packages/Softeq.ZendeskChatProviders.Droid)
chat | 3.3.6 | [![Softeq.ZendeskChat.Droid](https://buildstats.info/nuget/Softeq.ZendeskChat.Droid?includePreReleases=true)](https://www.nuget.org/packages/Softeq.ZendeskChat.Droid)
chat-socket-client | 6.1.3 | [![Softeq.ZendeskChatSocketClient.Droid](https://buildstats.info/nuget/Softeq.ZendeskChatSocketClient.Droid?includePreReleases=true)](https://www.nuget.org/packages/Softeq.ZendeskChatSocketClient.Droid)
chat-visitor-client | 8.3.3 | [![Softeq.ZendeskChatVisitorClient.Droid](https://buildstats.info/nuget/Softeq.ZendeskChatVisitorClient.Droid?includePreReleases=true)](https://www.nuget.org/packages/Softeq.ZendeskChatVisitorClient.Droid)

## Install

You can either add the NuGet package:

```
Install-Package Softeq.ZendeskSupport.Droid
```

Install to target Android app/library:

- `Xamarin.Google.Dagger`: https://www.nuget.org/packages/Xamarin.Google.Dagger/2.25.2.1
- `Xamarin.Kotlin.StdLib`: https://www.nuget.org/packages/Xamarin.Kotlin.StdLib/1.3.61

## Usage

## Basic Examples

See our [demo project](/sample) for examples.

Zendesk resources:

- [Android Documentation](https://developer.zendesk.com/documentation/zendesk-sdks/sdks/android/getting_started/)
- [Zendesk SDKs Demo](https://github.com/zendesk/android_sdk_demo_apps/)

## Development

Zendesk maven repository: https://zendesk.jfrog.io/artifactory/repo/com/zendesk/

Please, save native `.aar/.jar` libraries with their `.pom` files (contains package info and **dependencies**).

NOTES:

- `Square.Picasso` 2.8 missed in NuGet (used latest 2.7+)
- `Xamarin.Google.Dagger` 2.42 missed in NuGet (used latest 2.41.0.2)
- `Xamarin.AndroidX.AppCompat` 1.0.0 missed in NuGet (used 1.0.2.1)
- `Square.OkHttp3.LoggingInterceptor` 4.9.2 missed in NuGet (used latest 4.4.1)

### NuGet

1. Add `nuget/*.nuspec`
2. Add configuration to `azure-pipelines/nuget.yml`
3. Manually run pipeline for target project
4. Update `README.md` table for new library/version

## About

This project is maintained by [Softeq Development Corp.](https://www.softeq.com/)

We specialize in developing mobile applications using Xamarin and native technology stack.

- [Facebook](https://web.facebook.com/Softeq.by/)
- [Instagram](https://www.instagram.com/softeq/)
- [Twitter](https://twitter.com/Softeq)
- [VK](https://vk.com/club21079655)

## License and Copyright

Zendesk SDKs for Xamarin.iOS is released under the MIT license. See [LICENSE](LICENSE) for details.

> Copyright 2020 Zendesk. By downloading or using the Zendesk SDKs, You agree to the [Zendesk Master Subscription Agreement](https://www.zendesk.com/company/customers-partners/#master-subscription-agreement) and [Application Developer and API License Agreement](https://www.zendesk.com/company/customers-partners/#application-developer-api-license-agreement) and acknowledge that such terms govern Your use of and access to the SDKs.
