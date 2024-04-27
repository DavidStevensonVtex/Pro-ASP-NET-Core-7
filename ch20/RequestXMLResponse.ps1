# Listing 20.13 Requesting an XML response
Invoke-WebRequest http://localhost:5000/api/content/object `
    -Headers @{Accept="application/xml" } | `
    Select-Object @{n='Content Type'; e={ $_.Headers."Content-Type" }}, Content

# Before making any content negotiation changes in ASP.NET Core, the following JSON response was returned.

# Content Type                    Content
# ------------                    -------
# application/json; charset=utf-8 {"productId":1,"name":"Kayak","price":275.00,"categoryId":1,"supplierId":1}

# After making a content negotiation change in Program.cs

# Content Type                   Content
# ------------                   -------
# application/xml; charset=utf-8 <Product xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.datacontract.org/2004/07/WebApp.Models"><Category i:nil="…

# After changing ContentController.cs GetObject method:

# Content Type                   Content
# ------------                   -------
# application/xml; charset=utf-8 <ProductBindingTarget xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.datacontract.org/2004/07/WebApp.Models"><Cat…
