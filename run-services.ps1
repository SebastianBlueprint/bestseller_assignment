$projects = @(
    "src\ProductLogicService\ProductLogicService.csproj"
    "src\Gateway\Gateway.csproj"
)

foreach ($project in $projects) {
    Start-Process powershell -ArgumentList "-NoExit", "-Command", "dotnet run --project $project"
    Start-Sleep -Seconds 3
}