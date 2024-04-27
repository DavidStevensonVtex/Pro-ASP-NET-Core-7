# Listing 20.13 Requesting an XML response
Invoke-WebRequest http://localhost:5000/api/content/object `
    -Headers @{Accept="application/xml" } | `
    Select-Object @{n='Content Type'; e={ $_.Headers."Content-Type" }}, Content

# Before making any content negotiation changes in ASP.NET Core, the following JSON response was returned.

# Content Type                    Content
# ------------                    -------
# application/json; charset=utf-8 {"productId":1,"name":"Kayak","price":275.00,"categoryId":1,"supplierId":1}