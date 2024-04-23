# Listing 19.18 Sending a Get request for a non-existent product
Invoke-WebRequest http://localhost:5000/api/products/1000 | Select-Object StatusCode

# StatusCode
# ----------
#        204

# The HTTP 204 No Content status code indicates that a request has been successful, 
# but there is no additional content to send in the response payload body. 