# Tools

## Native Android project

[Native Android project](TestZendeskNative/) to analyze Zendesk SDK dependencies.

1. Open project via Android Studio
2. Open terminal in project
3. Execute command:

### Show all dependencies

```sh
./gradlew app:dependencies
```

### HTML dependencies report

```sh
./gradlew htmlDependencyReport
```

Open: `open app/build/reports/project/dependencies/index.html`

### Generate dependencies graph

```sh
./gradlew generateDependencyGraph
```

> Open: `open build/reports/dependency-graph/dependency-graph.png`
