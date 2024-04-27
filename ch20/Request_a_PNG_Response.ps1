# Listing 20.17 Requesting a PNG response
Invoke-WebRequest http://localhost:5000/api/content/object `
    -Headers @{Accept="img/png" } | `
    Select-Object @{n='Content Type'; e={ $_.Headers."Content-Type" }}, Content


# The image request Accept means that a JSON response will be sent

# Content Type                    Content
# ------------                    -------
# application/json; charset=utf-8 {"name":"Kayak","price":275.00,"categoryId":1,"supplierId":1}

# After setting RespectBrowserAcceptHeader to true in Program.cs file:

#      | Response status code does not indicate success: 406 (Not Acceptable).
