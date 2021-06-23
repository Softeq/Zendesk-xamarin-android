# Zendesk-xamarin-android


## Install

Install from NuGet:
```
Install-Package Softeq.ZendeskSupportSDK.Droid
```

Install to target Android app/library:

- Dagger: https://www.nuget.org/packages/Xamarin.Google.Dagger/2.25.2.1
- Kotlin.Stdlib: https://www.nuget.org/packages/Xamarin.Kotlin.StdLib/1.3.61


## Development

Zendesk maven repository: https://zendesk.jfrog.io/artifactory/repo/com/zendesk/

Update native `.aar/.jar` libraries with their `.pom` files (contains package info and **dependencies**).

Square.Picasso 2.8 missed in NuGet (used latest 2.7+)
Dagger.Android 2.23.2 missed in NuGet


## License and Copyright

Zendesk SDKs for Xamarin.iOS is released under the MIT license. See [LICENSE](LICENSE) for details.

> Copyright 2020 Zendesk. By downloading or using the Zendesk SDKs, You agree to the [Zendesk Master Subscription Agreement](https://www.zendesk.com/company/customers-partners/#master-subscription-agreement) and [Application Developer and API License Agreement](https://www.zendesk.com/company/customers-partners/#application-developer-api-license-agreement) and acknowledge that such terms govern Your use of and access to the SDKs.
