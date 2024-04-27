# Listing 20.11 Requesting a string response
Invoke-WebRequest http://localhost:5000/api/content/string | `
    Select-Object @{n='Content Type'; e={ $_.Headers."Content-Type" }}, Content