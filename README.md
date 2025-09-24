Here's the content formatted for the `README.md` file:

````markdown
# Stock API

This repository contains a simple **Stock API** built with **.NET Core** (C#), which allows users to manage stock information such as stock symbols, names, and prices. The API supports the basic **CRUD operations** (Create, Read, Update, Delete) for stock data.

The API is designed to provide stock data for an application that could be used for tracking market stocks, performing financial analysis, or integrating into a larger investment application.

## Features

- **Create** a new stock entry (symbol, name, and price).
- **Read** stock details by symbol or get a list of all available stocks.
- **Update** stock information such as price and name.
- **Delete** stock entries from the system.

## Technologies Used

- **.NET Core 6.0** (C#)
- **Entity Framework Core** (for database access)
- **SQL Server** (for database storage)
- **Azure App Service** (for deployment)

## API Endpoints

### 1. **GET /api/stocks**

Fetches a list of all stocks.

**Example request:**

```bash
GET /api/stocks
````

**Response:**

```json
[
  {
    "id": 1,
    "symbol": "AAPL",
    "name": "Apple Inc.",
    "price": 150.00
  },
  {
    "id": 2,
    "symbol": "MSFT",
    "name": "Microsoft Corp.",
    "price": 280.00
  }
]
```

### 2. **GET /api/stocks/{id}**

Fetches a single stock by its ID.

**Example request:**

```bash
GET /api/stocks/1
```

**Response:**

```json
{
  "id": 1,
  "symbol": "AAPL",
  "name": "Apple Inc.",
  "price": 150.00
}
```

### 3. **POST /api/stocks**

Creates a new stock entry.

**Example request:**

```bash
POST /api/stocks
Content-Type: application/json

{
  "symbol": "GOOGL",
  "name": "Alphabet Inc.",
  "price": 2700.00
}
```

**Response:**

```json
{
  "id": 3,
  "symbol": "GOOGL",
  "name": "Alphabet Inc.",
  "price": 2700.00
}
```

### 4. **PUT /api/stocks/{id}**

Updates an existing stock.

**Example request:**

```bash
PUT /api/stocks/1
Content-Type: application/json

{
  "id": 1,
  "symbol": "AAPL",
  "name": "Apple Inc.",
  "price": 155.00
}
```

**Response:**

```json
{
  "id": 1,
  "symbol": "AAPL",
  "name": "Apple Inc.",
  "price": 155.00
}
```

### 5. **DELETE /api/stocks/{id}**

Deletes a stock by its ID.

**Example request:**

```bash
DELETE /api/stocks/1
```

**Response:**

```json
{
  "message": "Stock deleted successfully"
}
```

## Setting Up the Project

### Prerequisites

Before running this project, ensure you have the following installed:

* [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet)
* [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or a compatible database
* [Visual Studio Code](https://code.visualstudio.com/) (optional, but recommended)

### Installation

1. **Clone the repository**:

```bash
git clone https://github.com/gaurang83/StockApi.git
```

2. **Install Dependencies**:

In the project directory, restore the necessary NuGet packages:

```bash
dotnet restore
```

3. **Update Connection String**:

Open `appsettings.json` and update the connection string to point to your local or remote SQL Server instance:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=your-server;Database=StockDB;Trusted_Connection=True;"
  }
}
```

4. **Apply Migrations**:

Create the database and apply migrations:

```bash
dotnet ef database update
```

5. **Run the Application**:

Start the application locally:

```bash
dotnet run
```

Your API will be available at `http://localhost:5000`.

## Deploying to Azure

1. **Create an Azure Web App**:

   * Go to the [Azure Portal](https://portal.azure.com).
   * Create a **Web App** under **App Services**.

2. **Publish the app** to Azure App Service:

   * Use the **Azure Publish Profile** to deploy your app using GitHub Actions (CI/CD) or manual deployment methods.
   * Alternatively, you can use **Visual Studio** to publish to Azure directly.

## Running Tests

The project includes unit tests for API functionality. You can run tests using the following command:

```bash
dotnet test
```

## Contributing

Feel free to submit **issues** or **pull requests** if you would like to contribute to the project!

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

```

### Steps to Add this README to Your GitHub Repository:

1. **Copy** the content of the above **README** file.
2. **Navigate to your repository** on GitHub.
3. Click the **Add file** button and select **Create new file**.
4. Name the file `README.md`.
5. Paste the content you copied into the file.
6. Scroll down and click the **Commit new file** button.

This will add the README file to your repository, and anyone visiting it will be able to see the documentation.

Let me know if you need any further adjustments or assistance!
```
