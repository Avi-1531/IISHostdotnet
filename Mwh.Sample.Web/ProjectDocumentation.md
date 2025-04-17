# Project Documentation

## Class: `BaseController`
Namespace: `Global`

/// BaseController ///

### Properties:


### Methods:

---
## Class: `EmployeeController`
Namespace: `Global`

/// EmployeeController ///

### Properties:


### Methods:

- `GetEmployeeDelete(int id)`: Returns `Task<ActionResult>`
  - /// GetEmployeeDelete   ///
- `GetEmployeeDelete(int? id, EmployeeDto? employee)`: Returns `Task<ActionResult>`
  - /// GetEmployeeDelete   ///
- `GetEmployeeEdit(int id)`: Returns `Task<ActionResult>`
  - /// GetEmployeeEdit   ///
- `GetEmployeeList(PagingParameterModel? paging)`: Returns `Task<ActionResult>`
  - /// GetEmployeeList   ///
- `GetEmployeeEdit(int? id, EmployeeDto? employee, CancellationToken token)`: Returns `Task<ActionResult>`
  - ///   ///
- `Index()`: Returns `ActionResult`
  - /// Default Page for Employee Controller   ///
---
## Class: `EmployeePivotController`
Namespace: `Mwh.Sample.Web.Controllers`

///   ///

### Properties:


### Methods:

- `Index()`: Returns `IActionResult`
  - ///     ///
- `GetEmployeeList()`: Returns `Task<ActionResult>`
  - /// GetEmployeeList     ///
---
## Class: `EmployeeSinglePageController`
Namespace: `Mwh.Sample.Web.Controllers`

/// Single Page Javascript Example Controller   ///

### Properties:


### Methods:

- `Index()`: Returns `IActionResult`
  - /// Default Page     ///
---
## Class: `HomeController`
Namespace: `Global`

/// Home Controller ///

### Properties:


### Methods:

- `Error()`: Returns `IActionResult`
  - /// Error Page Display   ///
- `Index()`: Returns `ActionResult`
  - /// Main Home Page   ///
---
## Class: `MvcEmployeeController`
Namespace: `Global`

/// MvcEmployeeController ///

### Properties:


### Methods:

- `Create()`: Returns `ActionResult`
  - /// Load Page to Create A New Employee   ///
- `Create(EmployeeDto? employee)`: Returns `Task<ActionResult>`
  - /// Save New Employee   ///
- `Delete(int id)`: Returns `Task<ActionResult>`
  - /// Select an Employee to delete   ///
- `Delete(int id, EmployeeDto employee)`: Returns `Task<ActionResult>`
  - /// Delete Employee   ///
- `Details(int id)`: Returns `Task<ActionResult>`
  - /// View Employee Details   ///
- `Edit(int id)`: Returns `Task<ActionResult>`
  - /// Edit an employee by ID   ///
- `Edit(int id, EmployeeDto? employee)`: Returns `Task<ActionResult>`
  - /// Save Employee   ///
- `Index(PagingParameterModel? paging)`: Returns `Task<ActionResult>`
  - /// Default Page for MvcEmployeeController   ///
---
## Class: `ConfigurationExtensions`
Namespace: `Global`

/// ConfigurationExtensions ///

### Properties:


### Methods:

- `GetInt(IConfiguration _config, string configKey, string? defaultValue)`: Returns `int`
  - ///   ///
- `GetIntList(IConfiguration _config, string configKey, string? defaultValue)`: Returns `int[]`
  - ///   ///
- `GetString(IConfiguration _config, string configKey, string? defaultValue)`: Returns `string`
  - /// Get String from Configuration   ///
- `GetStringList(IConfiguration _config, string configKey, string? defaultValue)`: Returns `string[]`
  - /// Get a List of string from Configuration   ///
---
## Class: `HttpContextExtensions`
Namespace: `Global`

/// ///

### Properties:


### Methods:

- `UseMyHttpContext(IApplicationBuilder app)`: Returns `IApplicationBuilder`
  - ///   ///
---
## Class: `MyHttpContext`
Namespace: `Global`

/// ///

### Properties:

- `Current`: `HttpContext?`
  - ///   ///
- `AppBaseUrl`: `string`
  - ///   ///

### Methods:

---
## Class: `SeedDatabase`
Namespace: `Global`

/// See Employee Database ///

### Properties:


### Methods:

- `DatabaseInitialization(EmployeeContext context)`: Returns `void`
  - /// ConfirmDatabaseCreation   ///
---
## Class: `ErrorViewModel`
Namespace: `Global`

/// ///

### Properties:

- `RequestId`: `string?`
  - ///   ///
- `ShowRequestId`: `bool`
  - ///   ///

