# Listing 19.26 Test ValidationSaving Boot Laces product
Invoke-WebRequest http://localhost:5000/api/products -Method POST `
    -Body (@{ Name="Boot Laces" } | `
    ConvertTo-Json) -ContentType "application/json"

    # |  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    # |  {   "Price": [     "The field Price must be between 1 and 1000."   ],   "CategoryId": [
    # | "The field CategoryId must be between 1 and 9.223372036854776E\u002B18."   ],  
    # | "SupplierId": [     "The field SupplierId must be between 1 and
    # | 9.223372036854776E\u002B18."   ] }