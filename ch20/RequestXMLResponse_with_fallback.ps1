# Listing 20.16 Requesting an XML response with a fallback
Invoke-WebRequest http://localhost:5000/api/content/object `
    -Headers @{Accept="application/xml, */*;q=0.8" } | `
    Select-Object @{n='Content Type'; e={ $_.Headers."Content-Type" }}, Content


# The fallback Accept means that a JSON response will be sent

# Content Type                    Content
# ------------                    -------
# application/json; charset=utf-8 {"name":"Kayak","price":275.00,"categoryId":1,"supplierId":1}

# After setting RespectBrowserAcceptHeader to true in Program.cs file:

# Content Type                   Content
# ------------                   -------
# application/xml; charset=utf-8 <ProductBindingTarget xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.datacontract.org/2004/07/WebApp.Models"><Cat…