### Methods:

---
## Class: `KeyVaultOptions`
Namespace: `Global`

/// KeyVaultOptions ///

### Properties:

- `Mode`: `KeyVaultUsage`
  - ///   ///
- `KeyVaultUri`: `string?`
  - ///   ///
- `ClientId`: `string?`
  - ///   ///
- `ClientSecret`: `string?`
  - ///   ///

### Methods:

---
## Class: `ErrorModel`
Namespace: `Mwh.Sample.Web.Pages`

### Properties:

- `RequestId`: `string?`
- `ShowRequestId`: `bool`

### Methods:

- `OnGet()`: Returns `void`
---
## Class: `BaseApiController`
Namespace: `Global`

/// Base for all Api Controllers in this project ///

### Properties:


### Methods:

---
## Class: `ErrorResource`
Namespace: `Global`

/// Error Resource ///

### Properties:

- `Messages`: `List<string>`
  - /// Messages   ///
- `Success`: `bool`
  - /// Success   ///

### Methods:

---
## Class: `StatusController`
Namespace: `Global`

/// Status Controller ///

### Properties:


### Methods:

- `ApiExplorer()`: Returns `IActionResult`
  - /// Returns Current Application Status   ///
- `ApplicationStatus()`: Returns `ApplicationStatus`
  - /// Returns Current Application Status   ///
---
## Class: `ApiExplorerModel`
Namespace: `Global`

///   ///

### Properties:

- `GroupItems`: `List<ApiDescriptionModel>`
  - ///     ///
- `GroupName`: `string`
  - ///     ///

### Methods:

---
## Class: `ApiDescriptionModel`
Namespace: `Global`

///   ///

### Properties:

- `RelativePath`: `string`
  - ///     ///

### Methods:

---
## Class: `CreateModel`
Namespace: `Mwh.Sample.Web.Pages.EmployeeRazor`

### Properties:

- `Employee`: `Employee`

### Methods:

- `OnGet()`: Returns `IActionResult`
- `OnPostAsync()`: Returns `Task<IActionResult>`
---
## Class: `DeleteModel`
Namespace: `Mwh.Sample.Web.Pages.EmployeeRazor`

### Properties:

- `Employee`: `Employee`

### Methods:

- `OnGetAsync(int? id)`: Returns `Task<IActionResult>`
- `OnPostAsync(int? id)`: Returns `Task<IActionResult>`
---
## Class: `DetailsModel`
Namespace: `Mwh.Sample.Web.Pages.EmployeeRazor`

### Properties:

- `Employee`: `Employee`

### Methods:

- `OnGetAsync(int? id)`: Returns `Task<IActionResult>`
---
## Class: `EditModel`
Namespace: `Mwh.Sample.Web.Pages.EmployeeRazor`

### Properties:

- `Genders`: `SelectList`
- `Employee`: `Employee`

### Methods:

- `OnGetAsync(int? id)`: Returns `Task<IActionResult>`
- `OnPostAsync()`: Returns `Task<IActionResult>`
---
## Class: `IndexModel`
Namespace: `Mwh.Sample.Web.Pages.EmployeeRazor`

### Properties:

- `Employee`: `IList<Employee>`

### Methods:

- `OnGetAsync()`: Returns `Task`
---
## Class: `DepartmentApiController`
Namespace: `Mwh.Sample.Web.Controllers.Api.Employee.v1`

///   ///

### Properties:


### Methods:

- `GetAsync(bool IncludeEmployees)`: Returns `Task<ActionResult<IEnumerable<DepartmentDto>>>`
  - /// Returns collection of all employees     ///
- `GetAsync(int id)`: Returns `Task<ActionResult<IEnumerable<DepartmentDto>>>`
  - /// Returns collection of all employees     ///
---
## Class: `EmployeeApiController`
Namespace: `Global`

/// Employee Api Controller ///

### Properties:


### Methods:

- `DeleteAsync(int id)`: Returns `Task<ActionResult<EmployeeResponse>>`
  - /// Deletes a given employee according to an identifier.   ///
- `FindByIdAsync(int id)`: Returns `Task<ActionResult<EmployeeResponse>>`
  - /// Returns Single Employee according to an identifier.   ///
- `ListAsync(PagingParameterModel? paging)`: Returns `Task<ActionResult<IEnumerable<EmployeeDto>>>`
  - /// Returns collection of all employees   ///
- `PostAsync(EmployeeDto employee)`: Returns `Task<ActionResult>`
  - /// Creates a new employee.   ///
- `PutAsync(int id, EmployeeDto employee)`: Returns `Task<ActionResult<EmployeeResponse>>`
  - /// Updates an existing employee according to an identifier.   ///
---
