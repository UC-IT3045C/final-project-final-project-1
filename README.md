```mermaid
---
title: Final Project Class Diagram
---
classDiagram
    Currency <|-- Category : One to Many
    Currency <|-- User : Accesses
    
    
    User --|> IdentityUser : Inherits from
    IdentityUser <|-- MicrosoftAspNetCoreIdentity
    Role --|> IdentityRole : Inherits from
    IdentityRole <|-- MicrosoftAspNetCoreIdentity
    User --|> Portfolio : Has One
    Portfolio --|> PortfolioToken : Contains Many
    PortfolioToken --|> User : Has One 
    Currency <|-- Conversions : Contains Many
    User <|--|> Role : Many-to-Many (Using Join Table)
    class Currency{
        +int CurrencyId PK
        +String CurrencyName
        +String Slug
        +String Symbol
        +Double PercentChange24Hr
        +String Description
        +Double Price 
        +Double Volume24 
        +Double PercentChange1hr
        +Double PercentChange7d
        +Double MarketCap
        +Double TotalSupply
    }
    class Category{
        +int CategoryId PK
        +string CMCCategoryId
        +String CategoryName
        +String CategoryTitle
        +String Description
        +Int NumTokens
        +Double AvgPriceChange
        +Double MarketCap
        +Double MarketCapChange
        +Double Volume
        +Double VolumeChange
        +Double LastUpdated
        +List<Currency> Coins
    }
    class Conversion{
        +int ConversionId PK

        +string? Pair1

        +string? Pair2

        +DateTime CreatedOn

        +double? PercentChange24Hr

        +string? Description

        +double? Price

        +double? Volume24

        +double? PercentChange1hr

        +double? PercentChange7d

        +double? MarketCap

        +double? TotalSupply

        +double? SecondPercentChange24Hr

        +string? SecondDescription

        +double? SecondPrice

        +double? SecondVolume24

        +double? SecondPercentChange1hr

        +double? SecondPercentChange7d

        +double? SecondMarketCap

        +double? SecondTotalSupply
    }
    class Portfolio{
        +String walletAddress
        +List<Currency> currencies
        +Double portfolioValue
        +int PortfolioId PK
        +String UserId FK
        
    }
    class PortfolioToken{
        +int PortfolioTokenId PK
        +string UserId FK
        +string TokenAmount
        +string TokenName
    }
    class User{
        +int Id PK
        +String UserName
        +String Email
        -int permissionsLevel
        +int PortfolioId FK
        +List<Role> Roles 
    }
    class IdentityUser{
        +int Id PK
        +String UserName
        +String Email
        +bool EmailConfirmed
        +bool LockoutEnabled
        +ICollection<TUserLogin> Logins
        +String NormalizedEmail
        +String NormalizedUserName
        +String PasswordHash
        +String PhoneNumber
        +bool PhoneNumberConfirmed
        +ICollection<TUserRole> Roles
        +String SecurityStamp
        +bool TwoFactorEnabled
        +int AccessFailedCount
        +ICollection<TUserClaim> Claims
        +DateTimeOffset LockoutEnd
    }
    class IdentityRole{
        +ICollection<TRoleClaim> Claims
        +String Concurrency Stamp
        +String Id PK
        +String Name
        +String NormalizedName
        +ICollection<TUserRole> Users
    }
    class Role{
        +String Id PK
        +String Name
        +List<User> Users
    }
```


- Category model is based off the one used in by CoinMarketCap.
- Currency model is based off the one used in CoinMarketCap and uses Quartz.net to update the data
- User and Role are children of IdentityUser and IdentityRole which come from Microsoft.AspNetCore.Identity.
- User is connected with a many-to-many relationship to Role via the UsersRoles table
- Currency is connected with a many-to-many relationship to Portfolio via the CurrenciesPortfolios table

