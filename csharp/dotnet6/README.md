# Starter Template for new .NET Projects

This repository provides a starter template for new C# projects.

## Development

### What is inside?

**Attention:**

The contained `.editorconfig` brings formatting configuration and static code analysis rules. Violating these rules will
fail your build. You can delete or adapt this file to get more flexible rules.

Additional folders, files and configuration:

- DotnetStarter.Logic - is a DLL project for business logic
- DotnetStarter.Logic.Tests - is the corresponding xUnit test project, configured with static code rules allowing
  underscores in test names (GlobalSuppressions.cs)
- .github\dependabot.yml - configuration for the GitHub Dependabot.
- .github\workflows\dotnet.yml - automatic builds using GitHub actions.

### Creating a New Project From this Template

After having forked this starter project, you'll need to adapt the project names inside this solution and the textual description in this README.md file:

1. Change the LICENSE to your needs

2. Renaming from `DotnetStarter` to ...
    - rename the `.sln`, the contained projects and the root namespaces to match your new project
    - adapt the test entry in the `.github/workflow/dotnet.yml` file
    - adapt the test directory in the `.gitpod.yml` file

### Prerequisites

To compile, test and run this project the latest [.NET Core SDK](https://dotnet.microsoft.com/download) is required on
your machine. For calculating code metrics I recommend [metrix++](https://github.com/metrixplusplus/metrixplusplus).
This requires python.

If you are interested in test coverage, then you'll need the following tools installed:

```shell
dotnet tool install --global coverlet.console --configfile NuGet-OfficialOnly.config
dotnet tool install --global dotnet-reportgenerator-globaltool --configfile NuGet-OfficialOnly.config
```

## Build, Test, Run

Run the following commands from the folder containing the `.sln` file in order to build and test.

### Build the Solution and Run the Tests

```sh
dotnet build
dotnet test

# If you like continuous testing then use the dotnet file watcher to trigger your tests
dotnet watch -p ./DotnetStarter.Logic.Tests test

# As an alternative, run the tests with coverage and produce a coverage report
rm -r DotnetStarter.Logic.Tests/TestResults && \
  dotnet test --no-restore --verbosity normal /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput='./TestResults/coverage.cobertura.xml' && \
  reportgenerator "-reports:DotnetStarter.Logic.Tests/TestResults/*.xml" "-targetdir:report" "-reporttypes:Html;lcov" "-title:DotnetStarter"
open report/index.html
```

### Before Creating a Pull Request ...

#### Apply code formatting rules

```shell
dotnet format
```

#### Check Code Metrics

... check code metrics using [metrix++](https://github.com/metrixplusplus/metrixplusplus)

- Configure the location of the cloned metrix++ scripts
  ```shell
  export METRIXPP=/path/to/metrixplusplus
  ```

- Collect metrics
  ```shell
  python "$METRIXPP/metrix++.py" collect --std.code.complexity.cyclomatic --std.code.lines.code --std.code.todo.comments --std.code.maintindex.simple -- .
  ```

- Get an overview
  ```shell
  python "$METRIXPP/metrix++.py" view --db-file=./metrixpp.db
  ```

- Apply thresholds
  ```shell
  python "$METRIXPP/metrix++.py" limit --db-file=./metrixpp.db --max-limit=std.code.complexity:cyclomatic:5 --max-limit=std.code.lines:code:25:function --max-limit=std.code.todo:comments:0 --max-limit=std.code.mi:simple:1
  ```

At the time of writing, I want to stay below the following thresholds:

```text
--max-limit=std.code.complexity:cyclomatic:5
--max-limit=std.code.lines:code:25:function
--max-limit=std.code.todo:comments:0
--max-limit=std.code.mi:simple:1
```

Finally, remove all code duplication. The next section describes how to detect code duplication.

### Remove Code Duplication Where Appropriate

To detect duplicates I use the [CPD Copy Paste Detector](https://pmd.github.io/latest/pmd_userdocs_cpd.html)
tool from the [PMD Source Code Analyzer Project](https://pmd.github.io/latest/index.html).

If you have installed PMD by download & unzip, replace `pmd` by `./run.sh`.
The [homebrew pmd formula](https://formulae.brew.sh/formula/pmd) makes the `pmd` command globally available.

```sh
pmd cpd --minimum-tokens 50 --language cs --files .
```

## References

### .NET Core

* GitHub: [aspnet / Hosting / samples / GenericHostSample](https://github.com/aspnet/Hosting/tree/2.2.0/samples/GenericHostSample)

### Code Quality

* Continuous Testing
    * Scott
      Hanselman: [Command Line: Using dotnet watch test for continuous testing with .NET Core 1.0 and XUnit.net](https://www.hanselman.com/blog/command-line-using-dotnet-watch-test-for-continuous-testing-with-net-core-10-and-xunitnet)
    * Steve Smith (
      Ardalis): [Automate Testing and Running Apps with dotnet watch](https://ardalis.com/automate-testing-and-running-apps-with-dotnet-watch/)
* Microsoft: [Use code coverage for unit testing](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-code-coverage?tabs=linux)
* GitHub: [coverlet-coverage / coverlet](https://github.com/coverlet-coverage/coverlet)
* GitHub: [danielpalme / ReportGenerator](https://github.com/danielpalme/ReportGenerator)
* GitHub: [metrix++](https://github.com/metrixplusplus/metrixplusplus)
* [CPD Copy Paste Detector](https://pmd.github.io/latest/pmd_userdocs_cpd.html)
* [PMD Source Code Analyzer Project](https://pmd.github.io/latest/index.html).
* Scott
  Hanselman: [EditorConfig code formatting from the command line with .NET Core's dotnet format global tool](https://www.hanselman.com/blog/editorconfig-code-formatting-from-the-command-line-with-net-cores-dotnet-format-global-tool)
* [EditorConfig.org](https://editorconfig.org)
* GitHub: [dotnet / roslyn - .editorconfig](https://github.com/dotnet/roslyn/blob/master/.editorconfig)
* Check all the badges on top of this README
