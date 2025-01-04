$projects = @(
    "src\ProductLogicService\ProductLogicService.csproj"
)

foreach ($project in $projects) {
    Start-Process powershell -ArgumentList "-NoExit", "-Command", "dotnet run --project $project"
}