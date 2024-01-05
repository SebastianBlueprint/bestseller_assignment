# Brand Tech .NET Assignment
## Introduction

This test is to test a candidates basic knowledge of .NET.

Create a private repository with a copy of this repository and ask us for our usernames so you can invite us

## The assignment
Create a Products API which returns data using proper REST syntax, e.g.

- `GET /products` should return a list of products
- `GET /products/1` should return the product with id = 1
- `POST /products` should create a product and return the path to said product

You should use some sort of database and add seed functionality to add some initial dummy data.

You can use data from https://fakestoreapi.com/products if you can't come up with something yourself :)

Now, create a second service which stands as a gateway to the API, so calls comes through the gateway, routes to API,
responds to user.

E.g.:

1. User requests `GET /api/products`
2. Gateway receives the call and requests the products API
   1. `GET /products`
3. Products API returns data to gateway
4. Gateway returns data to user.

What communication type you use is up to you (HTTP, gRPC, etc.)

As the last part, create a middleware in the gateway, which logs the time used to process the entire request