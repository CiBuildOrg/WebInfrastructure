dotnet pack "src\Infrastructure\Skeleton.Common" -c %1 --version-suffix %2
dotnet pack "src\Infrastructure\Skeleton.Dapper" -c %1 --version-suffix %2
dotnet pack "src\Infrastructure\Skeleton.Web.Conventions" -c %1 --version-suffix %2
dotnet pack "src\Infrastructure\Skeleton.Web.Serialization" -c %1 --version-suffix %2
dotnet pack "src\Infrastructure\Skeleton.Web.Integration" -c %1 --version-suffix %2
dotnet pack "src\Infrastructure\Skeleton.Web" -c %1 --version-suffix %2
dotnet pack "src\Infrastructure\Skeleton.Web.Testing" -c %1 --version-suffix %2