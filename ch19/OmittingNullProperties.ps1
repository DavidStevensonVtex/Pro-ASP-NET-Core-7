# Listing 19.28 Omitting Null property values from a GET request
Invoke-WebRequest http://localhost:5000/api/products/1 | Select-Object Content

# Before Code change
# Content
# -------
# {"productId":1,"name":"Green Kayak","price":275.00,"categoryId":1,"category":null,"supplierId":1,"supplier":null}
