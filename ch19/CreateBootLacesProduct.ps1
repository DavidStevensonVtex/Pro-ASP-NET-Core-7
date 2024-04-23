# Listing 19.20 Saving Boot Laces product
$response = Invoke-RestMethod http://localhost:5000/api/products -Method POST `
    -Body (@{ Name="Boot Laces"; Price=19.99; CategoryId = 2; SupplierId = 2 } | `
    ConvertTo-Json) -ContentType "application/json"
$response