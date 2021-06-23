# Zendesk-xamarin-android


Xamarin binding libraries for Zendesk Android SDKs:

## Install

You can either add the NuGet package:

```
Install-Package Softeq.ZendeskSupportSDK.Droid
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
- Square.Picasso 2.8 missed in NuGet (used latest 2.7+)
- Dagger.Android 2.23.2 missed in NuGet

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
