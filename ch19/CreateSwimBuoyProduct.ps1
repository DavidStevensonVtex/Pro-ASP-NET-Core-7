# Listing 19.15 Creating a Swim Buoy Product with a POST request, providing Product Id, causing error
Invoke-RestMethod http://localhost:5000/api/products -Method POST `
    -Body (@{ ProductId=100 ; Name="Swim Buoy"; Price=19.99; CategoryId = 1; SupplierId = 1 } | `
    ConvertTo-Json) -ContentType "application/json"

# Cannot insert explicit value for identity column in table 'Products' 
# when IDENTITY_INSERT is set to OFF.