# Listing 20.12 Requesting an object response
Invoke-WebRequest http://localhost:5000/api/content/object | `
    Select-Object @{n='Content Type'; e={ $_.Headers."Content-Type" }}, Content