Invoke-RestMethod http://localhost:5000/api/suppliers/1 -Method PATCH `
    -ContentType "application/json" `
    -Body '[{"op": "replace", "path": "City", value: "Los Angeles" }]'

# supplierId name         city
# ---------- ----         ----
#          1 Splash Dudes Los Angeles