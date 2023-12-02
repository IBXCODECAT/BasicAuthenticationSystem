# Code Documentation

## Overview
The provided code is a C# program that demonstrates the usage of a JWT (JSON Web Token) authentication system. It includes the creation of a JWT container with user information, token generation, validation, and extraction of claims. The goal of this project was to dive deeper into API Authentication (a topic only touched on in my
class). This repository is a bare and stripped down version of a token authentication system. **This IS NOT production ready!**

## Components

### 1. Program Class
- `Program` is the main class containing the entry point `Main` method.
- The program showcases the usage of JWT authentication.

### 2. Main Method
- The `Main` method initializes a JWT container, generates a token using a JWT service, validates the token, and extracts and displays user claims if the token is valid.

### 3. JWT Authentication
- The JWT authentication is encapsulated in the `IAuth` and `IAuthMethod` interfaces.
- `GetJWT` method creates a `JWT` object with user claims.

### 4. JWTService
- `JWTService` is an implementation of the `IAuthMethod` interface for JWT-based authentication.
- It takes a secret key during initialization and provides methods for token generation, validation, and claim extraction.

## Usage
1. The `GetJWT` method creates a `JWT` object with user claims (name and email).
2. The `JWTService` is initialized with the secret key obtained from the `IAuth` object.
3. The program generates a token using the `GenerateToken` method of the `IAuthMethod` interface.
4. The generated token is validated using the `ValidateToken` method.
5. If the token is valid, user claims (name and email) are extracted and displayed.

## Error Handling
- If token validation fails, an `UnauthorizedAccessException` is thrown.