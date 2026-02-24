using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(
    "Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores",
    Justification = "Unit test naming follows https://osherove.com/blog/2005/4/3/naming-standards-for-unit-tests.html",
    Scope = "namespaceanddescendants", Target = "~N:DotnetStarter.Logic.Tests")]