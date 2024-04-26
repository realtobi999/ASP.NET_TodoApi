# Todo List API Documentation

## Project Summary

- This is a very simple REST api containing only 5 endpoints.
- Utilizes in memory database.
- This project served as a first project in ASP.NET
- It doesn't follow any architecture due to its simplicity.

## How to run?

Just run the server using **dotnet run** and go to the swagger UI and try the endpoints for yourself!

## Api Endpoints

### `GET /api/todo_item`

Retrieve a list of all todo items.

### Response

``` json
[
  {
    "id": 1,
    "name": "Cleanup kitchen",
    "isComplete": true
  },
  {
    "id": 2,
    "name": "Write tests",
    "isComplete": false
  },
  {
    "id": 3,
    "name": "Do my homework",
    "isComplete": false
  }
]
```

---

### `GET /api/todo_item/{id}`

Retrieve a todo item by it's ID.

### Parameters

- `id` : The id of the todo item.


### Response

``` json
{
  "id": 2,
  "name": "Write tests",
  "isComplete": false
}
```

---

### `POST /api/todo_item`

Create a new todo_item with the provided details.

### Request Body

``` json
{
  "id": int,
  "name": "string",
  "isComplete": bool
}
```

### Response

``` json
{
  "id": 4,
  "name": "Study",
  "isComplete": true
}
```

---

### `PUT /api/todo_item/{id}`

Update an existing todo item information.

### Parameters

- `id` : The id of the todo item.

### Request Body

``` json
{
  "id": int,
  "name": "string",
  "isComplete": bool
}
```

### Response

``` json
{
  "id": 4,
  "name": "Study",
  "isComplete": true
}
```

---

### `DELETE /api/todo_item/{id}`

Delete an existing todo item.

### Parameters

- `id` : The id of the todo item.

### Response

Returns 204 status code when successful.
